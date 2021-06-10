
namespace LacosteC968Task
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.mainPartsLabel = new System.Windows.Forms.Label();
            this.mainProductsLabel = new System.Windows.Forms.Label();
            this.mainPartsAddButton = new System.Windows.Forms.Button();
            this.mainPartsModifyButton = new System.Windows.Forms.Button();
            this.mainPartsDeleteButton = new System.Windows.Forms.Button();
            this.mainPartSearchButton = new System.Windows.Forms.Button();
            this.mainProductsAddButton = new System.Windows.Forms.Button();
            this.mainProductsModifyButton = new System.Windows.Forms.Button();
            this.mainProductsDeleteButton = new System.Windows.Forms.Button();
            this.mainProdSearchButton = new System.Windows.Forms.Button();
            this.mainExitButton = new System.Windows.Forms.Button();
            this.mainPartSearchText = new System.Windows.Forms.TextBox();
            this.mainProdSearchText = new System.Windows.Forms.TextBox();
            this.mainPartsDGV = new System.Windows.Forms.DataGridView();
            this.mainProdDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(270, 22);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "Inventory Management System";
            // 
            // mainPartsLabel
            // 
            this.mainPartsLabel.AutoSize = true;
            this.mainPartsLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainPartsLabel.Location = new System.Drawing.Point(39, 80);
            this.mainPartsLabel.Name = "mainPartsLabel";
            this.mainPartsLabel.Size = new System.Drawing.Size(54, 22);
            this.mainPartsLabel.TabIndex = 1;
            this.mainPartsLabel.Text = "Parts";
            // 
            // mainProductsLabel
            // 
            this.mainProductsLabel.AutoSize = true;
            this.mainProductsLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainProductsLabel.Location = new System.Drawing.Point(633, 80);
            this.mainProductsLabel.Name = "mainProductsLabel";
            this.mainProductsLabel.Size = new System.Drawing.Size(86, 22);
            this.mainProductsLabel.TabIndex = 2;
            this.mainProductsLabel.Text = "Products";
            // 
            // mainPartsAddButton
            // 
            this.mainPartsAddButton.Location = new System.Drawing.Point(368, 384);
            this.mainPartsAddButton.Name = "mainPartsAddButton";
            this.mainPartsAddButton.Size = new System.Drawing.Size(55, 35);
            this.mainPartsAddButton.TabIndex = 3;
            this.mainPartsAddButton.Text = "Add";
            this.mainPartsAddButton.UseVisualStyleBackColor = true;
            this.mainPartsAddButton.Click += new System.EventHandler(this.mainPartsAddButton_Click);
            // 
            // mainPartsModifyButton
            // 
            this.mainPartsModifyButton.Location = new System.Drawing.Point(432, 384);
            this.mainPartsModifyButton.Name = "mainPartsModifyButton";
            this.mainPartsModifyButton.Size = new System.Drawing.Size(55, 35);
            this.mainPartsModifyButton.TabIndex = 4;
            this.mainPartsModifyButton.Text = "Modify";
            this.mainPartsModifyButton.UseVisualStyleBackColor = true;
            this.mainPartsModifyButton.Click += new System.EventHandler(this.mainPartsModifyButton_Click);
            // 
            // mainPartsDeleteButton
            // 
            this.mainPartsDeleteButton.Location = new System.Drawing.Point(496, 384);
            this.mainPartsDeleteButton.Name = "mainPartsDeleteButton";
            this.mainPartsDeleteButton.Size = new System.Drawing.Size(55, 35);
            this.mainPartsDeleteButton.TabIndex = 5;
            this.mainPartsDeleteButton.Text = "Delete";
            this.mainPartsDeleteButton.UseVisualStyleBackColor = true;
            this.mainPartsDeleteButton.Click += new System.EventHandler(this.mainPartsDeleteButton_Click);
            // 
            // mainPartSearchButton
            // 
            this.mainPartSearchButton.Location = new System.Drawing.Point(304, 48);
            this.mainPartSearchButton.Name = "mainPartSearchButton";
            this.mainPartSearchButton.Size = new System.Drawing.Size(55, 23);
            this.mainPartSearchButton.TabIndex = 6;
            this.mainPartSearchButton.Text = "Search";
            this.mainPartSearchButton.UseVisualStyleBackColor = true;
            this.mainPartSearchButton.Click += new System.EventHandler(this.mainPartSearchButton_Click);
            // 
            // mainProductsAddButton
            // 
            this.mainProductsAddButton.Location = new System.Drawing.Point(984, 392);
            this.mainProductsAddButton.Name = "mainProductsAddButton";
            this.mainProductsAddButton.Size = new System.Drawing.Size(55, 35);
            this.mainProductsAddButton.TabIndex = 7;
            this.mainProductsAddButton.Text = "Add";
            this.mainProductsAddButton.UseVisualStyleBackColor = true;
            this.mainProductsAddButton.Click += new System.EventHandler(this.mainProductsAddButton_Click);
            // 
            // mainProductsModifyButton
            // 
            this.mainProductsModifyButton.Location = new System.Drawing.Point(1048, 392);
            this.mainProductsModifyButton.Name = "mainProductsModifyButton";
            this.mainProductsModifyButton.Size = new System.Drawing.Size(55, 35);
            this.mainProductsModifyButton.TabIndex = 8;
            this.mainProductsModifyButton.Text = "Modify";
            this.mainProductsModifyButton.UseVisualStyleBackColor = true;
            this.mainProductsModifyButton.Click += new System.EventHandler(this.mainProductsModifyButton_Click);
            // 
            // mainProductsDeleteButton
            // 
            this.mainProductsDeleteButton.Location = new System.Drawing.Point(1112, 392);
            this.mainProductsDeleteButton.Name = "mainProductsDeleteButton";
            this.mainProductsDeleteButton.Size = new System.Drawing.Size(55, 35);
            this.mainProductsDeleteButton.TabIndex = 9;
            this.mainProductsDeleteButton.Text = "Delete";
            this.mainProductsDeleteButton.UseVisualStyleBackColor = true;
            this.mainProductsDeleteButton.Click += new System.EventHandler(this.mainProductsDeleteButton_Click);
            // 
            // mainProdSearchButton
            // 
            this.mainProdSearchButton.Location = new System.Drawing.Point(880, 48);
            this.mainProdSearchButton.Name = "mainProdSearchButton";
            this.mainProdSearchButton.Size = new System.Drawing.Size(55, 23);
            this.mainProdSearchButton.TabIndex = 10;
            this.mainProdSearchButton.Text = "Search";
            this.mainProdSearchButton.UseVisualStyleBackColor = true;
            this.mainProdSearchButton.Click += new System.EventHandler(this.mainProdSearchButton_Click);
            // 
            // mainExitButton
            // 
            this.mainExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainExitButton.Location = new System.Drawing.Point(1112, 440);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(55, 35);
            this.mainExitButton.TabIndex = 11;
            this.mainExitButton.Text = "Exit";
            this.mainExitButton.UseVisualStyleBackColor = true;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // mainPartSearchText
            // 
            this.mainPartSearchText.Location = new System.Drawing.Point(376, 48);
            this.mainPartSearchText.Name = "mainPartSearchText";
            this.mainPartSearchText.Size = new System.Drawing.Size(168, 23);
            this.mainPartSearchText.TabIndex = 12;
            // 
            // mainProdSearchText
            // 
            this.mainProdSearchText.Location = new System.Drawing.Point(952, 48);
            this.mainProdSearchText.Name = "mainProdSearchText";
            this.mainProdSearchText.Size = new System.Drawing.Size(168, 23);
            this.mainProdSearchText.TabIndex = 13;
            // 
            // mainPartsDGV
            // 
            this.mainPartsDGV.AllowUserToAddRows = false;
            this.mainPartsDGV.AllowUserToDeleteRows = false;
            this.mainPartsDGV.AllowUserToResizeColumns = false;
            this.mainPartsDGV.AllowUserToResizeRows = false;
            this.mainPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mainPartsDGV.Location = new System.Drawing.Point(48, 120);
            this.mainPartsDGV.Name = "mainPartsDGV";
            this.mainPartsDGV.ReadOnly = true;
            this.mainPartsDGV.RowHeadersVisible = false;
            this.mainPartsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainPartsDGV.RowTemplate.Height = 25;
            this.mainPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainPartsDGV.Size = new System.Drawing.Size(500, 250);
            this.mainPartsDGV.TabIndex = 14;
            this.mainPartsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainPartsDGV_CellClick);
            // 
            // mainProdDGV
            // 
            this.mainProdDGV.AllowDrop = true;
            this.mainProdDGV.AllowUserToAddRows = false;
            this.mainProdDGV.AllowUserToDeleteRows = false;
            this.mainProdDGV.AllowUserToResizeColumns = false;
            this.mainProdDGV.AllowUserToResizeRows = false;
            this.mainProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mainProdDGV.Location = new System.Drawing.Point(648, 120);
            this.mainProdDGV.MultiSelect = false;
            this.mainProdDGV.Name = "mainProdDGV";
            this.mainProdDGV.ReadOnly = true;
            this.mainProdDGV.RowHeadersVisible = false;
            this.mainProdDGV.RowHeadersWidth = 35;
            this.mainProdDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainProdDGV.RowTemplate.Height = 25;
            this.mainProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProdDGV.Size = new System.Drawing.Size(500, 250);
            this.mainProdDGV.TabIndex = 15;
            this.mainProdDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainProdDGV_CellClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 486);
            this.Controls.Add(this.mainProdDGV);
            this.Controls.Add(this.mainPartsDGV);
            this.Controls.Add(this.mainProdSearchText);
            this.Controls.Add(this.mainPartSearchText);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.mainProdSearchButton);
            this.Controls.Add(this.mainProductsDeleteButton);
            this.Controls.Add(this.mainProductsModifyButton);
            this.Controls.Add(this.mainProductsAddButton);
            this.Controls.Add(this.mainPartSearchButton);
            this.Controls.Add(this.mainPartsDeleteButton);
            this.Controls.Add(this.mainPartsModifyButton);
            this.Controls.Add(this.mainPartsAddButton);
            this.Controls.Add(this.mainProductsLabel);
            this.Controls.Add(this.mainPartsLabel);
            this.Controls.Add(this.mainTitleLabel);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Label mainPartsLabel;
        private System.Windows.Forms.Label mainProductsLabel;
        private System.Windows.Forms.Button mainPartsAddButton;
        private System.Windows.Forms.Button mainPartsModifyButton;
        private System.Windows.Forms.Button mainPartsDeleteButton;
        private System.Windows.Forms.Button mainPartSearchButton;
        private System.Windows.Forms.Button mainProductsAddButton;
        private System.Windows.Forms.Button mainProductsModifyButton;
        private System.Windows.Forms.Button mainProductsDeleteButton;
        private System.Windows.Forms.Button mainProdSearchButton;
        private System.Windows.Forms.Button mainExitButton;
        private System.Windows.Forms.TextBox mainPartSearchText;
        private System.Windows.Forms.TextBox mainProdSearchText;
        private System.Windows.Forms.DataGridView mainPartsDGV;
        private System.Windows.Forms.DataGridView mainProdDGV;
    }
}

