using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MegaDesk_2
{
    public enum ShippingOptions
    {
        [Description("Rush 3 Days")]
        Rush3Days,
        [Description("Rush 5 Days")]
        Rush5Days,
        [Description("Rush 7 Days")]
        Rush7Days,
        [Description("No Rush")]
        Normal14Days
    }
    // https://www.codingame.com/playgrounds/2487/c---how-to-display-friendly-names-for-enumerations

    internal class DeskQuote
    {
        public string Date = DateTime.Now.ToString("MMM dd, yyyy");
        private Desk newDesk = new Desk(); //DeskWidth, DeskDepth, DrawerCount, Material
        public string CustomerFullName;
        public bool RushOrder;
        public int RushDays;
        private int RushCost;
        private decimal TotalSurfaceArea;
        public int materialCost;
        public decimal TotalQuoteAmount { get; set; }
        private const int BasePrice = 200;
        private const int SurfaceAreaPerInch = 1;
        private const int CostPerDrawer = 50;
        public static int[,] rushOrder = new int[3, 3];

        public Desk Desk { get; set; }
        public decimal SurfaceArea(decimal width, decimal depth)
        {
            newDesk.DeskWidth = width;
            newDesk.DeskDepth = depth;
            TotalSurfaceArea = newDesk.DeskWidth * newDesk.DeskDepth;
            return TotalSurfaceArea;
        }

        public void ChooseSurfaceType(SurfaceType surfaceType)
        {

            switch (surfaceType)
            {
                case SurfaceType.Laminate:
                    materialCost = 100;
                    break;
                case SurfaceType.Oak:
                    materialCost = 200;
                    break;
                case SurfaceType.Rosewood:
                    materialCost = 300;
                    break;
                case SurfaceType.Veneer:
                    materialCost = 125;
                    break;
                case SurfaceType.Pine:
                    materialCost = 50;
                    break;
                default: return;
            }

        }

        public void GetRushOrder(bool isRushOrder, int rushDays)
        {
            rushOrder = getRushOrderPrice();
            try
            {
                // calculate shipping
                RushOrder = isRushOrder;
                RushDays = rushDays;
                if (RushOrder && RushDays == 0)
                {
                    if (TotalSurfaceArea <= 1000) { RushCost = rushOrder[0, 0]; }
                    else if (TotalSurfaceArea > 2000) { RushCost = rushOrder[0, 1]; }
                    else { RushCost = rushOrder[0, 2]; }
                }
                else if (RushOrder && RushDays == 1)
                {
                    if (TotalSurfaceArea <= 1000) { RushCost = rushOrder[1, 0]; }
                    else if (TotalSurfaceArea > 2000) { RushCost = rushOrder[1, 1]; }
                    else { RushCost = rushOrder[1, 2]; }
                }
                else if (RushOrder && RushDays == 2)
                {
                    if (TotalSurfaceArea <= 1000) { RushCost = rushOrder[2, 0]; }
                    else if (TotalSurfaceArea > 2000) { RushCost = rushOrder[2, 1]; }
                    else { RushCost = rushOrder[2, 2]; }
                }
                else
                {
                    RushCost = 0;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string[] ReadRushOrderPrices()
        {
            string[] priceList = new string[9];
            try
            {
                string file = "rushOrderPrices.txt";
                StreamReader reader = new StreamReader(file);
                int i = 0;
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    priceList[i] = line;
                    i++;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong. " + e);
                Application.Exit();
            }
            return priceList;

        }

        public static int[,] getRushOrderPrice()
        {
            int[,] rushOrder = new int[3, 3];
            string[] priceList = new string[9];
            priceList = ReadRushOrderPrices();
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rushOrder[i, j] = int.Parse(priceList[index]);
                    index++;
                }
            }
            return rushOrder;

        }

        public decimal NewDeskQuote(string name, decimal width, decimal depth, int drawerCount, int materialCost, bool isRushOrder, int rushDays = 3)
        {
            CustomerFullName = name;
            TotalSurfaceArea = SurfaceArea(width, depth);
            newDesk.DrawerCount = drawerCount;
            GetRushOrder(isRushOrder, rushDays);
            decimal cost = 0m;
            if (TotalSurfaceArea > 1000)
            {
                cost += (TotalSurfaceArea - 1000) * DeskQuote.SurfaceAreaPerInch;
            }
            cost += DeskQuote.BasePrice;
            cost += newDesk.DrawerCount * DeskQuote.CostPerDrawer;
            cost += materialCost;
            return cost;
        }


    }
}
