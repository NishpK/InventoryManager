namespace invoPRO
{
    partial class transactionReport
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
            this.usergv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usergv)).BeginInit();
            this.SuspendLayout();
            // 
            // usergv
            // 
            this.usergv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usergv.Location = new System.Drawing.Point(12, 84);
            this.usergv.Name = "usergv";
            this.usergv.RowHeadersWidth = 51;
            this.usergv.RowTemplate.Height = 24;
            this.usergv.Size = new System.Drawing.Size(1306, 657);
            this.usergv.TabIndex = 0;
            this.usergv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Record ";
            // 
            // transactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usergv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transactionReport";
            this.Text = "transactionReport";
            ((System.ComponentModel.ISupportInitialize)(this.usergv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usergv;
        private System.Windows.Forms.Label label1;
    }
}