// Inventory.cs
// Defines the Inventory class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace LacosteC968Task
{
	static class Inventory
	{
		// Creates empty containers for parts and products.
		public static BindingList<Part> AllParts = new BindingList<Part>();
		public static BindingList<Product> Products = new BindingList<Product>();

		// Adds a product to inventory.
		static public void addProduct(Product prod1) 
		{
			Products.Add(prod1);
		}

		// Removes a product to inventory.
		static public void removeProduct(int prodID)
        {
            try
            {
				Product target = Products.SingleOrDefault(p => p.ProductID == prodID);
				Products.Remove(target);
			}
            catch
            {
				MessageBox.Show("Could not locate product.");
            }

		}

		// Looks up a product.
		static public void lookupProduct(int prodID)
        {
			foreach(Product element in Products)
            {
				if (element.ProductID == prodID)
                {
					MessageBox.Show($"Product ID {prodID} is assigned to {element.Name}");
					
                }
            }
		}

		// Updates a product.
		static public void updateProduct(int prodID, Product prod1)
        {
			Products[prodID] = prod1;
        }
		// Adds a part.
		static public void addPart(Part part1)
        {
			AllParts.Add(part1);
        }
		// Deletes a part.
		static public void deletePart(Part part1)
        {
			AllParts.Remove(part1);
        }
		// Looks up a part.
		static public void lookupPart(int partID)
        {
			foreach (Part element in AllParts)
            {
				if (element.PartID == partID)
                {
					MessageBox.Show($"Located {element.Name} in Parts list.");
                }
            }
        }
		// Updates a part.
		static public void updatePart(int prodID, Part part1)
        {
			AllParts[prodID] = part1;
        }
	}
}
