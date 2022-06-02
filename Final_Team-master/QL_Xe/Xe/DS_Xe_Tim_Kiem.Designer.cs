namespace QL_Xe.Xe
{
    partial class DS_Xe_Tim_Kiem
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
            this.comboBox_Loai_Xe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Tinh_Trang = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView_DS_Xe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DS_Xe)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Xe";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button_Tim_Kiem);
            this.panel3.Controls.Add(this.textBox_Tim_Kiem);
            this.panel3.Controls.Add(this.comboBox_Loai_Xe);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox_Tinh_Trang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 45);
            this.panel3.TabIndex = 2;
            // 
            // button_Tim_Kiem
            // 
            this.button_Tim_Kiem.Location = new System.Drawing.Point(866, 7);
            this.button_Tim_Kiem.Name = "button_Tim_Kiem";
            this.button_Tim_Kiem.Size = new System.Drawing.Size(120, 32);
            this.button_Tim_Kiem.TabIndex = 5;
            this.button_Tim_Kiem.Text = "Tìm kiếm";
            this.button_Tim_Kiem.UseVisualStyleBackColor = true;
            // 
            // textBox_Tim_Kiem
            // 
            this.textBox_Tim_Kiem.Location = new System.Drawing.Point(663, 7);
            this.textBox_Tim_Kiem.Name = "textBox_Tim_Kiem";
            this.textBox_Tim_Kiem.Size = new System.Drawing.Size(180, 32);
            this.textBox_Tim_Kiem.TabIndex = 4;
            this.textBox_Tim_Kiem.TextChanged += new System.EventHandler(this.textBox_Tim_Kiem_TextChanged);
            // 
            // comboBox_Loai_Xe
            // 
            this.comboBox_Loai_Xe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Loai_Xe.FormattingEnabled = true;
            this.comboBox_Loai_Xe.Location = new System.Drawing.Point(455, 11);
            this.comboBox_Loai_Xe.Name = "comboBox_Loai_Xe";
            this.comboBox_Loai_Xe.Size = new System.Drawing.Size(157, 27);
            this.comboBox_Loai_Xe.TabIndex = 3;
            this.comboBox_Loai_Xe.TextChanged += new System.EventHandler(this.comboBox_Loai_Xe_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn trình trạng xe:";
            // 
            // comboBox_Tinh_Trang
            // 
            this.comboBox_Tinh_Trang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Tinh_Trang.FormattingEnabled = true;
            this.comboBox_Tinh_Trang.Location = new System.Drawing.Point(183, 11);
            this.comboBox_Tinh_Trang.Name = "comboBox_Tinh_Trang";
            this.comboBox_Tinh_Trang.Size = new System.Drawing.Size(176, 27);
            this.comboBox_Tinh_Trang.TabIndex = 0;
            this.comboBox_Tinh_Trang.TextChanged += new System.EventHandler(this.comboBox_Tinh_Trang_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView_DS_Xe);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1014, 461);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView_DS_Xe
            // 
            this.dataGridView_DS_Xe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DS_Xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DS_Xe.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_DS_Xe.Name = "dataGridView_DS_Xe";
            this.dataGridView_DS_Xe.RowHeadersWidth = 51;
            this.dataGridView_DS_Xe.RowTemplate.Height = 24;
            this.dataGridView_DS_Xe.Size = new System.Drawing.Size(1011, 458);
            this.dataGridView_DS_Xe.TabIndex = 0;
            this.dataGridView_DS_Xe.DoubleClick += new System.EventHandler(this.dataGridView_DS_Xe_DoubleClick);
            // 
            // DS_Xe_Tim_Kiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 581);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DS_Xe_Tim_Kiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách";
            this.Load += new System.EventHandler(this.DS_Xe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DS_Xe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Tinh_Trang;
        private System.Windows.Forms.ComboBox comboBox_Loai_Xe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_DS_Xe;
        private System.Windows.Forms.Button button_Tim_Kiem;
        private System.Windows.Forms.TextBox textBox_Tim_Kiem;
        private System.Windows.Forms.Button button_Refresh;
    }
}