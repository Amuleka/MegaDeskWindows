using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_2
{
    public partial class SearchQuotes : Form
    {
        //List<SurfaceType> materials = Enum.GetValues(typeof(SurfaceType))
        //        .Cast<SurfaceType>()
        //        .ToList();

        public SearchQuotes()
        {
            InitializeComponent();
            // use enum for loading the list
            var materials = Enum.GetValues(typeof(SurfaceType))
                .Cast<SurfaceType>()
                .ToList();
            loadFromFile();
            SearchOrdersByMaterial.DataSource = materials;
            SearchOrdersByMaterial.SelectedIndex = -1;

            // https://www.codingame.com/playgrounds/2487/c---how-to-display-friendly-names-for-enumerations

        }

        private void SearchQuoteCloseBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void SearchOrdersByMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxOrdersByMaterial = (ComboBox)sender;


            if (SearchOrdersByMaterial.SelectedIndex == -1)
            {

                loadFromFile();

            }
            else
            {
                loadFromFile(SearchOrdersByMaterial.SelectedItem.ToString());
            }

        }

        public void loadFromFile(string surfaceChoice)
        {
            var quoteFile = @"quotes.json";
            if (!File.Exists(quoteFile))
            {
                File.Create(quoteFile);
            }
            else

            {
                using (StreamReader reader = new StreamReader(quoteFile))
                {

                    string allQuotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotesList = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);
                    DisplaySearchOrders.DataSource = deskQuotesList.Select(d => new

                    {
                        Date = d.Date,
                        Customer = d.CustomerFullName,
                        Depth = d.Desk.DeskDepth,
                        Width = d.Desk.DeskWidth,
                        Drawers = d.Desk.DrawerCount,
                        SurfaceMaterial = d.Desk.Material,
                        Delivery = d.RushDays,
                        QuotePrice = d.TotalQuoteAmount.ToString("c")

                    }
                    ).Where(x => surfaceChoice == x.SurfaceMaterial.ToString()).ToList();

                }
            }
        }


        public void loadFromFile()
        {
            var quoteFile = @"quotes.json";
            if (!File.Exists(quoteFile))
            {
                File.Create(quoteFile);
            }
            else
            {
                using (StreamReader reader = new StreamReader(quoteFile))
                {
                    string allQuotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotesList = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);

                    DisplaySearchOrders.DataSource = deskQuotesList.Select(d => new
                    {
                        Date = d.Date,
                        Customer = d.CustomerFullName,
                        Depth = d.Desk.DeskDepth,
                        Width = d.Desk.DeskWidth,
                        Drawers = d.Desk.DrawerCount,
                        SurfaceMaterial = d.Desk.Material,
                        Delivery = d.RushDays,
                        QuotePrice = d.TotalQuoteAmount.ToString("c")

                    }
                        ).ToList();
                }
            }
        }
    }
}


