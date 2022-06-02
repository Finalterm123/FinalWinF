namespace QL_Xe.Chuyen_Mon
{
    partial class DS_Xoa_CM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_Tim_Kiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_DS_Chuyen_Mon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DS_Chuyen_Mon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 75);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xóa chuyên môn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.textBox_Tim_Kiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 45);
            this.panel3.TabIndex = 4;
            // 
            // textBox_Tim_Kiem
            // 
            this.textBox_Tim_Kiem.Location = new System.Drawing.Point(404, 7);
            this.textBox_Tim_Kiem.Name = "textBox_Tim_Kiem";
            this.textBox_Tim_Kiem.Size = new System.Drawing.Size(180, 30);
            this.textBox_Tim_Kiem.TabIndex = 4;
            this.textBox_Tim_Kiem.TextChanged += new System.EventHandler(this.textBox_Tim_Kiem_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_DS_Chuyen_Mon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 461);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView_DS_Chuyen_Mon
            // 
            this.dataGridView_DS_Chuyen_Mon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DS_Chuyen_Mon.Location = new System.Drawing.Point(12, 3);
            this.dataGridView_DS_Chuyen_Mon.Name = "dataGridView_DS_Chuyen_Mon";
            this.dataGridView_DS_Chuyen_Mon.RowHeadersWidth = 51;
            this.dataGridView_DS_Chuyen_Mon.RowTemplate.Height = 24;
            this.dataGridView_DS_Chuyen_Mon.Size = new System.Drawing.Size(990, 447);
            this.dataGridView_DS_Chuyen_Mon.TabIndex = 0;
            this.dataGridView_DS_Chuyen_Mon.DoubleClick += new System.EventHandler(this.dataGridView_DS_Chuyen_Mon_DoubleClick);
            // 
            // DS_Xoa_CM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DS_Xoa_CM";
            this.Text = "DS_Xoa_CM";
            this.Load += new System.EventHandler(this.DS_Xoa_CM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DS_Chuyen_Mon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_Tim_Kiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_DS_Chuyen_Mon;
    }
}