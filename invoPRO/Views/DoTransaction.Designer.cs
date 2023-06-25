namespace invoPRO.Views
{
    partial class DoTransaction
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
            this.addItem = new System.Windows.Forms.Button();
            this.ConfirmTransaction = new System.Windows.Forms.Button();
            this.revertBtn = new System.Windows.Forms.Button();
            this.itemIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QtyTxt = new System.Windows.Forms.TextBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subTransactionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionIDTxt = new System.Windows.Forms.TextBox();
            this.subtotalTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(74, 445);
            this.addItem.Margin = new System.Windows.Forms.Padding(4);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(156, 28);
            this.addItem.TabIndex = 0;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // ConfirmTransaction
            // 
            this.ConfirmTransaction.Location = new System.Drawing.Point(74, 557);
            this.ConfirmTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmTransaction.Name = "ConfirmTransaction";
            this.ConfirmTransaction.Size = new System.Drawing.Size(331, 28);
            this.ConfirmTransaction.TabIndex = 1;
            this.ConfirmTransaction.Text = "Complete Transaction";
            this.ConfirmTransaction.UseVisualStyleBackColor = true;
            this.ConfirmTransaction.Click += new System.EventHandler(this.ConfirmTransaction_Click);
            // 
            // revertBtn
            // 
            this.revertBtn.Location = new System.Drawing.Point(249, 445);
            this.revertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.revertBtn.Name = "revertBtn";
            this.revertBtn.Size = new System.Drawing.Size(156, 28);
            this.revertBtn.TabIndex = 2;
            this.revertBtn.Text = "Cancel Transaction";
            this.revertBtn.UseVisualStyleBackColor = true;
            this.revertBtn.Click += new System.EventHandler(this.revertBtn_Click);
            // 
            // itemIDTxt
            // 
            this.itemIDTxt.Location = new System.Drawing.Point(77, 223);
            this.itemIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.itemIDTxt.Name = "itemIDTxt";
            this.itemIDTxt.Size = new System.Drawing.Size(327, 22);
            this.itemIDTxt.TabIndex = 3;
            this.itemIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // QtyTxt
            // 
            this.QtyTxt.Location = new System.Drawing.Point(77, 282);
            this.QtyTxt.Margin = new System.Windows.Forms.Padding(4);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(327, 22);
            this.QtyTxt.TabIndex = 6;
            this.QtyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(77, 344);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(327, 22);
            this.PriceTxt.TabIndex = 8;
            this.PriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // subTransactionTxt
            // 
            this.subTransactionTxt.Enabled = false;
            this.subTransactionTxt.Location = new System.Drawing.Point(1044, 38);
            this.subTransactionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.subTransactionTxt.Name = "subTransactionTxt";
            this.subTransactionTxt.Size = new System.Drawing.Size(155, 22);
            this.subTransactionTxt.TabIndex = 12;
            this.subTransactionTxt.TextChanged += new System.EventHandler(this.subTransactionTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(977, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transaction ID";
            // 
            // transactionIDTxt
            // 
            this.transactionIDTxt.Enabled = false;
            this.transactionIDTxt.Location = new System.Drawing.Point(638, 38);
            this.transactionIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.transactionIDTxt.Name = "transactionIDTxt";
            this.transactionIDTxt.Size = new System.Drawing.Size(155, 22);
            this.transactionIDTxt.TabIndex = 9;
            // 
            // subtotalTxt
            // 
            this.subtotalTxt.Enabled = false;
            this.subtotalTxt.Location = new System.Drawing.Point(74, 509);
            this.subtotalTxt.Margin = new System.Windows.Forms.Padding(4);
            this.subtotalTxt.Name = "subtotalTxt";
            this.subtotalTxt.Size = new System.Drawing.Size(329, 22);
            this.subtotalTxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 490);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sub-Total";
            // 
            // discountTxt
            // 
            this.discountTxt.Location = new System.Drawing.Point(74, 404);
            this.discountTxt.Margin = new System.Windows.Forms.Padding(4);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(329, 22);
            this.discountTxt.TabIndex = 16;
            this.discountTxt.Text = "0";
            this.discountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 384);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(132, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "InvoPro Sales";
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AllowUserToAddRows = false;
            this.salesDataGrid.AllowUserToDeleteRows = false;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Location = new System.Drawing.Point(488, 108);
            this.salesDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.ReadOnly = true;
            this.salesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.salesDataGrid.RowHeadersWidth = 51;
            this.salesDataGrid.Size = new System.Drawing.Size(981, 549);
            this.salesDataGrid.TabIndex = 18;
            // 
            // DoTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 887);
            this.ControlBox = false;
            this.Controls.Add(this.salesDataGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.discountTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subtotalTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subTransactionTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transactionIDTxt);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QtyTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemIDTxt);
            this.Controls.Add(this.revertBtn);
            this.Controls.Add(this.ConfirmTransaction);
            this.Controls.Add(this.addItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoTransaction";
            this.Text = "DoTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button ConfirmTransaction;
        private System.Windows.Forms.Button revertBtn;
        private System.Windows.Forms.TextBox itemIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QtyTxt;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subTransactionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox transactionIDTxt;
        private System.Windows.Forms.TextBox subtotalTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView salesDataGrid;
    }
}