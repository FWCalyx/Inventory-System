// Program.cs
// Entry point.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace LacosteC968Task
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BindingList<Part> blankList = new BindingList<Part>(); // An empty list for future associated parts to populate.

            // Starting parts
            Inventory.AllParts.Add(new InHousePart(0, "Wheel", (decimal)12.11, 15, 5, 25, 500));
            Inventory.AllParts.Add(new OutsourcedPart(1, "Pedal", (decimal)8.22, 11, 5, 25, "Kord Industries"));
            Inventory.AllParts.Add(new InHousePart(2, "Chain", (decimal)8.33, 12, 5, 25, 256));
            Inventory.AllParts.Add(new OutsourcedPart (3, "Seat", (decimal)4.55, 8, 2, 15, "Palmer Technologies"));

            // Starting products

            Inventory.Products.Add(new Product(0, "Red Bicycle", (decimal)11.44, 15, 1, 25, blankList));
            Inventory.Products.Add(new Product(1, "Yellow Bicycle", (decimal)9.66, 19, 1, 20, blankList));
            Inventory.Products.Add(new Product(2, "Blue Bicycle", (decimal)12.77, 5, 1, 25, blankList));

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
