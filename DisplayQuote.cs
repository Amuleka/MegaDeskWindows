using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MegaDesk_2
{
    public partial class DisplayQuote : Form
    {

        private Form _mainMenu;

        public DisplayQuote()
        {
            InitializeComponent();

        }
        public string DisplayText { get; set; }
        public string DisplayQuoteInformation { get; set; }
        public string QuoteDateText { get; set; }
        public string CustomerNameText { get; set; }
        public string WidthText { get; set; }
        public string DepthText { get; set; }
        public string MaterialText { get; set; }
        public string NumberOfDrawersText { get; set; }
        public string TypeOfDeliveryText { get; set; }
        public decimal TotalQuotePriceText { get; set; }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            //loads the quote to the Display form
            QuoteDate.Text = QuoteDateText;
            CustomerName.Text = CustomerNameText;
            Width.Text = WidthText;
            Depth.Text = DepthText;
            Material.Text = MaterialText;
            NumberOfDrawers.Text = NumberOfDrawersText;
            TypeOfDelivery.Text = TypeOfDeliveryText;
            TotalQuotePrice.Text = TotalQuotePriceText.ToString();
        }

        private void CloseDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = (AddQuote)Tag;
            addQuote.Show();
            Close();
        }

        private void SaveQuote_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Quote Saved. ");
        }


    }
}

