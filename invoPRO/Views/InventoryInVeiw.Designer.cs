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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AllowUserToAddRows = false;
            this.salesDataGrid.AllowUserToDeleteRows = false;
            this.salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Location = new System.Drawing.Point(346, 502);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.ReadOnly = true;
            this.salesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.salesDataGrid.RowHeadersWidth = 51;
            this.salesDataGrid.Size = new System.Drawing.Size(869, 196);
            this.salesDataGrid.TabIndex = 37;
            // 
            // subTransactionTxt
            // 
            this.subTransactionTxt.Enabled = false;
            this.subTransactionTxt.Location = new System.Drawing.Point(830, 48);
            this.subTransactionTxt.Name = "subTransactionTxt";
            this.subTransactionTxt.Size = new System.Drawing.Size(117, 20);
            this.subTransactionTxt.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Item No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Restock ID";
            // 
            // transactionIDTxt
            // 
            this.transactionIDTxt.Enabled = false;
            this.transactionIDTxt.Location = new System.Drawing.Point(599, 48);
            this.transactionIDTxt.Name = "transactionIDTxt";
            this.transactionIDTxt.Size = new System.Drawing.Size(117, 20);
            this.transactionIDTxt.TabIndex = 28;
            // 
            // QtyTxt
            // 
            this.QtyTxt.Location = new System.Drawing.Point(51, 312);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(246, 20);
            this.QtyTxt.TabIndex = 25;
            this.QtyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QtyTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QtyTxt_MouseClick);
            this.QtyTxt.TextChanged += new System.EventHandler(this.QtyTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Supplier ID";
            // 
            // supplierIDTxt
            // 
            this.supplierIDTxt.Location = new System.Drawing.Point(51, 264);
            this.supplierIDTxt.Name = "supplierIDTxt";
            this.supplierIDTxt.Size = new System.Drawing.Size(246, 20);
            this.supplierIDTxt.TabIndex = 22;
            this.supplierIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supplierIDTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.supplierIDTxt_MouseClick);
            this.supplierIDTxt.TextChanged += new System.EventHandler(this.supplierIDTxt_TextChanged);
            // 
            // revertBtn
            // 
            this.revertBtn.Location = new System.Drawing.Point(179, 365);
            this.revertBtn.Name = "revertBtn";
            this.revertBtn.Size = new System.Drawing.Size(117, 23);
            this.revertBtn.TabIndex = 21;
            this.revertBtn.Text = "Cancel Order";
            this.revertBtn.UseVisualStyleBackColor = true;
            this.revertBtn.Click += new System.EventHandler(this.revertBtn_Click_1);
            // 
            // ConfirmTransaction
            // 
            this.ConfirmTransaction.Location = new System.Drawing.Point(51, 426);
            this.ConfirmTransaction.Name = "ConfirmTransaction";
            this.ConfirmTransaction.Size = new System.Drawing.Size(248, 23);
            this.ConfirmTransaction.TabIndex = 20;
            this.ConfirmTransaction.Text = "Complete Order";
            this.ConfirmTransaction.UseVisualStyleBackColor = true;
            this.ConfirmTransaction.Click += new System.EventHandler(this.ConfirmTransaction_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(48, 365);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(117, 23);
            this.addItem.TabIndex = 19;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Item ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // itemidTxt
            // 
            this.itemidTxt.Location = new System.Drawing.Point(54, 142);
            this.itemidTxt.Name = "itemidTxt";
            this.itemidTxt.Size = new System.Drawing.Size(246, 20);
            this.itemidTxt.TabIndex = 38;
            this.itemidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemidTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itemIdTxt_MouseClick);
            this.itemidTxt.TextChanged += new System.EventHandler(this.itemIdTxt_TextChanged);
            this.itemidTxt.Enter += new System.EventHandler(this.itemidTxt_Enter);
            this.itemidTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemidTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Item name";
            // 
            // itemnametb
            // 
            this.itemnametb.Location = new System.Drawing.Point(51, 202);
            this.itemnametb.Name = "itemnametb";
            this.itemnametb.Size = new System.Drawing.Size(246, 20);
            this.itemnametb.TabIndex = 40;
            this.itemnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemnametb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itemnametb_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(869, 336);
            this.dataGridView1.TabIndex = 42;
            // 
            // InventoryInVeiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 721);
            this.Controls.Add(this.dataGridView1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryInVeiw";
            this.Text = "InventoryIn";
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}