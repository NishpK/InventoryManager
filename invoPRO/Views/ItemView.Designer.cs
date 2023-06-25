namespace invoPRO
{
    partial class ItemView
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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.usersgv = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qtytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brandtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Items and Inventory";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(327, 411);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 42);
            this.button4.TabIndex = 34;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // usersgv
            // 
            this.usersgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersgv.BackgroundColor = System.Drawing.Color.White;
            this.usersgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersgv.EnableHeadersVisualStyles = false;
            this.usersgv.GridColor = System.Drawing.Color.Black;
            this.usersgv.Location = new System.Drawing.Point(532, -1);
            this.usersgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersgv.Name = "usersgv";
            this.usersgv.RowHeadersVisible = false;
            this.usersgv.RowHeadersWidth = 51;
            this.usersgv.RowTemplate.Height = 24;
            this.usersgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersgv.Size = new System.Drawing.Size(1079, 855);
            this.usersgv.TabIndex = 33;
            this.usersgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersgv_CellContentClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(188, 458);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 42);
            this.button3.TabIndex = 32;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(188, 411);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 42);
            this.button2.TabIndex = 31;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(49, 411);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(133, 42);
            this.AddBtn.TabIndex = 30;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // pricetb
            // 
            this.pricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetb.Location = new System.Drawing.Point(136, 370);
            this.pricetb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(328, 23);
            this.pricetb.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Unit Price:";
            // 
            // qtytb
            // 
            this.qtytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytb.Location = new System.Drawing.Point(136, 341);
            this.qtytb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qtytb.Name = "qtytb";
            this.qtytb.Size = new System.Drawing.Size(328, 23);
            this.qtytb.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = " Quantity:";
            // 
            // nametb
            // 
            this.nametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.Location = new System.Drawing.Point(136, 268);
            this.nametb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(327, 23);
            this.nametb.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item Name:";
            // 
            // idtb
            // 
            this.idtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtb.Location = new System.Drawing.Point(136, 239);
            this.idtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(327, 23);
            this.idtb.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(49, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Item ID:";
            // 
            // brandtb
            // 
            this.brandtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandtb.Location = new System.Drawing.Point(137, 304);
            this.brandtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandtb.Name = "brandtb";
            this.brandtb.Size = new System.Drawing.Size(327, 23);
            this.brandtb.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Brand:";
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(52, 134);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(88, 34);
            this.searchbtn.TabIndex = 38;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(163, 138);
            this.searchtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(327, 27);
            this.searchtb.TabIndex = 39;
            this.searchtb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchtb_MouseClick);
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 881);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.brandtb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.usersgv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qtytb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemView";
            this.Text = "ItemView";
            ((System.ComponentModel.ISupportInitialize)(this.usersgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView usersgv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qtytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brandtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtb;
    }
}