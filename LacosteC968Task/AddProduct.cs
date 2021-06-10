// AddProduct.cs
// Defines the AddProduct form

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
    public partial class AddProduct : Form
    {
        // Check variables for final save validation
        bool NameCheck = false;
        bool InvCheck = false;
        bool PriceCheck = false;
        bool MaxCheck = false;
        bool MinCheck = false;
        int PartsIndex;
        Part PartsObj;
        int DelIndex;
        Part DelObj;
        BindingList<Part> tempAssoc = new BindingList<Part>();
        BindingList<Part> allParts = Inventory.AllParts;
        BindingList<Part> partSearch = new BindingList<Part>();

        // AddProduct form, provides datasource for datagridviews.
        public AddProduct()
        {
            InitializeComponent();
            AddProdAllPartsDGV.DataSource = allParts;
            AddProdAssocPartsDGV.DataSource = tempAssoc;
        }

        // Cancel button
        private void AddProdCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainScreen Main1 = new MainScreen();
            Main1.Show();
        }

        // Individual Validation and Textbox Background Color Changes
        private void AddProdNameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddProdNameText.Text))
            {
                AddProdNameText.BackColor = Color.LightCoral;
                NameCheck = false;
            }

            else
            {
                AddProdNameText.BackColor = Color.White;
                NameCheck = true;
            }
        }

        private void AddProdInventoryText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddProdInventoryText.Text) || !Int32.TryParse(AddProdInventoryText.Text, out number) || number < 0)
            {
                AddProdInventoryText.BackColor = Color.LightCoral;
                InvCheck = false;
            }

            else
            {
                AddProdInventoryText.BackColor = Color.White;
                InvCheck = true;
            }
        }

        private void AddProdInventoryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void AddProdPriceText_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if (string.IsNullOrWhiteSpace(AddProdPriceText.Text) || !decimal.TryParse(AddProdPriceText.Text, out number) || number < 0)
            {
                AddProdPriceText.BackColor = Color.LightCoral;
                PriceCheck = false;
            }
            else
            {
                AddProdPriceText.BackColor = Color.White;
                PriceCheck = true;
            }
        }

        private void AddProdPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 190)
            {
                e.Handled = true;
            }
        }

        private void AddProdMaxText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddProdMaxText.Text) || !Int32.TryParse(AddProdMaxText.Text, out number) || number < 0)
            {
                AddProdMaxText.BackColor = Color.LightCoral;
                MaxCheck = false;
            }

            else
            {
                AddProdMaxText.BackColor = Color.White;
                MaxCheck = true;
            }
        }

        private void AddProdMaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void AddProdMinText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddProdMinText.Text) || !Int32.TryParse(AddProdMinText.Text, out number) || number < 0)
            {
                AddProdMinText.BackColor = Color.LightCoral;
                MinCheck = false;
            }

            else
            {
                AddProdMinText.BackColor = Color.White;
                MinCheck = true;
            }
        }

        private void AddProdMinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Parts selection
        private void AddProdAllPartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AddProdAllPartsDGV.DataSource == allParts)
            {
                PartsIndex = (int)AddProdAllPartsDGV[0, AddProdAllPartsDGV.CurrentCell.RowIndex].Value;
                for (int i = 0; i < allParts.Count; i++)
                {
                    if (allParts[i].PartID == PartsIndex)
                    {
                        PartsObj = allParts[i];
                        AddProdAddPartButton.Enabled = true;
                    }
                }
                
            }
            else if (AddProdAllPartsDGV.DataSource == partSearch)
            {
                PartsIndex = (int)AddProdAllPartsDGV[0, AddProdAllPartsDGV.CurrentCell.RowIndex].Value;
                for (int i = 0; i < partSearch.Count; i++)
                {
                    if (partSearch[i].PartID == PartsIndex)
                    {
                        PartsObj = partSearch[i];
                        AddProdAddPartButton.Enabled = true;
                    }
                }
                
            }
        }
        private void AddProdAddPartButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (tempAssoc.Count > 0)
            {
                for (int i = 0; i < tempAssoc.Count; i++)
                {
                    if (tempAssoc[i].PartID == PartsIndex)
                    {
                        found = true;
                    }
                }
                if (found == true)
                {
                    MessageBox.Show("This part is already associated with this product.");
                }
                else
                {
                    tempAssoc.Add(PartsObj);
                }

            }
            else
            {
                tempAssoc.Add(PartsObj);
            }

        }



        private void AddProdAssocPartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DelIndex = AddProdAssocPartsDGV.CurrentCell.RowIndex;
            DelObj = tempAssoc[DelIndex];
            AddProdDeletePartButton.Enabled = true;
        }

        private void AddProdDeletePartButton_Click(object sender, EventArgs e)
        {
            if (tempAssoc.Contains(DelObj))
            {
                tempAssoc.Remove(DelObj);
                AddProdDeletePartButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("No parts associated with this product.");
            }
        }
        // Save button that includes final argument validation prior to submission.
        private void AddProdSaveButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inven = 0;
            try
            {
                min = Int32.Parse(AddProdMinText.Text);
            }
            catch
            {
                MessageBox.Show("You must enter a valid Min value.");
            }
            try
            {
                max = Int32.Parse(AddProdMaxText.Text);
            }
            catch
            {
                MessageBox.Show("You must enter a valid Max value.");
            }
            try
            {
                inven = Int32.Parse(AddProdInventoryText.Text);
            }
            catch
            {
                MessageBox.Show("You must enter a valid Inventory value.");
            }
            if (NameCheck == false)
            {
                MessageBox.Show("You must enter a valid Part Name.");
                return;
            }
            else if (InvCheck == false)
            {
                MessageBox.Show("You must enter a valid Inventory value.");
                return;
            }
            else if (PriceCheck == false)
            {
                MessageBox.Show("You must enter a valid Price value.");
                return;
            }
            else if (MaxCheck == false || !Int32.TryParse(AddProdMaxText.Text, out max))
            {
                MessageBox.Show("You must enter a valid Max value.");
                return;
            }
            else if (MinCheck == false || !Int32.TryParse(AddProdMinText.Text, out min))
            {
                MessageBox.Show("You must enter a valid Min value.");
                return;
            }
            else if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
            }
            else if (inven < min || inven > max)
            {
                MessageBox.Show("Inventory value cannot be less than Min or greater than Max.");
            }
            else
            {
                Inventory.Products.Add(new Product(Inventory.Products[Inventory.Products.Count - 1].ProductID + 1, AddProdNameText.Text, decimal.Parse(AddProdPriceText.Text), inven, min, max, tempAssoc));
                MessageBox.Show("The product was added successfully.");
                this.Close();
                MainScreen Main1 = new MainScreen();
                Main1.Show();
                return;
            }
        }
        // Search feature to locate parts to associate with products.
        private void AddProdSearchButton_Click(object sender, EventArgs e)
        {
            partSearch = new BindingList<Part>();
            bool found = false;
            if (AddProdSearchText.Text != "")
            {
                for (int i = 0; i < allParts.Count; i++)
                {
                    if (allParts[i].Name.ToUpper().Contains(AddProdSearchText.Text.ToUpper()))
                    {
                        partSearch.Add(allParts[i]);
                        found = true;
                    }
                }
                if (found)
                    AddProdAllPartsDGV.DataSource = partSearch;
            }
            if (!found)
            {
                MessageBox.Show("No matching entries found.");
                AddProdAllPartsDGV.DataSource = allParts;
            }
        }
    }
}
