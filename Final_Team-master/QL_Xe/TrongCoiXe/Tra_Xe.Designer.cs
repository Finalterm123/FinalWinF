namespace QL_Xe.TrongCoiXe
{
    partial class Tra_Xe
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
            this.dataGridView_Traxe = new System.Windows.Forms.DataGridView();
            this.button_Tra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Traxe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Traxe
            // 
            this.dataGridView_Traxe.AllowUserToAddRows = false;
            this.dataGridView_Traxe.AllowUserToDeleteRows = false;
            this.dataGridView_Traxe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Traxe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Traxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Traxe.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Traxe.Name = "dataGridView_Traxe";
            this.dataGridView_Traxe.RowHeadersWidth = 51;
            this.dataGridView_Traxe.RowTemplate.Height = 24;
            this.dataGridView_Traxe.Size = new System.Drawing.Size(972, 326);
            this.dataGridView_Traxe.TabIndex = 1;
            // 
            // button_Tra
            // 
            this.button_Tra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tra.Location = new System.Drawing.Point(364, 481);
            this.button_Tra.Name = "button_Tra";
            this.button_Tra.Size = new System.Drawing.Size(212, 66);
            this.button_Tra.TabIndex = 28;
            this.button_Tra.Text = "Xong";
            this.button_Tra.UseVisualStyleBackColor = true;
            this.button_Tra.Click += new System.EventHandler(this.button_Tra_Click);
            // 
            // Tra_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 559);
            this.Controls.Add(this.button_Tra);
            this.Controls.Add(this.dataGridView_Traxe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Tra_Xe";
            this.Text = "Tra_Xe";
            this.Load += new System.EventHandler(this.Tra_Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Traxe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Traxe;
        private System.Windows.Forms.Button button_Tra;
    }
}