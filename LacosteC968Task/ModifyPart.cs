// ModifyPart.cs
// Defines the ModifyPart form.

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
    public partial class ModifyPart : Form
    {
        Part newPart;
        int PIndex;
        int existing;
        public ModifyPart(int PartIndex, int exists)
        {
            existing = exists;
            PIndex = PartIndex;
            if (exists == 0)
            {
                InitializeComponent();
                ModifyPartLabel.Text = "Add Part";
                ModifyPartIDText.Text = $"{PartIndex}";
            }
            else if (exists == 1)
            {
                InitializeComponent();
                newPart = Inventory.AllParts[PartIndex];
                ModifyPartIDText.Text = $"{newPart.PartID}";
                ModifyPartNameText.Text = $"{newPart.Name}";
                ModifyPartInventoryText.Text = $"{newPart.InStock}";
                ModifyPartPriceText.Text = $"{newPart.Price}";
                ModifyPartMinText.Text = $"{newPart.Min}";
                ModifyPartMaxText.Text = $"{newPart.Max}";
                if (newPart is OutsourcedPart)
                {
                    OutsourcedPart holder = (OutsourcedPart)newPart;
                    ModifyPartCompanyText.Text = holder.CompanyName;
                    PartOutsourcedButton.Checked = true;
                }
                else if (newPart is InHousePart)
                {
                    InHousePart holder = (InHousePart)newPart;
                    ModifyPartMachineIDText.Text = $"{holder.MachineID}";
                    PartInHouseButton.Checked = true;
                }
            }

        }
        // Cancel button
        private void ModifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainScreen Main1 = new MainScreen();
            Main1.Show();
        }
        // Radio button (Outsourced), hides MachineID controls, shows CompanyName controls
        private void PartOutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            ModifyPartMachineIDLabel.Hide();
            ModifyPartMachineIDText.Hide();
            ModifyPartCompanyLabel.Show();
            ModifyPartCompanyText.Show();
        }

        // Radio button (InHouse), hides CompanyName controls, shows MachineID controls
        private void PartInHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            ModifyPartCompanyLabel.Hide();
            ModifyPartCompanyText.Hide();
            ModifyPartMachineIDLabel.Show();
            ModifyPartMachineIDText.Show();
        }

        // Individual Validation and Textbox Background Color Changes

        // Name field validation

        private void ModifyPartNameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModifyPartNameText.Text))
            {
                ModifyPartNameText.BackColor = Color.LightCoral;
            }
            else
            {
                ModifyPartNameText.BackColor = Color.White;
            }
        }
        // Inventory field validation
        private void ModifyPartInventoryText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyPartInventoryText.Text) || !Int32.TryParse(ModifyPartInventoryText.Text, out number) || number < 0)
            {
                ModifyPartInventoryText.BackColor = Color.LightCoral;
            }
            else
            {
                ModifyPartInventoryText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void ModifyPartInventoryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        // Price field validation
        private void ModifyPartPriceText_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if (string.IsNullOrWhiteSpace(ModifyPartPriceText.Text) || !decimal.TryParse(ModifyPartPriceText.Text, out number) || number < 0)
            {
                ModifyPartPriceText.BackColor = Color.LightCoral;
            }
            else
            {
                ModifyPartPriceText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key, delete key and period (for decimal value).
        private void ModifyPartPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 190)
            {
                e.Handled = true;
            }
        }
        // Max field validation
        private void ModifyPartMaxText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyPartMaxText.Text) || !Int32.TryParse(ModifyPartMaxText.Text, out number) || number < 0)
            {
                ModifyPartMaxText.BackColor = Color.LightCoral;
            }

            else
            {
                ModifyPartMaxText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void ModifyPartMaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Min field validation
        private void ModifyPartMinText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyPartMinText.Text) || !Int32.TryParse(ModifyPartMinText.Text, out number) || number < 0)
            {
                ModifyPartMinText.BackColor = Color.LightCoral;
            }

            else
            {
                ModifyPartMinText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void ModifyPartMinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        // Machine ID field
        private void ModifyPartMachineIDText_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyPartMachineIDText.Text) || !Int32.TryParse(ModifyPartMachineIDText.Text, out number) || number < 0)
            {
                ModifyPartMachineIDText.BackColor = Color.LightCoral;
            }

            else
            {
                ModifyPartMachineIDText.BackColor = Color.White;
            }
        }
        // Permits only digits, backspace key and delete key to be entered.
        private void ModifyPartMachineIDText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        // Company Name field
        private void ModifyPartCompanyText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModifyPartCompanyText.Text))
            {
                ModifyPartCompanyText.BackColor = Color.LightCoral;
            }

            else
            {
                ModifyPartCompanyText.BackColor = Color.White;
            }
        }
        // Save button that includes final argument validation prior to submission.
        private void ModifyPartSaveButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inven;
            decimal price;
            if (ModifyPartNameText.Text == "")
            {
                MessageBox.Show("Part name cannot be blank.");
                return;
            }
            try
            {
                price = decimal.Parse(ModifyPartPriceText.Text);
            }
            catch
            {
                MessageBox.Show("You must enter a valid price.");
                return;
            }
            try
            {
                min = Int32.Parse(ModifyPartMinText.Text);
            }
            catch
            {
                MessageBox.Show("You must enter a valid Min value.");
                return;
            }
            try
            {
                max = Int32.Parse(ModifyPartMaxText.Text);
            }
            catch
            {
                MessageBox.Show("You must enter a valid Max value.");
                return;
            }
            try
            {
                inven = Int32.Parse(ModifyPartInventoryText.Text);
            }
            catch
            {
                MessageBox.Show("You must enter a valid Inventory value.");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("Minimum cannot be greater than maximum.");
                return;
            }
            else if (inven > max || inven < min)
            {
                MessageBox.Show("Inventory cannot be greater than maximum or less than minimum.");
                return;
            }
            else if (PartOutsourcedButton.Checked == true && ModifyPartCompanyText.Text == "")
            {
                MessageBox.Show("If product is outsourced, please enter the company name.");
                return;
            }
            else if (PartInHouseButton.Checked == true && ModifyPartMachineIDText.Text == "")
            {
                MessageBox.Show("If product is in-house, please enter the machine id.");
                return;
            }
            else if (existing == 0 && PartOutsourcedButton.Checked == true)
            {
                Inventory.addPart(new OutsourcedPart(PIndex, ModifyPartNameText.Text, decimal.Parse(ModifyPartPriceText.Text), inven, min, max, ModifyPartCompanyText.Text));
                MessageBox.Show("The part was added successfully.");
                this.Close();
                MainScreen Main1 = new MainScreen();
                Main1.Show();
                return;
            }
            else if (existing == 0 && PartInHouseButton.Checked == true)
            {
                Inventory.addPart(new InHousePart(PIndex, ModifyPartNameText.Text, decimal.Parse(ModifyPartPriceText.Text), inven, min, max, Int32.Parse(ModifyPartMachineIDText.Text)));
                MessageBox.Show("The part was added successfully.");
                this.Close();
                MainScreen Main1 = new MainScreen();
                Main1.Show();
                return;
            }
            else if (existing == 1 && PartOutsourcedButton.Checked == true)
            {
                Inventory.updatePart(PIndex, new OutsourcedPart(PIndex, ModifyPartNameText.Text, decimal.Parse(ModifyPartPriceText.Text), inven, min, max, ModifyPartCompanyText.Text));
                try
                {
                    for (int i = 0; i < Inventory.Products.Count; i++)
                    {
                        for (int j = 0; j < Inventory.Products[i].AssociatedParts.Count; j++)
                        {
                            if (Inventory.Products[i].AssociatedParts[j].PartID == Int32.Parse(ModifyPartIDText.Text))
                            {
                                Inventory.Products[i].AssociatedParts[j] = new OutsourcedPart(PIndex, ModifyPartNameText.Text, decimal.Parse(ModifyPartPriceText.Text), inven, min, max, ModifyPartCompanyText.Text);
                            }
                        }
                    }
                    Inventory.AllParts[PIndex] = new OutsourcedPart(PIndex, ModifyPartNameText.Text, decimal.Parse(ModifyPartPriceText.Text), inven, min, max, ModifyPartCompanyText.Text);
                    MessageBox.Show("The part was modified successfully.");
                    this.Close();
                    MainScreen Main1 = new MainScreen();
                    Main1.Show();
                    return;
                }
                catch
                {
                    MessageBox.Show("An error occured while trying to modify the Part.");
                    return;
                }
            }
            else if (existing == 1 && PartInHouseButton.Checked == true)
            {
                Inventory.updatePart(PIndex, new InHousePart(PIndex, ModifyPartNameText.Text, decimal.Parse(ModifyPartPriceText.Text), inven, min, max, Int32.Parse(ModifyPartMachineIDText.Text)));
                try
                {
                    for (int i = 0; i < Inventory.Products.Count; i++)
                    {
                        for (int j = 0; j < Inventory.Products[i].AssociatedParts.Count; j++)
                        {
                            if (Inventory.Products[i].AssociatedParts[j].PartID == Int32.Parse(ModifyPartIDText.Text))
                            {
                                Inventory.Products[i].AssociatedParts[j] = new InHousePart(PIndex, ModifyPartNameText.Text, decimal.Parse(ModifyPartPriceText.Text), inven, min, max, Int32.Parse(ModifyPartMachineIDText.Text));
                            }
                        }
                    }
                    Inventory.AllParts[PIndex] = new InHousePart(PIndex, ModifyPartNameText.Text, decimal.Parse(ModifyPartPriceText.Text), inven, min, max, Int32.Parse(ModifyPartMachineIDText.Text));
                    MessageBox.Show("The part was modified successfully.");
                    this.Close();
                    MainScreen Main1 = new MainScreen();
                    Main1.Show();
                    return;
                }
                catch
                {
                    MessageBox.Show("An error occured while trying to modify the Part.");
                    return;
                }
            }
            
        }
    }
}
