// MainForm.cs
// Defines the Main Screen for the application.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacosteC968Task
{

    public partial class MainScreen : Form
    {
        // Variables to manage part and product selections from DGVs.
        int PartsIndex;
        Part PartsObj;
        int ProdIndex;
        Product ProdObj;

        // MainScreen form, provides datasource for datagridviews.
        public MainScreen()
        {
            InitializeComponent();
            mainPartsDGV.DataSource = Inventory.AllParts;
            mainProdDGV.DataSource = Inventory.Products;
        }

        // Main Functions

        // Exit button
        private void mainExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        // Functions for the Parts section.
        private void mainPartSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> partSearch = new BindingList<Part>();
            bool found = false;
            if (mainPartSearchText.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(mainPartSearchText.Text.ToUpper()))
                    {
                        partSearch.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    mainPartsDGV.DataSource = partSearch;
            }
            if (!found)
            {
                MessageBox.Show("No matching entries found.");
                mainPartsDGV.DataSource = Inventory.AllParts;
            }

        }
        // Select part
        private void mainPartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PartsIndex = mainPartsDGV.CurrentCell.RowIndex;
            PartsObj = Inventory.AllParts[PartsIndex];

        }
        // Add part button
        private void mainPartsAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPart Part1 = new ModifyPart(Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1, 0);
            Part1.Show();
        }
        // Modify part button
        private void mainPartsModifyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPart Part1 = new ModifyPart(PartsIndex, 1);
            Part1.Show();
        }

        // Delete part button
        private void mainPartsDeleteButton_Click(object sender, EventArgs e)
        {
            PartsIndex = mainPartsDGV.CurrentCell.RowIndex;
            PartsObj = Inventory.AllParts[PartsIndex];
            bool associated = false;
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                foreach (Part element in Inventory.Products[i].AssociatedParts)
                {
                    if (element == PartsObj)
                    {
                        associated = true;
                    }
                }
            }
            if (associated == true)
            {
                MessageBox.Show("This part is associated with at least one product and cannot be deleted.");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show($"{Inventory.AllParts[PartsIndex].Name}", "Are you sure you want to delete this part?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.AllParts.RemoveAt(PartsIndex);
                    MessageBox.Show("The part has been deleted.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
        }


        // Functions for the Products section.

        private void mainProdSearchButton_Click(object sender, EventArgs e)
        {
            List<Product> productSearch = new List<Product>();
            bool found = false;
            if (mainProdSearchText.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(mainProdSearchText.Text.ToUpper()))
                    {
                        productSearch.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                    mainProdDGV.DataSource = productSearch;
            }
            if (!found)
            {
                MessageBox.Show("No matching entries found.");
                mainProdDGV.DataSource = Inventory.Products;
            }

        }

        private void mainProdDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIndex = mainProdDGV.CurrentCell.RowIndex;
            ProdObj = Inventory.Products[ProdIndex];
        }
        // Modify Product button
        private void mainProductsModifyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyProduct Prod1 = new ModifyProduct(ProdIndex, 1);
            Prod1.Show();
        }
        // Add Product button
        private void mainProductsAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyProduct Prod1 = new ModifyProduct(Inventory.Products[Inventory.Products.Count - 1].ProductID + 1, 0);
            Prod1.Show();
        }
        // Delete Product button
        private void mainProductsDeleteButton_Click(object sender, EventArgs e)
        {
            ProdIndex = mainProdDGV.CurrentCell.RowIndex;
            ProdObj = Inventory.Products[ProdIndex];
            if (ProdObj.AssociatedParts.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show($"{Inventory.Products[ProdIndex].Name}", "Are you sure you want to delete this part?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.Products.RemoveAt(ProdIndex);
                    MessageBox.Show("The product has been deleted.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("Cannot delete a product with associated parts.");
            }
        }
    }
}
