namespace QL_Xe.Tho
{
    partial class DS_Tim_Tho
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
            this.radioButton_All = new System.Windows.Forms.RadioButton();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.button_Tim_Kiem = new System.Windows.Forms.Button();
            this.textBox_Tim_Kiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_Tho = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tho)).BeginInit();
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Thợ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.radioButton_All);
            this.panel3.Controls.Add(this.radioButton_Nu);
            this.panel3.Controls.Add(this.radioButton_Nam);
            this.panel3.Controls.Add(this.button_Tim_Kiem);
            this.panel3.Controls.Add(this.textBox_Tim_Kiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 45);
            this.panel3.TabIndex = 3;
            // 
            // radioButton_All
            // 
            this.radioButton_All.AutoSize = true;
            this.radioButton_All.Location = new System.Drawing.Point(114, 10);
            this.radioButton_All.Name = "radioButton_All";
            this.radioButton_All.Size = new System.Drawing.Size(85, 27);
            this.radioButton_All.TabIndex = 8;
            this.radioButton_All.TabStop = true;
            this.radioButton_All.Text = "Tất cả";
            this.radioButton_All.UseVisualStyleBackColor = true;
            this.radioButton_All.CheckedChanged += new System.EventHandler(this.radioButton_All_CheckedChanged);
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(321, 10);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(57, 27);
            this.radioButton_Nu.TabIndex = 7;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            this.radioButton_Nu.CheckedChanged += new System.EventHandler(this.radioButton_Nu_CheckedChanged);
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(223, 10);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(70, 27);
            this.radioButton_Nam.TabIndex = 6;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            this.radioButton_Nam.CheckedChanged += new System.EventHandler(this.radioButton_Nam_CheckedChanged);
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
            this.textBox_Tim_Kiem.Location = new System.Drawing.Point(663, 9);
            this.textBox_Tim_Kiem.Name = "textBox_Tim_Kiem";
            this.textBox_Tim_Kiem.Size = new System.Drawing.Size(180, 30);
            this.textBox_Tim_Kiem.TabIndex = 4;
            this.textBox_Tim_Kiem.TextChanged += new System.EventHandler(this.textBox_Tim_Kiem_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Tho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 461);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView_Tho
            // 
            this.dataGridView_Tho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tho.Location = new System.Drawing.Point(3, 6);
            this.dataGridView_Tho.Name = "dataGridView_Tho";
            this.dataGridView_Tho.RowHeadersWidth = 51;
            this.dataGridView_Tho.RowTemplate.Height = 24;
            this.dataGridView_Tho.Size = new System.Drawing.Size(1008, 452);
            this.dataGridView_Tho.TabIndex = 0;
            this.dataGridView_Tho.DoubleClick += new System.EventHandler(this.dataGridView_Tho_DoubleClick);
            // 
            // DS_Tim_Tho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DS_Tim_Tho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS_Tim_Tho";
            this.Load += new System.EventHandler(this.DS_Tim_Tho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tho)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView_Tho;
        private System.Windows.Forms.RadioButton radioButton_Nam;
        private System.Windows.Forms.RadioButton radioButton_Nu;
        private System.Windows.Forms.RadioButton radioButton_All;
    }
}