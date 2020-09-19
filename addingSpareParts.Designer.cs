namespace myFirstApp
{
    partial class addingSpareParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addingSpareParts));
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsedQuantity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAvalableQuantity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton27 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_totalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.name,
            this.price,
            this.quantity,
            this.TotalCost});
            this.dgvItemList.Location = new System.Drawing.Point(670, 146);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(523, 286);
            this.dgvItemList.TabIndex = 77;
            // 
            // itemID
            // 
            this.itemID.DataPropertyName = "itemID";
            this.itemID.HeaderText = "id";
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            this.itemID.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "itemName";
            this.name.HeaderText = "Item Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "unitCost";
            this.price.HeaderText = "Unit Cost ";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "usedQuantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "totalCost";
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(403, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 89);
            this.label2.TabIndex = 73;
            this.label2.Text = "Spareparts List";
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(351, 153);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(211, 33);
            this.comboBoxItemName.TabIndex = 69;
            this.comboBoxItemName.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "Required Quantity :";
            // 
            // txtUsedQuantity
            // 
            this.txtUsedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtUsedQuantity.Location = new System.Drawing.Point(348, 274);
            this.txtUsedQuantity.Name = "txtUsedQuantity";
            this.txtUsedQuantity.Size = new System.Drawing.Size(214, 26);
            this.txtUsedQuantity.TabIndex = 68;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(34, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(311, 33);
            this.label19.TabIndex = 65;
            this.label19.Text = "Available Quantity :";
            // 
            // txtAvalableQuantity
            // 
            this.txtAvalableQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtAvalableQuantity.Location = new System.Drawing.Point(351, 219);
            this.txtAvalableQuantity.Name = "txtAvalableQuantity";
            this.txtAvalableQuantity.ReadOnly = true;
            this.txtAvalableQuantity.Size = new System.Drawing.Size(211, 26);
            this.txtAvalableQuantity.TabIndex = 66;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(192, 33);
            this.label18.TabIndex = 64;
            this.label18.Text = "Item Name :";
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "SAVE";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 2;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.Location = new System.Drawing.Point(231, 365);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(114, 67);
            this.bunifuThinButton24.TabIndex = 93;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "ADD";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 2;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton23.Location = new System.Drawing.Point(64, 365);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(114, 67);
            this.bunifuThinButton23.TabIndex = 92;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.button4_Click);
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "DELETE";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.IdleBorderThickness = 2;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton26.Location = new System.Drawing.Point(402, 365);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(114, 67);
            this.bunifuThinButton26.TabIndex = 91;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton26.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // bunifuThinButton27
            // 
            this.bunifuThinButton27.ActiveBorderThickness = 1;
            this.bunifuThinButton27.ActiveCornerRadius = 20;
            this.bunifuThinButton27.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton27.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton27.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton27.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton27.BackgroundImage")));
            this.bunifuThinButton27.ButtonText = "Close";
            this.bunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton27.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton27.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.IdleBorderThickness = 3;
            this.bunifuThinButton27.IdleCornerRadius = 20;
            this.bunifuThinButton27.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuThinButton27.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton27.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton27.Location = new System.Drawing.Point(1075, 687);
            this.bunifuThinButton27.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton27.Name = "bunifuThinButton27";
            this.bunifuThinButton27.Size = new System.Drawing.Size(118, 47);
            this.bunifuThinButton27.TabIndex = 99;
            this.bunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton27.Click += new System.EventHandler(this.bunifuThinButton27_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 33);
            this.label3.TabIndex = 100;
            this.label3.Text = "Total Item Cost : RS";
            // 
            // LBL_totalCost
            // 
            this.LBL_totalCost.AutoSize = true;
            this.LBL_totalCost.BackColor = System.Drawing.Color.Transparent;
            this.LBL_totalCost.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_totalCost.Location = new System.Drawing.Point(368, 537);
            this.LBL_totalCost.Name = "LBL_totalCost";
            this.LBL_totalCost.Size = new System.Drawing.Size(53, 33);
            this.LBL_totalCost.TabIndex = 101;
            this.LBL_totalCost.Text = "10";
            // 
            // addingSpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1224, 749);
            this.Controls.Add(this.LBL_totalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuThinButton27);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton26);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsedQuantity);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtAvalableQuantity);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addingSpareParts";
            this.Text = "addingSpareParts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsedQuantity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAvalableQuantity;
        private System.Windows.Forms.Label label18;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton27;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_totalCost;
    }
}