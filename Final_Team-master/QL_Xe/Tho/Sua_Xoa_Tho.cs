using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Xe.Chuyen_Mon;
namespace QL_Xe.Tho
{
    public partial class Sua_Xoa_Tho : Form
    {
        public Sua_Xoa_Tho()
        {
            InitializeComponent();
        }
        QL_Xe mydb = new QL_Xe();
        Tho tho = new Tho();
        Cong_Viec.Cong_Viec Cong_Viec = new Cong_Viec.Cong_Viec();
        ChuyenMon chuyenMon = new ChuyenMon();
        private void radioButton_Chon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Chon.Checked == true)
            {
                button_Chon_Tho.Visible = true;
                textBox_ID.ReadOnly = true;
            }
        }

        private void radioButton_Nhap_Tay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Nhap_Tay.Checked == true)
            {
                button_Chon_Tho.Visible = false;
                textBox_ID.ReadOnly = false;
            }
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                if (textBox_SDT.Text != "")
                {
                    if (tho.checkExistIDnSDT(Convert.ToInt32(textBox_ID.Text), textBox_SDT.Text) != true)
                    {
                        label_Check_ID.Show();
                        label_Check_ID.Text = "Được";
                        label_Check_ID.ForeColor = Color.Orange;
                    }
                    else if (tho.checkExistID(Convert.ToInt32(textBox_ID.Text)) != true)
                    {
                        label_Check_ID.Show();
                        label_Check_ID.Text = "Trùng ID";
                        label_Check_ID.ForeColor = Color.Red;
                    }
                    else
                    {
                        label_Check_ID.Show();
                        label_Check_ID.Text = "Tốt";
                        label_Check_ID.ForeColor = Color.Lime;
                    }
                }
            }
            else if (textBox_ID.Text == "")
            {
                label_Check_ID.Visible = false;
            }
        }

        private void textBox_SDT_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SDT.Text != "")
            {
                if (textBox_ID.Text != "")
                {
                    if (tho.checkExistIDnSDT(Convert.ToInt32(textBox_ID.Text), textBox_SDT.Text) != true)
                    {
                        label_check_Phone.Show();
                        label_check_Phone.Text = "Được";
                        label_check_Phone.ForeColor = Color.Orange;
                    }
                    else if (tho.checkExistSDT(textBox_SDT.Text) != true)
                    {
                        label_check_Phone.Show();
                        label_check_Phone.Text = "Trùng SDT";
                        label_check_Phone.ForeColor = Color.Red;
                    }
                    else
                    {
                        label_check_Phone.Show();
                        label_check_Phone.Text = "Tốt";
                        label_check_Phone.ForeColor = Color.Lime;
                    }
                }
            }
            else if (textBox_SDT.Text == "")
            {
                label_check_Phone.Visible = false;
            }
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Sua_Xoa_Tho_Load(object sender, EventArgs e)
        {
            radioButton_Chon.Checked = true;
            label_check_Phone.Visible = false;
            label_Check_ID.Visible = false;

            comboBox_CM.DataSource = chuyenMon.getAllCM();
            comboBox_CM.DisplayMember = "Ten_CM";
            comboBox_CM.ValueMember = "ID_CM";
        }

        private void button_Chon_Tho_Click(object sender, EventArgs e)
        {
            DS_Tim_Tho dS_Tim_Tho = new DS_Tim_Tho();
            this.Close();
            dS_Tim_Tho.Show();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if(verif()==false)
            {
                MessageBox.Show("Không được để trống!!", "Cập nhật thợ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int userID = Convert.ToInt32(textBox_ID.Text);
            string Ten_Tho = textBox_Tho.Text;
            DateTime NgSinh = dateTimePicker1.Value;
            string Phone = textBox_SDT.Text;
            MemoryStream Anh = new MemoryStream();
            pictureBox.Image.Save(Anh, pictureBox.Image.RawFormat);
            int ID_CM = Convert.ToInt32(comboBox_CM.SelectedValue);
            string Gioi_Tinh = "Nam";
            if (radioButton_Nu.Checked)
            {
                Gioi_Tinh = "Nữ";
            }
            if (ID_CM == 0)
            {
                MessageBox.Show("Không có chuyên môn này!!", "Thêm chuyên môn này trước", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tho.checkExistID(userID) == false)
            {
                if(tho.checkExistSDT(Phone) == true)
                {
                    if(tho.updateThobyID(userID, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, ID_CM))
                    {
                        MessageBox.Show("Đã cập nhật lại thợ!!", "Cập nhật thợ!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể Cập nhật thợ (theo ID)!!", "Cập nhật thợ!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }  
                }
                else
                {
                    if (tho.updateThobyIDnSDT(userID, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, ID_CM))
                    {
                        MessageBox.Show("Đã cập nhật lại thợ!!", "Cập nhật thợ!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("SDT này đã có ở 1 thợ khác!!", "Cập nhật thợ!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Tho = Convert.ToInt32(textBox_ID.Text);

                if (MessageBox.Show("Bạn có chắc muốn xóa thợ có ID này chứ ?", "Xóa thợ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tho.deleteTho(ID_Tho))
                    {
                        MessageBox.Show("Đã xóa thợ", "Xóa thợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_ID.Text = "";
                        textBox_Tho.Text = "";
                        textBox_SDT.Text = "";
                        comboBox_CM.Text = "";
                        pictureBox.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa!!", "Xóa thợ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("ID không chính xác", "Xóa thợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }
        public bool verif()
        {
            if (textBox_ID.Text == ""
                || textBox_Tho.Text == ""
                || textBox_SDT.Text == ""
                || pictureBox.Image == null
                )
                return false;
            else
                return true;
        }
    }
}
