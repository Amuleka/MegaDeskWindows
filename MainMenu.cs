using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_2
{
    public partial class MainMenu : Form
    {
        //private Form _mainMenu;
        // public MainMenu(Form mainMenu)
        public MainMenu()
        {
            InitializeComponent();
            //  _mainMenu = mainMenu;
        }

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            #region 

            #endregion
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }

        private void viewQuoteBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewAllQuotes = new ViewAllQuotes();
            viewViewAllQuotes.Tag = this;
            viewViewAllQuotes.Show(this);
            Hide();
        }

        public void displayNewQuoteBtn_Click(object sender, EventArgs e)
        {
            DisplayQuote viewDisplayQuote = new DisplayQuote();
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();
        }

        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }

        private void exitApplicationBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        // <a href='https://pngtree.com/so/yellow'>yellow png from pngtree.com/</a> image
    }
}
