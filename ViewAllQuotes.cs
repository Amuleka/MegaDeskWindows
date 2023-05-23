using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_2
{
    public partial class ViewAllQuotes : Form
    {


        public ViewAllQuotes()
        {
            InitializeComponent();

            loadFromFile();
        }

        private void closeViewAllQuotesBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();

        }
        public void loadFromFile()
        {
            var quoteFile = @"quotes.json";
            if (File.Exists(quoteFile))
            {
                using (StreamReader reader = new StreamReader(quoteFile))
                {
                    string allQuotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotesList = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);
                    dataGridViewAll.DataSource = deskQuotesList.Select(d => new
                    {
                        Date = d.Date,
                        Customer = d.CustomerFullName,
                        Depth = d.Desk.DeskDepth,
                        Width = d.Desk.DeskWidth,
                        Drawers = d.Desk.DrawerCount,
                        SurfaceMaterial = d.Desk.Material,
                        Delivery = d.RushDays.ToString(),
                        QuotePrice = d.TotalQuoteAmount.ToString("c")

                    }
                        ).ToList();
                }
            }
        }
    }
}
