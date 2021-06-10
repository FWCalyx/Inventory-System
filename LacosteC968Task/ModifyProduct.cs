// ModifyProduct.cs
// Defines The Add/ModifyProduct form.

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
    public partial class ModifyProduct : Form
    {
        BindingList<Part> partSearch = new BindingList<Part>();
        BindingList<Part> tempList = new BindingList<Part>();
        int PIndex;
        int tarAddID;
        int tarDelID;
        int existing;
        Product modProd;
        public ModifyProduct(int ProdIndex, int exists)
        {
            existing = exists;
            PIndex = ProdIndex;

            if (existing == 0)
            {
                InitializeComponent();
                modProd = new Product(ProdIndex, "", 0, 0, 0, 0, tempList);
                ModifyProductLabel.Text = "Add Product";
                ModifyProdIDText.Text = $"{ProdIndex}";
                modProd.ProductID = ProdIndex;
            }
            else
            {
                InitializeComponent();
                modProd = Inventory.Products[ProdIndex];
                ModifyProdIDText.Text = $"{modProd.ProductID}";
                ModifyProdNameText.Text = $"{modProd.Name}";
                ModifyProdInventoryText.Text = $"{modProd.InStock}";
                ModifyProdPriceText.Text = $"{modProd.Price}";
                ModifyProdMaxText.Text = $"{modProd.Max}";
                ModifyProdMinText.Text = $"{modProd.Min}";
            }
            ModifyProdAllPartsDGV.DataSource = Inventory.AllParts;
            ModifyProdAssocPartsDGV.DataSource = modProd.AssociatedParts;
        }
        // Cancel Button
        private void ModifyProdCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainScreen Main1 = new MainScreen();
            Main1.Show();
        }

        // Individual Validation and Textbox Background Color Changes

        // Name field validation
        private void ModifyProdNameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModifyProdNameText.Text))
            {
                ModifyProdNameText.BackColor = Color.LightCoral;
            }
            else
            {
                ModifyProdNameText.BackColor = Color.White;
            }
        }

        // Inventory field validation
        private void ModifyProdInventoryText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyProdInventoryText.Text) || !Int32.TryParse(ModifyProdInventoryText.Text, out number) || number < 0)
            {
                ModifyProdInventoryText.BackColor = Color.LightCoral;
            }
            else
            {
                ModifyProdInventoryText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void ModifyProdInventoryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Price field validation
        private void ModifyProdPriceText_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if (string.IsNullOrWhiteSpace(ModifyProdPriceText.Text) || !decimal.TryParse(ModifyProdPriceText.Text, out number) || number < 0)
            {
                ModifyProdPriceText.BackColor = Color.LightCoral;
            }
            else
            {
                ModifyProdPriceText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key, delete key and period (for decimal value).
        private void ModifyProdPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 190)
            {
                e.Handled = true;
            }
        }

        // Max field validation
        private void ModifyProdMaxText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyProdMaxText.Text) || !Int32.TryParse(ModifyProdMaxText.Text, out number) || number < 0)
            {
                ModifyProdMaxText.BackColor = Color.LightCoral;
            }
            else
            {
                ModifyProdMaxText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void ModifyProdMaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Min field validation
        private void ModifyProdMinText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyProdMinText.Text) || !Int32.TryParse(ModifyProdMinText.Text, out number) || number < 0)
            {
                ModifyProdMinText.BackColor = Color.LightCoral;
            }

            else
            {
                ModifyProdMinText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void ModifyProdMinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Parts selection

        // Searches for parts to associate with product.
        private void ModifyProdSearchButton_Click(object sender, EventArgs e)
        {
            partSearch = new BindingList<Part>();
            bool found = false;
            if (ModifyProdSearchText.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(ModifyProdSearchText.Text.ToUpper()))
                    {
                        partSearch.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    ModifyProdAllPartsDGV.DataSource = partSearch;
            }
            if (!found)
            {
                MessageBox.Show("No matching entries found.");
                ModifyProdAllPartsDGV.DataSource = Inventory.AllParts;
            }
        }
        private void ModifyProdAllPartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tarAddID = (int)ModifyProdAllPartsDGV[0, ModifyProdAllPartsDGV.CurrentCell.RowIndex].Value;
            ModifyProdAddPartButton.Enabled = true;
        }

        // Parts Adding to Temporary Holding List

        private void ModifyProdAddPartButton_Click(object sender, EventArgs e)
        {
            foreach (Part element in Inventory.AllParts)
            {
                if (element.PartID == tarAddID)
                {
                    if (modProd.AssociatedParts.Contains(element))
                    {
                        MessageBox.Show("Part already associated with this product.");
                    }
                    else
                    {
                        modProd.addAssociatedPart(element);
                    }
                }
            }
        }

        // Selects an associated part for deletion.
        private void ModifyProdAssocPartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tarDelID = (int)ModifyProdAssocPartsDGV[0, ModifyProdAssocPartsDGV.CurrentCell.RowIndex].Value;
            ModifyProdDeletePartButton.Enabled = true;
        }

        // Deletes selected associated part from product.
        private void ModifyProdDeletePartButton_Click(object sender, EventArgs e)
        {
            modProd.removeAssociatedPart(tarDelID);
        }
        // Save button that includes final argument validation prior to submission.
        private void ModifyProdSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ModifyProdNameText.Text == "")
                {
                    MessageBox.Show("Name field cannot be blank.");
                    return;
                }
                else
                {
                    modProd.Name = ModifyProdNameText.Text;
                }
            }
            catch
            {
                MessageBox.Show("Error - look at the Product Name try/catch section.");
                return;
            }
            try
            {
                if (ModifyProdInventoryText.Text != "")
                {
                    modProd.InStock = Int32.Parse(ModifyProdInventoryText.Text);
                }
                else
                {
                    MessageBox.Show("Inventory field cannot be blank.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid inventory amount.");
                return;
            }

            try
            {
                if (ModifyProdPriceText.Text != "")
                {
                    modProd.Price = decimal.Parse(ModifyProdPriceText.Text);
                }
                else
                {
                    MessageBox.Show("Price field cannot be blank.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }
            try
            {
                if (ModifyProdMaxText.Text != "")
                {
                    modProd.Max = Int32.Parse(ModifyProdMaxText.Text);
                }
                else
                {
                    MessageBox.Show("Max field cannot be blank.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid maximum value.");
                return;
            }
            try
            {
                if (ModifyProdMinText.Text != "")
                {
                    modProd.Min = Int32.Parse(ModifyProdMinText.Text);
                }
                else
                {
                    MessageBox.Show("Min field cannot be blank.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid minimum value.");
                return;
            }
            try
            {
                if (modProd.Min > modProd.Max)
                {
                    MessageBox.Show("Minimum value cannot be greater than maximum value.");
                    return;
                }
                else if (modProd.InStock < modProd.Min || modProd.InStock > modProd.Max)
                {
                    MessageBox.Show("Inventory cannot be greater than maximum or less than minimum.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please check the Min, Max and Inventory fields.");
                return;
            }
            try
            {
                if (existing == 0)
                {
                    Inventory.addProduct(modProd);
                    MessageBox.Show("Product was successfully added.");
                    this.Close();
                    MainScreen Main1 = new MainScreen();
                    Main1.Show();
                }
                else if (existing == 1)
                {
                    Inventory.updateProduct(PIndex, modProd);
                    MessageBox.Show("Product was successfully updated.");
                    this.Close();
                    MainScreen Main1 = new MainScreen();
                    Main1.Show();
                }
            }
            catch
            {
                MessageBox.Show("Product could not be updated.");
                return;
            }
        }

       
    }
}
