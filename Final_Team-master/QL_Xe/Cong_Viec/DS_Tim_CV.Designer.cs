namespace QL_Xe.Cong_Viec
{
    partial class DS_Tim_CV
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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Tim_Kiem = new System.Windows.Forms.Button();
            this.textBox_Tim_Kiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_CV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 75);
            this.panel1.TabIndex = 2;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(901, 9);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(76, 29);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Công Việc";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button_Tim_Kiem);
            this.panel3.Controls.Add(this.textBox_Tim_Kiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 45);
            this.panel3.TabIndex = 3;
            // 
            // button_Tim_Kiem
            // 
            this.button_Tim_Kiem.Location = new System.Drawing.Point(523, 6);
            this.button_Tim_Kiem.Name = "button_Tim_Kiem";
            this.button_Tim_Kiem.Size = new System.Drawing.Size(120, 32);
            this.button_Tim_Kiem.TabIndex = 5;
            this.button_Tim_Kiem.Text = "Tìm kiếm";
            this.button_Tim_Kiem.UseVisualStyleBackColor = true;
            // 
            // textBox_Tim_Kiem
            // 
            this.textBox_Tim_Kiem.Location = new System.Drawing.Point(320, 6);
            this.textBox_Tim_Kiem.Name = "textBox_Tim_Kiem";
            this.textBox_Tim_Kiem.Size = new System.Drawing.Size(180, 30);
            this.textBox_Tim_Kiem.TabIndex = 4;
            this.textBox_Tim_Kiem.TextChanged += new System.EventHandler(this.textBox_Tim_Kiem_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_CV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 461);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView_CV
            // 
            this.dataGridView_CV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CV.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_CV.Name = "dataGridView_CV";
            this.dataGridView_CV.RowHeadersWidth = 51;
            this.dataGridView_CV.RowTemplate.Height = 24;
            this.dataGridView_CV.Size = new System.Drawing.Size(999, 446);
            this.dataGridView_CV.TabIndex = 0;
            this.dataGridView_CV.DoubleClick += new System.EventHandler(this.dataGridView_CV_DoubleClick);
            // 
            // DS_Tim_CV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DS_Tim_CV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS_Tim_CV";
            this.Load += new System.EventHandler(this.DS_Tim_CV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Tim_Kiem;
        private System.Windows.Forms.TextBox textBox_Tim_Kiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_CV;
    }
}