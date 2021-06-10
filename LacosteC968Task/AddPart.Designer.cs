
namespace LacosteC968Task
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.PartSource = new System.Windows.Forms.GroupBox();
            this.PartOutsourcedButton = new System.Windows.Forms.RadioButton();
            this.PartInHouseButton = new System.Windows.Forms.RadioButton();
            this.AddPartCancelButton = new System.Windows.Forms.Button();
            this.AddPartSaveButton = new System.Windows.Forms.Button();
            this.AddPartIDLabel = new System.Windows.Forms.Label();
            this.AddPartNameLabel = new System.Windows.Forms.Label();
            this.AddPartInventoryLabel = new System.Windows.Forms.Label();
            this.AddPartPriceLabel = new System.Windows.Forms.Label();
            this.AddPartMinLabel = new System.Windows.Forms.Label();
            this.AddPartMaxLabel = new System.Windows.Forms.Label();
            this.AddPartMachineIDLabel = new System.Windows.Forms.Label();
            this.AddPartCompanyLabel = new System.Windows.Forms.Label();
            this.AddPartIDText = new System.Windows.Forms.TextBox();
            this.AddPartNameText = new System.Windows.Forms.TextBox();
            this.AddPartInventoryText = new System.Windows.Forms.TextBox();
            this.AddPartPriceText = new System.Windows.Forms.TextBox();
            this.AddPartMaxText = new System.Windows.Forms.TextBox();
            this.AddPartCompanyText = new System.Windows.Forms.TextBox();
            this.AddPartMachineIDText = new System.Windows.Forms.TextBox();
            this.AddPartMinText = new System.Windows.Forms.TextBox();
            this.PartSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartLabel.Location = new System.Drawing.Point(8, 8);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(84, 22);
            this.AddPartLabel.TabIndex = 0;
            this.AddPartLabel.Text = "Add Part";
            // 
            // PartSource
            // 
            this.PartSource.Controls.Add(this.PartOutsourcedButton);
            this.PartSource.Controls.Add(this.PartInHouseButton);
            this.PartSource.Location = new System.Drawing.Point(160, 0);
            this.PartSource.Name = "PartSource";
            this.PartSource.Size = new System.Drawing.Size(240, 48);
            this.PartSource.TabIndex = 1;
            this.PartSource.TabStop = false;
            // 
            // PartOutsourcedButton
            // 
            this.PartOutsourcedButton.AutoSize = true;
            this.PartOutsourcedButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartOutsourcedButton.Location = new System.Drawing.Point(120, 16);
            this.PartOutsourcedButton.Name = "PartOutsourcedButton";
            this.PartOutsourcedButton.Size = new System.Drawing.Size(106, 22);
            this.PartOutsourcedButton.TabIndex = 1;
            this.PartOutsourcedButton.Text = "Outsourced";
            this.PartOutsourcedButton.UseVisualStyleBackColor = true;
            this.PartOutsourcedButton.CheckedChanged += new System.EventHandler(this.PartOutsourcedButton_CheckedChanged);
            // 
            // PartInHouseButton
            // 
            this.PartInHouseButton.AutoSize = true;
            this.PartInHouseButton.Checked = true;
            this.PartInHouseButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartInHouseButton.Location = new System.Drawing.Point(16, 16);
            this.PartInHouseButton.Name = "PartInHouseButton";
            this.PartInHouseButton.Size = new System.Drawing.Size(87, 22);
            this.PartInHouseButton.TabIndex = 0;
            this.PartInHouseButton.TabStop = true;
            this.PartInHouseButton.Text = "In-House";
            this.PartInHouseButton.UseVisualStyleBackColor = true;
            this.PartInHouseButton.CheckedChanged += new System.EventHandler(this.PartInHouseButton_CheckedChanged);
            // 
            // AddPartCancelButton
            // 
            this.AddPartCancelButton.Location = new System.Drawing.Point(552, 392);
            this.AddPartCancelButton.Name = "AddPartCancelButton";
            this.AddPartCancelButton.Size = new System.Drawing.Size(55, 35);
            this.AddPartCancelButton.TabIndex = 11;
            this.AddPartCancelButton.Text = "Cancel";
            this.AddPartCancelButton.UseVisualStyleBackColor = true;
            this.AddPartCancelButton.Click += new System.EventHandler(this.AddPartCancelButton_Click);
            // 
            // AddPartSaveButton
            // 
            this.AddPartSaveButton.Location = new System.Drawing.Point(472, 392);
            this.AddPartSaveButton.Name = "AddPartSaveButton";
            this.AddPartSaveButton.Size = new System.Drawing.Size(55, 35);
            this.AddPartSaveButton.TabIndex = 10;
            this.AddPartSaveButton.Text = "Save";
            this.AddPartSaveButton.UseVisualStyleBackColor = true;
            this.AddPartSaveButton.Click += new System.EventHandler(this.AddPartSaveButton_Click);
            // 
            // AddPartIDLabel
            // 
            this.AddPartIDLabel.AutoSize = true;
            this.AddPartIDLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartIDLabel.Location = new System.Drawing.Point(128, 79);
            this.AddPartIDLabel.Name = "AddPartIDLabel";
            this.AddPartIDLabel.Size = new System.Drawing.Size(30, 22);
            this.AddPartIDLabel.TabIndex = 4;
            this.AddPartIDLabel.Text = "ID";
            // 
            // AddPartNameLabel
            // 
            this.AddPartNameLabel.AutoSize = true;
            this.AddPartNameLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartNameLabel.Location = new System.Drawing.Point(98, 124);
            this.AddPartNameLabel.Name = "AddPartNameLabel";
            this.AddPartNameLabel.Size = new System.Drawing.Size(60, 22);
            this.AddPartNameLabel.TabIndex = 5;
            this.AddPartNameLabel.Text = "Name";
            // 
            // AddPartInventoryLabel
            // 
            this.AddPartInventoryLabel.AutoSize = true;
            this.AddPartInventoryLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartInventoryLabel.Location = new System.Drawing.Point(71, 169);
            this.AddPartInventoryLabel.Name = "AddPartInventoryLabel";
            this.AddPartInventoryLabel.Size = new System.Drawing.Size(87, 22);
            this.AddPartInventoryLabel.TabIndex = 6;
            this.AddPartInventoryLabel.Text = "Inventory";
            // 
            // AddPartPriceLabel
            // 
            this.AddPartPriceLabel.AutoSize = true;
            this.AddPartPriceLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartPriceLabel.Location = new System.Drawing.Point(49, 214);
            this.AddPartPriceLabel.Name = "AddPartPriceLabel";
            this.AddPartPriceLabel.Size = new System.Drawing.Size(109, 22);
            this.AddPartPriceLabel.TabIndex = 7;
            this.AddPartPriceLabel.Text = "Price / Cost";
            // 
            // AddPartMinLabel
            // 
            this.AddPartMinLabel.AutoSize = true;
            this.AddPartMinLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartMinLabel.Location = new System.Drawing.Point(296, 259);
            this.AddPartMinLabel.Name = "AddPartMinLabel";
            this.AddPartMinLabel.Size = new System.Drawing.Size(39, 22);
            this.AddPartMinLabel.TabIndex = 8;
            this.AddPartMinLabel.Text = "Min";
            // 
            // AddPartMaxLabel
            // 
            this.AddPartMaxLabel.AutoSize = true;
            this.AddPartMaxLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartMaxLabel.Location = new System.Drawing.Point(114, 259);
            this.AddPartMaxLabel.Name = "AddPartMaxLabel";
            this.AddPartMaxLabel.Size = new System.Drawing.Size(44, 22);
            this.AddPartMaxLabel.TabIndex = 9;
            this.AddPartMaxLabel.Text = "Max";
            // 
            // AddPartMachineIDLabel
            // 
            this.AddPartMachineIDLabel.AutoSize = true;
            this.AddPartMachineIDLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartMachineIDLabel.Location = new System.Drawing.Point(53, 304);
            this.AddPartMachineIDLabel.Name = "AddPartMachineIDLabel";
            this.AddPartMachineIDLabel.Size = new System.Drawing.Size(105, 22);
            this.AddPartMachineIDLabel.TabIndex = 10;
            this.AddPartMachineIDLabel.Text = "Machine ID";
            // 
            // AddPartCompanyLabel
            // 
            this.AddPartCompanyLabel.AutoSize = true;
            this.AddPartCompanyLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartCompanyLabel.Location = new System.Drawing.Point(12, 305);
            this.AddPartCompanyLabel.Name = "AddPartCompanyLabel";
            this.AddPartCompanyLabel.Size = new System.Drawing.Size(146, 22);
            this.AddPartCompanyLabel.TabIndex = 11;
            this.AddPartCompanyLabel.Text = "Company Name";
            this.AddPartCompanyLabel.Visible = false;
            // 
            // AddPartIDText
            // 
            this.AddPartIDText.Location = new System.Drawing.Point(176, 78);
            this.AddPartIDText.Name = "AddPartIDText";
            this.AddPartIDText.ReadOnly = true;
            this.AddPartIDText.Size = new System.Drawing.Size(125, 23);
            this.AddPartIDText.TabIndex = 12;
            // 
            // AddPartNameText
            // 
            this.AddPartNameText.BackColor = System.Drawing.Color.White;
            this.AddPartNameText.Location = new System.Drawing.Point(176, 123);
            this.AddPartNameText.Name = "AddPartNameText";
            this.AddPartNameText.Size = new System.Drawing.Size(125, 23);
            this.AddPartNameText.TabIndex = 2;
            this.AddPartNameText.TextChanged += new System.EventHandler(this.AddPartNameText_TextChanged);
            // 
            // AddPartInventoryText
            // 
            this.AddPartInventoryText.BackColor = System.Drawing.Color.White;
            this.AddPartInventoryText.Location = new System.Drawing.Point(176, 168);
            this.AddPartInventoryText.Name = "AddPartInventoryText";
            this.AddPartInventoryText.Size = new System.Drawing.Size(125, 23);
            this.AddPartInventoryText.TabIndex = 3;
            this.AddPartInventoryText.TextChanged += new System.EventHandler(this.AddPartInventoryText_TextChanged);
            this.AddPartInventoryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartInventoryText_KeyPress);
            // 
            // AddPartPriceText
            // 
            this.AddPartPriceText.BackColor = System.Drawing.Color.White;
            this.AddPartPriceText.Location = new System.Drawing.Point(176, 213);
            this.AddPartPriceText.Name = "AddPartPriceText";
            this.AddPartPriceText.Size = new System.Drawing.Size(125, 23);
            this.AddPartPriceText.TabIndex = 4;
            this.AddPartPriceText.TextChanged += new System.EventHandler(this.AddPartPriceText_TextChanged);
            this.AddPartPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartPriceText_KeyPress);
            // 
            // AddPartMaxText
            // 
            this.AddPartMaxText.BackColor = System.Drawing.Color.White;
            this.AddPartMaxText.Location = new System.Drawing.Point(176, 258);
            this.AddPartMaxText.Name = "AddPartMaxText";
            this.AddPartMaxText.Size = new System.Drawing.Size(100, 23);
            this.AddPartMaxText.TabIndex = 5;
            this.AddPartMaxText.TextChanged += new System.EventHandler(this.AddPartMaxText_TextChanged);
            this.AddPartMaxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMaxText_KeyPress);
            // 
            // AddPartCompanyText
            // 
            this.AddPartCompanyText.BackColor = System.Drawing.Color.White;
            this.AddPartCompanyText.Location = new System.Drawing.Point(176, 304);
            this.AddPartCompanyText.Name = "AddPartCompanyText";
            this.AddPartCompanyText.Size = new System.Drawing.Size(125, 23);
            this.AddPartCompanyText.TabIndex = 8;
            this.AddPartCompanyText.Visible = false;
            this.AddPartCompanyText.TextChanged += new System.EventHandler(this.AddPartCompanyText_TextChanged);
            // 
            // AddPartMachineIDText
            // 
            this.AddPartMachineIDText.BackColor = System.Drawing.Color.White;
            this.AddPartMachineIDText.Location = new System.Drawing.Point(176, 304);
            this.AddPartMachineIDText.Name = "AddPartMachineIDText";
            this.AddPartMachineIDText.Size = new System.Drawing.Size(125, 23);
            this.AddPartMachineIDText.TabIndex = 7;
            this.AddPartMachineIDText.TextChanged += new System.EventHandler(this.AddPartMachineIDText_TextChanged);
            this.AddPartMachineIDText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMachineIDText_KeyPress);
            // 
            // AddPartMinText
            // 
            this.AddPartMinText.BackColor = System.Drawing.Color.White;
            this.AddPartMinText.Location = new System.Drawing.Point(352, 258);
            this.AddPartMinText.Name = "AddPartMinText";
            this.AddPartMinText.Size = new System.Drawing.Size(100, 23);
            this.AddPartMinText.TabIndex = 6;
            this.AddPartMinText.TextChanged += new System.EventHandler(this.AddPartMinText_TextChanged);
            this.AddPartMinText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMinText_KeyPress);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.AddPartMinText);
            this.Controls.Add(this.AddPartMachineIDText);
            this.Controls.Add(this.AddPartCompanyText);
            this.Controls.Add(this.AddPartMaxText);
            this.Controls.Add(this.AddPartPriceText);
            this.Controls.Add(this.AddPartInventoryText);
            this.Controls.Add(this.AddPartNameText);
            this.Controls.Add(this.AddPartIDText);
            this.Controls.Add(this.AddPartCompanyLabel);
            this.Controls.Add(this.AddPartMachineIDLabel);
            this.Controls.Add(this.AddPartMaxLabel);
            this.Controls.Add(this.AddPartMinLabel);
            this.Controls.Add(this.AddPartPriceLabel);
            this.Controls.Add(this.AddPartInventoryLabel);
            this.Controls.Add(this.AddPartNameLabel);
            this.Controls.Add(this.AddPartIDLabel);
            this.Controls.Add(this.AddPartSaveButton);
            this.Controls.Add(this.AddPartCancelButton);
            this.Controls.Add(this.PartSource);
            this.Controls.Add(this.AddPartLabel);
            this.Name = "AddPart";
            this.Text = "Form1";
            this.PartSource.ResumeLayout(false);
            this.PartSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.GroupBox PartSource;
        private System.Windows.Forms.RadioButton PartOutsourcedButton;
        private System.Windows.Forms.RadioButton PartInHouseButton;
        private System.Windows.Forms.Button AddPartCancelButton;
        private System.Windows.Forms.Button AddPartSaveButton;
        private System.Windows.Forms.Label AddPartIDLabel;
        private System.Windows.Forms.Label AddPartNameLabel;
        private System.Windows.Forms.Label AddPartInventoryLabel;
        private System.Windows.Forms.Label AddPartPriceLabel;
        private System.Windows.Forms.Label AddPartMinLabel;
        private System.Windows.Forms.Label AddPartMaxLabel;
        private System.Windows.Forms.Label AddPartMachineIDLabel;
        private System.Windows.Forms.Label AddPartCompanyLabel;
        private System.Windows.Forms.TextBox AddPartIDText;
        private System.Windows.Forms.TextBox AddPartNameText;
        private System.Windows.Forms.TextBox AddPartInventoryText;
        private System.Windows.Forms.TextBox AddPartPriceText;
        private System.Windows.Forms.TextBox AddPartMaxText;
        private System.Windows.Forms.TextBox AddPartCompanyText;
        private System.Windows.Forms.TextBox AddPartMachineIDText;
        private System.Windows.Forms.TextBox AddPartMinText;
    }
}