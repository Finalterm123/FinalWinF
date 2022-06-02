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
using QL_Xe.Cong_Viec;
namespace QL_Xe.Tho
{
    public partial class Them_Tho : Form
    {
        public Them_Tho()
        {
            InitializeComponent();
        }
        Tho tho = new Tho();
        Cong_Viec.Cong_Viec Cong_Viec = new Cong_Viec.Cong_Viec();
        ChuyenMon chuyenMon = new ChuyenMon();
        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            if(textBox_ID.Text != "")
            {
                if (tho.checkExistID(Convert.ToInt32(textBox_ID.Text)) == true){
                    label_Check_ID.Visible = false;
                }
                else
                {
                    label_Check_ID.Visible = true;
                }
            }
            else
            {
                label_Check_ID.Visible = false;
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

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if(verif())
                {
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
                    if(ID_CM == 0)
                    {
                        MessageBox.Show("Không có chuyên môn này!!", "Thêm chuyên môn này trước", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (tho.checkExistID(userID) == true && tho.checkExistSDT(Phone) ==true)
                    {
                        if ((tho.insertTho(userID, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, ID_CM)))
                        {
                            MessageBox.Show("Đã thêm thợ mới!!", "Thêm thợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm thợ!!", "Thêm thợ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm thợ!!", "Thêm thợ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Không được bỏ trống!!", "Thêm thợ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void Them_Tho_Load(object sender, EventArgs e)
        {
            label_check_Phone.Visible = false;
            label_Check_ID.Visible = false;
            radioButton_Nam.Checked = true;
            comboBox_CM.DataSource = chuyenMon.getAllCM();
            comboBox_CM.DisplayMember = "Ten_CM";
            comboBox_CM.ValueMember = "ID_CM";
        }
        private bool verif()
        {
            if ((textBox_ID.Text.Trim() == "")
                    || (textBox_Tho.Text.Trim() == "")
                    || (textBox_SDT.Text.Trim() == "")
                    || (comboBox_CM.Text.Trim() == "")
                    || (pictureBox.Image == null)
                    )
            {
                return false;
            }
            else return true;
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

        private void textBox_SDT_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SDT.Text != "")
            {
                if (tho.checkExistSDT(textBox_SDT.Text) == true)
                {
                    label_check_Phone.Visible = false;
                }
                else
                {
                    label_check_Phone.Visible = true;
                }
            }
            else
            {
                label_check_Phone.Visible = false;
            }
        }
    }
}
