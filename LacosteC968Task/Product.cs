// Product.cs
// Defines the Product class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace LacosteC968Task
{
    // Defines Product class
    class Product
    {
        [DisplayName("Product ID")]
        public int ProductID { get; set; }
        public string Name { get; set; }

        [DisplayName("Inventory")]
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public void AssocParts(BindingList<Part> associatedParts)
        {
            foreach (Part assocPart in associatedParts)
                AssociatedParts.Add(assocPart);
        }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();


        // Constructor
        public Product(int partID, string name, decimal price, int inStock, int prodMin, int prodMax, BindingList<Part> associatedParts)
        {
            ProductID = partID;
            Name = name;
            InStock = inStock;
            Price = price;  
            Min = prodMin;
            Max = prodMax;
            AssocParts(associatedParts);            
        }

        public void addAssociatedPart(Part part1)
        {
                AssociatedParts.Add(part1);

        }

        public void removeAssociatedPart(int partID)
        {
            try
            {
                for (int i = 0; i < AssociatedParts.Count; i++)
                {
                    if (AssociatedParts[i].PartID == partID)
                    {
                        AssociatedParts.Remove(AssociatedParts[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unable to remove part.");
            }

           
        }

        public void lookupAssociatedPart(int partID)
        {
            foreach (Part element in AssociatedParts)
            {
                if (element.PartID == partID)
                {
                    MessageBox.Show($"Part {element.Name} associated with this product.");
                }
            }
            
        }
       

    }
}
