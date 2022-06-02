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
    public partial class Them_Xe : Form
    {
        public Them_Xe()
        {
            InitializeComponent();
        }
        QL_Xe mydb = new QL_Xe();
        Xe xe = new Xe();
        private void Them_Xe_Load(object sender, EventArgs e)
        {
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
            comboBox_Tinh_Trang.Items.Add(new { Text = "Chưa xác định" });

            panel_Hinh.Visible = false;
        }

        private void comboBox_Loai_Xe_TextChanged(object sender, EventArgs e)
        {
            if(comboBox_Loai_Xe.Text == "")
            {
                label_Chon_Loai_Xe.Text = "Vui lòng chọn loại xe";
                label_Chon_Loai_Xe.ForeColor = Color.FromArgb(255, 128, 0); ;
            }    
            else if(comboBox_Loai_Xe.Text.Trim() == "Xe Đạp")
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
                label_Check_BS.Text = "Vui Lòng nhập số biển";
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

        private void button_Them_Click(object sender, EventArgs e)
        {
            if(comboBox_Loai_Xe.Text == "Xe Đạp")
            {
                if (textBox_ID_Xe.Text == "" || comboBox_Loai_Xe.Text == "" || pictureBox.Image == null)
                {
                    MessageBox.Show("Xe đạp chỉ được bỏ trống biển số!!!");
                    return;
                }
            }
            else if(comboBox_Loai_Xe.Text == "Xe Máy" || comboBox_Loai_Xe.Text == "Ô Tô")
            {
                if (textBox_ID_Xe.Text == "" || comboBox_Loai_Xe.Text == "" || textBox_So_Bien.Text == "" || pictureBox.Image == null)
                {
                    MessageBox.Show("Không được bỏ trống!!!");
                    return;
                }
            }
            if (check_Tinh_Trang() == false)
            {
                MessageBox.Show("Tinh trạng xe sai!! Có thể bỏ trống");
                return;
            }
            int ID_Xe = Convert.ToInt32(textBox_ID_Xe.Text.ToString());
            string So_Bien_So = textBox_So_Bien.Text;
            string Loai_Xe = comboBox_Loai_Xe.Text;
            MemoryStream Hinh = new MemoryStream();
            string Tinh_trang = comboBox_Tinh_Trang.Text;
            pictureBox.Image.Save(Hinh, pictureBox.Image.RawFormat);
            //check if the score is already set for this student on this score
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("SELECT *  FROM Xe where ID_Xe = @ID_Xe", mydb.getConnection);
            cmd.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                if (xe.insertXe(ID_Xe, So_Bien_So, Loai_Xe, Hinh, Tinh_trang))
                {
                    MessageBox.Show("Xe mới đã được thêm!!", "Thêm Xe!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm xe mới!!", "Thêm xe!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm xe mới!!", "Thêm xe!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    label_Check_ID.Text = "Trùng ID";
                    label_Check_ID.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    label_Check_ID.Show();
                    label_Check_ID.Text = "ID Hợp lệ";
                    label_Check_ID.ForeColor = Color.Lime;
                }
            }
            if(textBox_ID_Xe.Text == "")
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
                    label_Check_BS.Text = "Trùng biển số";
                    label_Check_BS.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    label_Check_BS.Show();
                    label_Check_BS.Text = "Hợp lệ";
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
        public bool check_Tinh_Trang()
        {
            if (comboBox_Tinh_Trang.Text == "Đang gửi"
                || comboBox_Tinh_Trang.Text == "Đã trả"
                || comboBox_Tinh_Trang.Text == "Công ty đang thuê"
                || comboBox_Tinh_Trang.Text == "Khách hàng đang thuê"
                || comboBox_Tinh_Trang.Text == "Sẵn sàng cho thuê"
                || comboBox_Tinh_Trang.Text == "Chưa xác định"
                )
                return true;
            else
                return false;
        }

        private void panel_Hinh_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
