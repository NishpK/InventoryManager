namespace invoPRO
{
    partial class InventoryInVeiw
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
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            this.subTransactionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionIDTxt = new System.Windows.Forms.TextBox();
            this.QtyTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierIDTxt = new System.Windows.Forms.TextBox();
            this.revertBtn = new System.Windows.Forms.Button();
            this.ConfirmTransaction = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.itemidTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemnametb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AllowUserToAddRows = false;
            this.salesDataGrid.AllowUserToDeleteRows = false;
            this.salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Location = new System.Drawing.Point(472, 111);
            this.salesDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.ReadOnly = true;
            this.salesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.salesDataGrid.RowHeadersWidth = 51;
            this.salesDataGrid.Size = new System.Drawing.Size(1100, 648);
            this.salesDataGrid.TabIndex = 37;
            // 
            // subTransactionTxt
            // 
            this.subTransactionTxt.Enabled = false;
            this.subTransactionTxt.Location = new System.Drawing.Point(1189, 54);
            this.subTransactionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.subTransactionTxt.Name = "subTransactionTxt";
            this.subTransactionTxt.Size = new System.Drawing.Size(155, 22);
            this.subTransactionTxt.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1122, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Item No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "inventory in ID";
            // 
            // transactionIDTxt
            // 
            this.transactionIDTxt.Enabled = false;
            this.transactionIDTxt.Location = new System.Drawing.Point(735, 58);
            this.transactionIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.transactionIDTxt.Name = "transactionIDTxt";
            this.transactionIDTxt.Size = new System.Drawing.Size(155, 22);
            this.transactionIDTxt.TabIndex = 28;
            // 
            // QtyTxt
            // 
            this.QtyTxt.Location = new System.Drawing.Point(68, 384);
            this.QtyTxt.Margin = new System.Windows.Forms.Padding(4);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(327, 22);
            this.QtyTxt.TabIndex = 25;
            this.QtyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QtyTxt.TextChanged += new System.EventHandler(this.QtyTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Supplier ID";
            // 
            // supplierIDTxt
            // 
            this.supplierIDTxt.Location = new System.Drawing.Point(68, 325);
            this.supplierIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.supplierIDTxt.Name = "supplierIDTxt";
            this.supplierIDTxt.Size = new System.Drawing.Size(327, 22);
            this.supplierIDTxt.TabIndex = 22;
            this.supplierIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supplierIDTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.supplierIDTxt_MouseClick);
            this.supplierIDTxt.TextChanged += new System.EventHandler(this.supplierIDTxt_TextChanged);
            // 
            // revertBtn
            // 
            this.revertBtn.Location = new System.Drawing.Point(239, 449);
            this.revertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.revertBtn.Name = "revertBtn";
            this.revertBtn.Size = new System.Drawing.Size(156, 28);
            this.revertBtn.TabIndex = 21;
            this.revertBtn.Text = "Cancel Order";
            this.revertBtn.UseVisualStyleBackColor = true;
            this.revertBtn.Click += new System.EventHandler(this.revertBtn_Click_1);
            // 
            // ConfirmTransaction
            // 
            this.ConfirmTransaction.Location = new System.Drawing.Point(68, 524);
            this.ConfirmTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmTransaction.Name = "ConfirmTransaction";
            this.ConfirmTransaction.Size = new System.Drawing.Size(331, 28);
            this.ConfirmTransaction.TabIndex = 20;
            this.ConfirmTransaction.Text = "Complete Order";
            this.ConfirmTransaction.UseVisualStyleBackColor = true;
            this.ConfirmTransaction.Click += new System.EventHandler(this.ConfirmTransaction_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(64, 449);
            this.addItem.Margin = new System.Windows.Forms.Padding(4);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(156, 28);
            this.addItem.TabIndex = 19;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Item ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // itemidTxt
            // 
            this.itemidTxt.Location = new System.Drawing.Point(72, 175);
            this.itemidTxt.Margin = new System.Windows.Forms.Padding(4);
            this.itemidTxt.Name = "itemidTxt";
            this.itemidTxt.Size = new System.Drawing.Size(327, 22);
            this.itemidTxt.TabIndex = 38;
            this.itemidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemidTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itemIdTxt_MouseClick);
            this.itemidTxt.TextChanged += new System.EventHandler(this.itemIdTxt_TextChanged);
            this.itemidTxt.Enter += new System.EventHandler(this.itemidTxt_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Item name";
            // 
            // itemnametb
            // 
            this.itemnametb.Location = new System.Drawing.Point(68, 248);
            this.itemnametb.Margin = new System.Windows.Forms.Padding(4);
            this.itemnametb.Name = "itemnametb";
            this.itemnametb.Size = new System.Drawing.Size(327, 22);
            this.itemnametb.TabIndex = 40;
            this.itemnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InventoryInVeiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 887);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemnametb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.itemidTxt);
            this.Controls.Add(this.salesDataGrid);
            this.Controls.Add(this.subTransactionTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transactionIDTxt);
            this.Controls.Add(this.QtyTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplierIDTxt);
            this.Controls.Add(this.revertBtn);
            this.Controls.Add(this.ConfirmTransaction);
            this.Controls.Add(this.addItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryInVeiw";
            this.Text = "InventoryIn";
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesDataGrid;
        private System.Windows.Forms.TextBox subTransactionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox transactionIDTxt;
        private System.Windows.Forms.TextBox QtyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplierIDTxt;
        private System.Windows.Forms.Button revertBtn;
        private System.Windows.Forms.Button ConfirmTransaction;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox itemidTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemnametb;
    }
}