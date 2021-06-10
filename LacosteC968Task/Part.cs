// Part.cs
// Defines the abstract Part class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LacosteC968Task
{
    public abstract class Part
    {
        [DisplayName("Part ID")]
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [DisplayName("Inventory")]
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // Constructor
        public Part(int partID, string name, decimal price, int inStock, int partMin, int partMax)
            {

            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = partMin;
            Max = partMax;

            }
    }
}
