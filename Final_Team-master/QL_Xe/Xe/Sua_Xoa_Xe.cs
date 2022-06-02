using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe.Xe
{
    public partial class Sua_Xoa_Xe : Form
    {
        public Sua_Xoa_Xe()
        {
            InitializeComponent();
        }
        QL_Xe mydb = new QL_Xe();
        Xe xe = new Xe();
        private void Sua_Xe_Load(object sender, EventArgs e)
        {
            radioButton_Chon.Checked = true;
            comboBox_Loai_Xe.DisplayMember = "Text";
            comboBox_Loai_Xe.ValueMember = "Value";

            comboBox_Loai_Xe.Items.Add(new { Text = "Xe Đạp" });
            comboBox_Loai_Xe.Items.Add(new { Text = "Xe Máy" });
            comboBox_Loai_Xe.Items.Add(new { Text = "Ô Tô" });

            comboBox_Tinh_Trang.DisplayMember = "Text";
            comboBox_Tinh_Trang.ValueMember = "Value";
            comboBox_Tinh_Trang.Items.Add(new { Text = "Đang gửi" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Đã trả" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Công ty đang thuê" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Khách hàng đang thuê" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Sẵn sàng cho thuê" });
        }

        private void comboBox_Loai_Xe_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_Loai_Xe.Text == "")
            {
                label_Chon_Loai_Xe.Text = "Vui lòng chọn loại xe";
                label_Chon_Loai_Xe.ForeColor = Color.FromArgb(255, 128, 0); ;
            }
            else if (comboBox_Loai_Xe.Text.Trim() == "Xe Đạp")
            {
                panel_Hinh.Visible = true;
                label_Chon_Loai_Xe.Text = "Loại xe hợp lệ";
                label_Chon_Loai_Xe.ForeColor = Color.Lime;
                label_hinh.Text = "Hình xe đạp:";
                label_Check_BS.Text = "Xe đạp không cần biển số";
                textBox_So_Bien.Text = "";
                textBox_So_Bien.ReadOnly = true;
            }
            else if (comboBox_Loai_Xe.Text.Trim() == "Xe Máy" || comboBox_Loai_Xe.Text.Trim() == "Ô Tô")
            {
                panel_Hinh.Visible = true;
                label_Chon_Loai_Xe.Text = "Loại xe hợp lệ";
                label_Chon_Loai_Xe.ForeColor = Color.Lime;
                label_hinh.Text = "Hình Biển số:";
                if(textBox_So_Bien.Text == "")
                {
                    label_Check_BS.Text = "Vui Lòng nhập số biển";
                }
                label2.Visible = true;
                textBox_So_Bien.Visible = true;
                label_Check_BS.Visible = true;
                textBox_So_Bien.ReadOnly = false;
            }
            else
            {
                label_Chon_Loai_Xe.Text = "Loại xe không phù hợp";
                label_Chon_Loai_Xe.ForeColor = Color.Red;
                panel_Hinh.Visible = false;
            }
        }

        private void button_Cap_Nhat_Click(object sender, EventArgs e)
        {
            if (comboBox_Loai_Xe.Text == "Xe Đạp")
            {
                if (textBox_ID_Xe.Text == "" || comboBox_Loai_Xe.Text == "" || pictureBox.Image == null)
                {
                    MessageBox.Show("Xe đạp chỉ được bỏ trống biển số!!!");
                    return;
                }
            }
            else if (comboBox_Loai_Xe.Text == "Xe Máy" || comboBox_Loai_Xe.Text == "Ô Tô")
            {
                if (textBox_ID_Xe.Text == "" || comboBox_Loai_Xe.Text == "" || textBox_So_Bien.Text == "" || pictureBox.Image == null)
                {
                    MessageBox.Show("Không được bỏ trống!!!");
                    return;
                }
            }
            int ID_Xe = Convert.ToInt32(textBox_ID_Xe.Text.ToString());
            string So_Bien_So = textBox_So_Bien.Text;
            string Loai_Xe = comboBox_Loai_Xe.Text;
            string Tinh_trang = comboBox_Tinh_Trang.Text;
            MemoryStream Hinh = new MemoryStream();
            pictureBox.Image.Save(Hinh, pictureBox.Image.RawFormat);
            if(label_Check_ID.Text == "Có ID xe này" && check_Tinh_Trang()==true)
            {
                if(label_Check_BS.Text == "Chưa tồn tại" || comboBox_Loai_Xe.Text == "Xe Đạp")
                {
                    if (xe.updateXebyID(ID_Xe, So_Bien_So, Loai_Xe, Hinh, Tinh_trang))
                    {
                        MessageBox.Show("Đã cập nhật lại xe!!", "Cập nhật Xe!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể Cập nhật xe (theo ID)!!", "Cập nhật xe!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if(label_Check_BS.Text == "Đã tồn tại")
                {
                    if (xe.updateXebyIDnBS(ID_Xe, So_Bien_So, Loai_Xe, Hinh, Tinh_trang))
                    {
                        MessageBox.Show("Đã cập nhật lại xe!!", "Cập nhật Xe!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Biển số này đã có ở 1 xe khác!!", "Cập nhật xe!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai!!", "Cập nhật xe!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_ID_Xe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_ID_Xe_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (textBox_ID_Xe.Text != "")
            {
                int ID_Xe = Convert.ToInt32(textBox_ID_Xe.Text.ToString());
                cmd = new SqlCommand("SELECT *  FROM Xe where ID_Xe = @ID_Xe", mydb.getConnection);
                cmd.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    label_Check_ID.Show();
                    label_Check_ID.Text = "Có ID xe này";
                    label_Check_ID.ForeColor = Color.Lime;
                    return;
                }
                else
                {
                    label_Check_ID.Show();
                    label_Check_ID.Text = "Không tìm thấy ID";
                    label_Check_ID.ForeColor = Color.Red;
                }
            }
            if (textBox_ID_Xe.Text == "")
            {
                label_Check_ID.Show();
                label_Check_ID.Text = "Vui Lòng nhập ID";
                label_Check_ID.ForeColor = Color.FromArgb(255, 128, 0);
            }
        }

        private void textBox_So_Bien_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (textBox_So_Bien.Text != "")
            {

                string So_Bien_So = textBox_So_Bien.Text.ToString().Trim();
                cmd = new SqlCommand("SELECT *  FROM Xe where So_Bien_So like '" + @So_Bien_So + "'", mydb.getConnection);
                cmd.Parameters.Add("@So_Bien_So", SqlDbType.VarChar).Value = So_Bien_So;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    label_Check_BS.Show();
                    label_Check_BS.Text = "Đã tồn tại";
                    label_Check_BS.ForeColor = Color.YellowGreen;
                    return;
                }
                else
                {
                    label_Check_BS.Show();
                    label_Check_BS.Text = "Chưa tồn tại";
                    label_Check_BS.ForeColor = Color.Lime;
                }
                
            }
            if (textBox_So_Bien.Text == "")
            {
                label_Check_BS.Show();
                label_Check_BS.Text = "Vui Lòng nhập số biển";
                label_Check_BS.ForeColor = Color.FromArgb(255, 128, 0); ;
            }
        }


        private void button_Upload_Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
                label_Check_Anh.Text = "Hợp lệ";
                label_Check_Anh.ForeColor = Color.Lime;
            }
        }

        private void radioButton_Chon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Chon.Checked == true)
            {
                button_Chon_Xe.Visible = true;
                textBox_ID_Xe.ReadOnly = true;
            }
        }

        private void radioButton_Nhap_Tay_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Nhap_Tay.Checked == true)
            {
                button_Chon_Xe.Visible = false;
                textBox_ID_Xe.ReadOnly = false;

            }
        }

        private void button_Chon_Xe_Click(object sender, EventArgs e)
        {
            DS_Xe_Tim_Kiem chon_Xe = new DS_Xe_Tim_Kiem();
            chon_Xe.Show();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Xe = Convert.ToInt32(textBox_ID_Xe.Text);

                if (MessageBox.Show("Bạn có chắc muốn xóa xe này chứ ?", "Xóa xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (xe.deleteXe(ID_Xe))
                    {
                        MessageBox.Show("Đã xóa xe", "Xóa xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_ID_Xe.Text = "";
                        textBox_So_Bien.Text = "";
                        comboBox_Loai_Xe.Text = "";
                        pictureBox.Image = null;
                        button_Xoa.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa!!", "Xóa xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("ID không chính xác", "Xóa xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool check_Tinh_Trang()
        {
            if (comboBox_Tinh_Trang.Text == "Đang gửi"
                || comboBox_Tinh_Trang.Text == "Đã trả"
                || comboBox_Tinh_Trang.Text == "Công ty đang thuê"
                || comboBox_Tinh_Trang.Text == "Khách hàng đang thuê"
                || comboBox_Tinh_Trang.Text == "Sẵn sàng cho thuê"
                || comboBox_Tinh_Trang.Text == ""
                )
                return true;
            else
                return false;
        }
    }
}
