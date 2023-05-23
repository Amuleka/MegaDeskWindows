using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
            #region Requirement Notes     
            /*
         * 
         *Required Inputs and Input Constraints:
        customer full name
        size of desk in width(minimum 24 inches and maximum 96 inches)
        size of the desk in depth(minimum 12 inches and maximum of 48 inches)
        number of drawers(zero to seven drawers maximum)
        desktop surface material(laminate, oak, rosewood, veneer, or pine)
        rush order options of 3, 5, or 7 days.The normal production time is 14 days.
            Output:
        a single price quote is given with valid input submission
        a view of all stored price quotes that can be sorted
        the ability to search for and list specific price quotes based upon desktop material
            Views:
        main menu with buttons to 
        add a new quote, 
        view all quotes, 
        search quotes, and 
        exit the application

        add new quote with a confirmation summary of the quote including the total price
        view all quotes in a list
        search quotes by desktop material
        */
            #endregion






        }
    }
}
