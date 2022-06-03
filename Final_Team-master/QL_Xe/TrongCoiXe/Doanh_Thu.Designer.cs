namespace QL_Xe.TrongCoiXe
{
    partial class Doanh_Thu
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
            this.dataGridView_DaTra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DaTra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_DaTra
            // 
            this.dataGridView_DaTra.AllowUserToAddRows = false;
            this.dataGridView_DaTra.AllowUserToDeleteRows = false;
            this.dataGridView_DaTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DaTra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_DaTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DaTra.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_DaTra.Name = "dataGridView_DaTra";
            this.dataGridView_DaTra.RowHeadersWidth = 51;
            this.dataGridView_DaTra.RowTemplate.Height = 24;
            this.dataGridView_DaTra.Size = new System.Drawing.Size(972, 326);
            this.dataGridView_DaTra.TabIndex = 2;
            // 
            // Doanh_Thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 559);
            this.Controls.Add(this.dataGridView_DaTra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Doanh_Thu";
            this.Text = "Doanh_Thu";
            this.Load += new System.EventHandler(this.Doanh_Thu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DaTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DaTra;
    }
}