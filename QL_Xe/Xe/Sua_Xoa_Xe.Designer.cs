namespace QL_Xe.Xe
{
    partial class Sua_Xoa_Xe
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
            this.radioButton_Nhap_Tay = new System.Windows.Forms.RadioButton();
            this.radioButton_Chon = new System.Windows.Forms.RadioButton();
            this.button_Chon_Xe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Check_BS = new System.Windows.Forms.Label();
            this.label_Check_ID = new System.Windows.Forms.Label();
            this.textBox_ID_Xe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Chon_Loai_Xe = new System.Windows.Forms.Label();
            this.textBox_So_Bien = new System.Windows.Forms.TextBox();
            this.comboBox_Loai_Xe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Hinh = new System.Windows.Forms.Panel();
            this.comboBox_Tinh_Trang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.label_Check_Anh = new System.Windows.Forms.Label();
            this.button_Upload_Pic = new System.Windows.Forms.Button();
            this.label_hinh = new System.Windows.Forms.Label();
            this.button_Cap_Nhat = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Hinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.radioButton_Nhap_Tay);
            this.panel1.Controls.Add(this.radioButton_Chon);
            this.panel1.Controls.Add(this.button_Chon_Xe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 75);
            this.panel1.TabIndex = 1;
            // 
            // radioButton_Nhap_Tay
            // 
            this.radioButton_Nhap_Tay.AutoSize = true;
            this.radioButton_Nhap_Tay.ForeColor = System.Drawing.Color.White;
            this.radioButton_Nhap_Tay.Location = new System.Drawing.Point(24, 42);
            this.radioButton_Nhap_Tay.Name = "radioButton_Nhap_Tay";
            this.radioButton_Nhap_Tay.Size = new System.Drawing.Size(118, 27);
            this.radioButton_Nhap_Tay.TabIndex = 5;
            this.radioButton_Nhap_Tay.TabStop = true;
            this.radioButton_Nhap_Tay.Text = "Nhập tay";
            this.radioButton_Nhap_Tay.UseVisualStyleBackColor = true;
            this.radioButton_Nhap_Tay.CheckedChanged += new System.EventHandler(this.radioButton_Nhap_Tay_CheckedChanged);
            // 
            // radioButton_Chon
            // 
            this.radioButton_Chon.AutoSize = true;
            this.radioButton_Chon.ForeColor = System.Drawing.Color.White;
            this.radioButton_Chon.Location = new System.Drawing.Point(24, 12);
            this.radioButton_Chon.Name = "radioButton_Chon";
            this.radioButton_Chon.Size = new System.Drawing.Size(111, 27);
            this.radioButton_Chon.TabIndex = 4;
            this.radioButton_Chon.TabStop = true;
            this.radioButton_Chon.Text = "Chọn xe";
            this.radioButton_Chon.UseVisualStyleBackColor = true;
            this.radioButton_Chon.CheckedChanged += new System.EventHandler(this.radioButton_Chon_CheckedChanged);
            // 
            // button_Chon_Xe
            // 
            this.button_Chon_Xe.BackColor = System.Drawing.Color.White;
            this.button_Chon_Xe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Chon_Xe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_Chon_Xe.Location = new System.Drawing.Point(143, 12);
            this.button_Chon_Xe.Name = "button_Chon_Xe";
            this.button_Chon_Xe.Size = new System.Drawing.Size(200, 40);
            this.button_Chon_Xe.TabIndex = 3;
            this.button_Chon_Xe.Text = "Chọn xe";
            this.button_Chon_Xe.UseVisualStyleBackColor = false;
            this.button_Chon_Xe.Click += new System.EventHandler(this.button_Chon_Xe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(405, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sửa xe";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label_Check_BS);
            this.panel3.Controls.Add(this.label_Check_ID);
            this.panel3.Controls.Add(this.textBox_ID_Xe);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label_Chon_Loai_Xe);
            this.panel3.Controls.Add(this.textBox_So_Bien);
            this.panel3.Controls.Add(this.comboBox_Loai_Xe);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 76);
            this.panel3.TabIndex = 3;
            // 
            // label_Check_BS
            // 
            this.label_Check_BS.AutoSize = true;
            this.label_Check_BS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Check_BS.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Check_BS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Check_BS.Location = new System.Drawing.Point(757, 54);
            this.label_Check_BS.Name = "label_Check_BS";
            this.label_Check_BS.Size = new System.Drawing.Size(142, 15);
            this.label_Check_BS.TabIndex = 8;
            this.label_Check_BS.Text = "Vui Lòng nhập số biển";
            // 
            // label_Check_ID
            // 
            this.label_Check_ID.AutoSize = true;
            this.label_Check_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Check_ID.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Check_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Check_ID.Location = new System.Drawing.Point(140, 54);
            this.label_Check_ID.Name = "label_Check_ID";
            this.label_Check_ID.Size = new System.Drawing.Size(113, 15);
            this.label_Check_ID.TabIndex = 7;
            this.label_Check_ID.Text = "Vui Lòng nhập ID";
            // 
            // textBox_ID_Xe
            // 
            this.textBox_ID_Xe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID_Xe.Location = new System.Drawing.Point(84, 20);
            this.textBox_ID_Xe.Name = "textBox_ID_Xe";
            this.textBox_ID_Xe.Size = new System.Drawing.Size(178, 30);
            this.textBox_ID_Xe.TabIndex = 6;
            this.textBox_ID_Xe.TextChanged += new System.EventHandler(this.textBox_ID_Xe_TextChanged);
            this.textBox_ID_Xe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_Xe_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID:";
            // 
            // label_Chon_Loai_Xe
            // 
            this.label_Chon_Loai_Xe.AutoSize = true;
            this.label_Chon_Loai_Xe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Chon_Loai_Xe.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Chon_Loai_Xe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Chon_Loai_Xe.Location = new System.Drawing.Point(411, 54);
            this.label_Chon_Loai_Xe.Name = "label_Chon_Loai_Xe";
            this.label_Chon_Loai_Xe.Size = new System.Drawing.Size(137, 15);
            this.label_Chon_Loai_Xe.TabIndex = 4;
            this.label_Chon_Loai_Xe.Text = "Vui Lòng chọn loại xe";
            // 
            // textBox_So_Bien
            // 
            this.textBox_So_Bien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_So_Bien.Location = new System.Drawing.Point(694, 20);
            this.textBox_So_Bien.Name = "textBox_So_Bien";
            this.textBox_So_Bien.Size = new System.Drawing.Size(250, 30);
            this.textBox_So_Bien.TabIndex = 3;
            this.textBox_So_Bien.TextChanged += new System.EventHandler(this.textBox_So_Bien_TextChanged);
            // 
            // comboBox_Loai_Xe
            // 
            this.comboBox_Loai_Xe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Loai_Xe.FormattingEnabled = true;
            this.comboBox_Loai_Xe.Location = new System.Drawing.Point(380, 20);
            this.comboBox_Loai_Xe.Name = "comboBox_Loai_Xe";
            this.comboBox_Loai_Xe.Size = new System.Drawing.Size(200, 31);
            this.comboBox_Loai_Xe.TabIndex = 2;
            this.comboBox_Loai_Xe.TextChanged += new System.EventHandler(this.comboBox_Loai_Xe_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số biển:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại xe:";
            // 
            // panel_Hinh
            // 
            this.panel_Hinh.Controls.Add(this.comboBox_Tinh_Trang);
            this.panel_Hinh.Controls.Add(this.label5);
            this.panel_Hinh.Controls.Add(this.button_Xoa);
            this.panel_Hinh.Controls.Add(this.label_Check_Anh);
            this.panel_Hinh.Controls.Add(this.button_Upload_Pic);
            this.panel_Hinh.Controls.Add(this.label_hinh);
            this.panel_Hinh.Controls.Add(this.button_Cap_Nhat);
            this.panel_Hinh.Controls.Add(this.pictureBox);
            this.panel_Hinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Hinh.Location = new System.Drawing.Point(0, 151);
            this.panel_Hinh.Name = "panel_Hinh";
            this.panel_Hinh.Size = new System.Drawing.Size(1014, 430);
            this.panel_Hinh.TabIndex = 4;
            // 
            // comboBox_Tinh_Trang
            // 
            this.comboBox_Tinh_Trang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Tinh_Trang.FormattingEnabled = true;
            this.comboBox_Tinh_Trang.Location = new System.Drawing.Point(161, 62);
            this.comboBox_Tinh_Trang.Name = "comboBox_Tinh_Trang";
            this.comboBox_Tinh_Trang.Size = new System.Drawing.Size(200, 31);
            this.comboBox_Tinh_Trang.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tình trạng:";
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.Red;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(183, 313);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(140, 48);
            this.button_Xoa.TabIndex = 14;
            this.button_Xoa.Text = "Xóa xe";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // label_Check_Anh
            // 
            this.label_Check_Anh.AutoSize = true;
            this.label_Check_Anh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Check_Anh.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Check_Anh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Check_Anh.Location = new System.Drawing.Point(561, 17);
            this.label_Check_Anh.Name = "label_Check_Anh";
            this.label_Check_Anh.Size = new System.Drawing.Size(122, 15);
            this.label_Check_Anh.TabIndex = 12;
            this.label_Check_Anh.Text = "Vui Lòng thêm ảnh";
            // 
            // button_Upload_Pic
            // 
            this.button_Upload_Pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Upload_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Upload_Pic.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Upload_Pic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_Upload_Pic.Location = new System.Drawing.Point(462, 386);
            this.button_Upload_Pic.Name = "button_Upload_Pic";
            this.button_Upload_Pic.Size = new System.Drawing.Size(350, 24);
            this.button_Upload_Pic.TabIndex = 11;
            this.button_Upload_Pic.Text = "Upload Pic";
            this.button_Upload_Pic.UseVisualStyleBackColor = true;
            this.button_Upload_Pic.Click += new System.EventHandler(this.button_Upload_Pic_Click);
            // 
            // label_hinh
            // 
            this.label_hinh.AutoSize = true;
            this.label_hinh.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_hinh.Location = new System.Drawing.Point(232, 156);
            this.label_hinh.Name = "label_hinh";
            this.label_hinh.Size = new System.Drawing.Size(53, 23);
            this.label_hinh.TabIndex = 4;
            this.label_hinh.Text = "Hình";
            // 
            // button_Cap_Nhat
            // 
            this.button_Cap_Nhat.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Cap_Nhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cap_Nhat.ForeColor = System.Drawing.Color.White;
            this.button_Cap_Nhat.Location = new System.Drawing.Point(183, 248);
            this.button_Cap_Nhat.Name = "button_Cap_Nhat";
            this.button_Cap_Nhat.Size = new System.Drawing.Size(140, 48);
            this.button_Cap_Nhat.TabIndex = 2;
            this.button_Cap_Nhat.Text = "Cập nhật";
            this.button_Cap_Nhat.UseVisualStyleBackColor = false;
            this.button_Cap_Nhat.Click += new System.EventHandler(this.button_Cap_Nhat_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(462, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 350);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Sua_Xoa_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 581);
            this.Controls.Add(this.panel_Hinh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sua_Xoa_Xe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sua_Xe";
            this.Load += new System.EventHandler(this.Sua_Xe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_Hinh.ResumeLayout(false);
            this.panel_Hinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Check_BS;
        private System.Windows.Forms.Label label_Check_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Chon_Loai_Xe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Hinh;
        private System.Windows.Forms.Label label_Check_Anh;
        private System.Windows.Forms.Button button_Upload_Pic;
        private System.Windows.Forms.Label label_hinh;
        private System.Windows.Forms.Button button_Cap_Nhat;
        private System.Windows.Forms.Button button_Chon_Xe;
        private System.Windows.Forms.RadioButton radioButton_Chon;
        private System.Windows.Forms.RadioButton radioButton_Nhap_Tay;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBox_ID_Xe;
        internal System.Windows.Forms.PictureBox pictureBox;
        internal System.Windows.Forms.TextBox textBox_So_Bien;
        internal System.Windows.Forms.ComboBox comboBox_Loai_Xe;
        internal System.Windows.Forms.ComboBox comboBox_Tinh_Trang;
    }
}