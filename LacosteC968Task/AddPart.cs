// AddPart.cs
// Defines the AddPart form

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
    public partial class AddPart : Form
    {

        // Check variables for final save validity

        bool NameCheck = false;
        bool InvCheck = false;
        bool PriceCheck = false;
        bool MaxCheck = false;
        bool MinCheck = false;
        bool CompanyCheck = false;
        bool MIDCheck = false;

        // AddPart form
        public AddPart()
        {
            InitializeComponent();
        }

        // Cancel button
        private void AddPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainScreen Main1 = new MainScreen();
            Main1.Show();
        }
        // Radio button (Outsourced), hides MachineID controls, shows CompanyName controls
        private void PartOutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            AddPartMachineIDLabel.Hide();
            AddPartMachineIDText.Hide();
            AddPartCompanyLabel.Show();
            AddPartCompanyText.Show();
        }
        // Radio button (InHouse), hides CompanyName controls, shows MachineID controls
        private void PartInHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            AddPartCompanyLabel.Hide();
            AddPartCompanyText.Hide();
            AddPartMachineIDLabel.Show();
            AddPartMachineIDText.Show();
        }
        // Individual Validation and Textbox Background Color Changes

        // Name field
        private void AddPartNameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddPartNameText.Text))
            {
                AddPartNameText.BackColor = Color.LightCoral;
                NameCheck = false;
            }

            else
            {
                AddPartNameText.BackColor = Color.White;
                NameCheck = true;
            }
        }
        // Inventory field
        private void AddPartInventoryText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddPartInventoryText.Text) || !Int32.TryParse(AddPartInventoryText.Text, out number) || number < 0)
            {
                AddPartInventoryText.BackColor = Color.LightCoral;
                InvCheck = false;
            }

            else
            {
                AddPartInventoryText.BackColor = Color.White;
                InvCheck = true;
            }

        }
        // Permits only digits, backspace key and delete key to be entered.
        private void AddPartInventoryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Price field
        private void AddPartPriceText_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if (string.IsNullOrWhiteSpace(AddPartPriceText.Text) || !decimal.TryParse(AddPartPriceText.Text, out number) || number < 0)
            {
                AddPartPriceText.BackColor = Color.LightCoral;
                PriceCheck = false;
            }
            else
            {
                AddPartPriceText.BackColor = Color.White;
                PriceCheck = true;
            }
        }
        // Permits only digits, backspace key, delete key and period (for decimal value).
        private void AddPartPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 190)
            {
                e.Handled = true;
            }
        }
        // Max field
        private void AddPartMaxText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddPartMaxText.Text) || !Int32.TryParse(AddPartMaxText.Text, out number) || number < 0)
            {
                AddPartMaxText.BackColor = Color.LightCoral;
                MaxCheck = false;
            }

            else
            {
                AddPartMaxText.BackColor = Color.White;
                MaxCheck = true;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void AddPartMaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Min field
        private void AddPartMinText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddPartMinText.Text) || !Int32.TryParse(AddPartMinText.Text, out number) || number < 0)
            {
                AddPartMinText.BackColor = Color.LightCoral;
                MinCheck = false;
            }

            else
            {
                AddPartMinText.BackColor = Color.White;
                MinCheck = true;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void AddPartMinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        // MachineID field
        private void AddPartMachineIDText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddPartMachineIDText.Text) || !Int32.TryParse(AddPartMachineIDText.Text, out number) || number < 0)
            {
                AddPartMachineIDText.BackColor = Color.LightCoral;
                MIDCheck = false;
            }

            else
            {
                AddPartMachineIDText.BackColor = Color.White;
                MIDCheck = true;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void AddPartMachineIDText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        // Company Name field
        private void AddPartCompanyText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddPartCompanyText.Text))
            {
                AddPartCompanyText.BackColor = Color.LightCoral;
                CompanyCheck = false;
            }

            else
            {
                AddPartCompanyText.BackColor = Color.White;
                CompanyCheck = true;
            }
        }
        // Save button that includes final argument validation prior to submission.
        private void AddPartSaveButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inven = 0;
            try
            {
                min = Int32.Parse(AddPartMinText.Text);
            }
            catch 
            {
                MessageBox.Show("You must enter a valid Min value.");
            }
            try
            {
                max = Int32.Parse(AddPartMaxText.Text);
            }
            catch 
            {
                MessageBox.Show("You must enter a valid Max value.");
            }
            try
            {
                inven = Int32.Parse(AddPartInventoryText.Text);
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
            else if (MaxCheck == false || !Int32.TryParse(AddPartMaxText.Text, out max))
            {
                MessageBox.Show("You must enter a valid Max value.");
                return;
            }
            else if (MinCheck == false || !Int32.TryParse(AddPartMinText.Text, out min))
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
            else if (CompanyCheck == false && PartOutsourcedButton.Checked == true)
            {
                MessageBox.Show("If outsourced, please enter a valid Company Name.");
                return;
            }
            else if (MIDCheck == false && PartInHouseButton.Checked == true)
            {
                MessageBox.Show("If in-house, please enter a valid machine ID.");
                return;
            }
            else if (PartOutsourcedButton.Checked == true) // Attempts to add an OutsourcedPart object to Parts list.
            {
                try
                {
                    Inventory.AllParts.Add(new OutsourcedPart(Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1,
                        $"{AddPartNameText.Text}", decimal.Parse(AddPartPriceText.Text), inven, min, max, $"{AddPartCompanyText.Text}"));
                    MessageBox.Show("The part was added successfully.");
                    this.Close();
                    MainScreen Main1 = new MainScreen();
                    Main1.Show();
                    return;
                }
                catch
                {
                    MessageBox.Show("An error occured while trying to add the Part.");
                    return;
                }
            }
            else if (PartInHouseButton.Checked == true) // Attempts to add an InHousePart object to Parts list.
            {
                try
                {
                    Inventory.AllParts.Add(new InHousePart(Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1,
                        $"{AddPartNameText.Text}", decimal.Parse(AddPartPriceText.Text), inven, min, max, Int32.Parse(AddPartMachineIDText.Text)));
                    MessageBox.Show("The part was added successfully.");
                    this.Close();
                    MainScreen Main1 = new MainScreen();
                    Main1.Show();
                    return;
                }
                catch
                {
                    MessageBox.Show("An error occured while trying to add the Part.");
                    return;
                }
            }

        }
    }
}
