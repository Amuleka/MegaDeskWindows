using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace MegaDesk_2
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        //public AddQuote(Form mainMenu)
        public AddQuote()
        {
            InitializeComponent();
            //_mainMenu = mainMenu;
            // use enum for loading the list
            var materials = Enum.GetValues(typeof(SurfaceType))
                .Cast<SurfaceType>()
                .ToList();

            SurfaceMaterialType.DataSource = materials;
            SurfaceMaterialType.SelectedIndex = -1;

            // same way for shipping options
            List<ShippingOptions> shipping = Enum.GetValues(typeof(ShippingOptions))
                .Cast<ShippingOptions>()
                .ToList();
            List<string> shippingDescriptions = new List<string>();
            foreach (var ship in shipping)
            {
                string description = ship.GetType()
                                    .GetMember(ship.ToString())
                                    .First()
                                    .GetCustomAttribute<DescriptionAttribute>()
                                    .Description;
                shippingDescriptions.Add(description);
            }

            rushDays.Enabled = false;
            rushDays.DataSource = shippingDescriptions;
            rushDays.SelectedIndex = 3; // default at normal delivery

        }

        private void CloseAddQuoteBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void CustomerFullName_TextChanged(object sender, EventArgs e)
        {
            if (CustomerFullName.Text.Length == 0 || CustomerFullName.Text == null)
            {
                this.CustomerFullName.Focus();
                MessageBox.Show("This box must have a name");
            }
        }

        private void SurfaceMaterialType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (SurfaceMaterialType.Text.Length == 0 || SurfaceMaterialType.Text == null)
            {
                this.SurfaceMaterialType.Focus();
                MessageBox.Show("This box must have a material chosen");
            }
        }

        private void RushOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (!rushOrder.Checked)
            {
                rushOrder.Checked = false;
                rushDays.Enabled = false;
            }
            else
            {
                rushOrder.Checked = true;
                rushDays.Enabled = true;
            }

        }

        private bool ValidateFormData()
        {
            // Validate customer full name
            if (string.IsNullOrEmpty(CustomerFullName.Text))
            {
                MessageBox.Show("Please enter the customer's full name.");
                return false;
            }

            // Validate desk width
            int width = (int)DeskWidth.Value;
            if (width < 24 || width > 96)
            {
                MessageBox.Show("The desk width must be between 24 and 96 inches.");
                return false;
            }

            // Validate desk depth
            int depth = (int)DeskDepth.Value;
            if (depth < 12 || depth > 48)
            {
                MessageBox.Show("The desk depth must be between 12 and 48 inches.");
                return false;
            }

            // Validate number of drawers
            int drawers = (int)DrawerCount.Value;
            if (drawers < 0 || drawers > 7)
            {
                MessageBox.Show("The number of drawers must be between 0 and 7.");
                return false;
            }

            // Validate surface material
            if (SurfaceMaterialType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a surface material.");
                return false;
            }

            return true;
        }

        private void CalculateQuoteBtn_Click(object sender, EventArgs e)
        {
            // Perform data validation
            if (!ValidateFormData())
            {
                return;
            }

            // show displayQuoteForm
            var displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Tag = this;

            string surface = SurfaceMaterialType.Text;
            if (string.IsNullOrEmpty(SurfaceMaterialType.Text))
            {
                MessageBox.Show("Choose a material for the desk surface.");
                this.SurfaceMaterialType.Focus();
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var desk = new Desk
                {
                    DeskDepth = DeskDepth.Value,
                    DeskWidth = DeskWidth.Value,
                    DrawerCount = (int)DrawerCount.Value,
                    Material = (SurfaceType)SurfaceMaterialType.SelectedValue
                };

                var deskQuote = new DeskQuote
                {
                    RushOrder = !rushOrder.Checked ? false : rushOrder.Checked,
                    CustomerFullName = CustomerFullName.Text,
                    Date = DateTime.Now.ToString("MMM dd, yyyy"),
                    RushDays = rushDays.SelectedIndex,
                    Desk = desk
                };

                surface = surface.ToString();
                SurfaceType surfaceMaterial = (SurfaceType)Enum.Parse(typeof(SurfaceType), surface);
                deskQuote.ChooseSurfaceType(surfaceMaterial);
                //deskQuote.Desk = desk;
                decimal quoteInfo = deskQuote.NewDeskQuote(deskQuote.CustomerFullName, desk.DeskWidth, desk.DeskDepth, desk.DrawerCount, deskQuote.materialCost, deskQuote.RushOrder, deskQuote.RushDays);
                deskQuote.TotalQuoteAmount = quoteInfo;

                // print to screen on form
                displayQuoteForm.DisplayText = $"Desk Quote: ";
                displayQuoteForm.CustomerNameText = deskQuote.CustomerFullName;
                displayQuoteForm.QuoteDateText = deskQuote.Date;
                displayQuoteForm.WidthText = desk.DeskWidth.ToString();
                displayQuoteForm.DepthText = desk.DeskDepth.ToString();
                displayQuoteForm.NumberOfDrawersText = desk.DrawerCount.ToString();
                displayQuoteForm.MaterialText = surface;
                displayQuoteForm.TypeOfDeliveryText = rushDays.Text;
                displayQuoteForm.TotalQuotePriceText = quoteInfo;

                // write quote to quotes.json

                SaveQuoteToFile(deskQuote);

                displayQuoteForm.Show();
                this.Hide();

            }
        }

        private void SaveQuoteToFile(DeskQuote saveQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskQuotesList = new List<DeskQuote>();
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string eachQuote = reader.ReadToEnd();
                    if (eachQuote.Length > 0)
                    {
                        deskQuotesList = JsonConvert.DeserializeObject<List<DeskQuote>>(eachQuote);
                    }
                }
            }
            deskQuotesList.Add(saveQuote);
            var serializeQuote = JsonConvert.SerializeObject(deskQuotesList, Formatting.Indented);
            File.WriteAllText(quotesFile, serializeQuote);
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = this.Tag as MainMenu;
            mainMenu.Show();
        }

    }

}
