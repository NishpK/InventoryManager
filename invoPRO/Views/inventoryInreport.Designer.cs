namespace invoPRO
{
    partial class inventoryInreport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.usergv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usergv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Record ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usergv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usergv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usergv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usergv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usergv.Location = new System.Drawing.Point(12, 93);
            this.usergv.Name = "usergv";
            this.usergv.RowHeadersWidth = 51;
            this.usergv.RowTemplate.Height = 24;
            this.usergv.Size = new System.Drawing.Size(1632, 782);
            this.usergv.TabIndex = 2;
            this.usergv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usergv_CellContentClick);
            // 
            // inventoryInreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 887);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usergv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryInreport";
            this.Text = "inventoryInreport";
            ((System.ComponentModel.ISupportInitialize)(this.usergv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView usergv;
    }
}