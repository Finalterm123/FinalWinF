namespace QL_Xe.TrongCoiXe
{
    partial class Danh_Sach_Trong_Coi_Xe
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
            this.dataGridView_Trongcoixe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Trongcoixe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Trongcoixe
            // 
            this.dataGridView_Trongcoixe.AllowUserToAddRows = false;
            this.dataGridView_Trongcoixe.AllowUserToDeleteRows = false;
            this.dataGridView_Trongcoixe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Trongcoixe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Trongcoixe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Trongcoixe.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Trongcoixe.Name = "dataGridView_Trongcoixe";
            this.dataGridView_Trongcoixe.RowHeadersWidth = 51;
            this.dataGridView_Trongcoixe.RowTemplate.Height = 24;
            this.dataGridView_Trongcoixe.Size = new System.Drawing.Size(972, 469);
            this.dataGridView_Trongcoixe.TabIndex = 2;
            this.dataGridView_Trongcoixe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Trongcoixe_CellClick);
            // 
            // Danh_Sach_Trong_Coi_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 559);
            this.Controls.Add(this.dataGridView_Trongcoixe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Danh_Sach_Trong_Coi_Xe";
            this.Text = "Danh_Sach_Trong_Coi_Xe";
            this.Load += new System.EventHandler(this.Danh_Sach_Trong_Coi_Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Trongcoixe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Trongcoixe;
    }
}