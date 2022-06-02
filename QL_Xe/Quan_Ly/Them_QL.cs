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

namespace QL_Xe.Quan_Ly
{
    public partial class Them_QL : Form
    {
        public Them_QL()
        {
            InitializeComponent();
        }
        QL_Xe mydb = new QL_Xe();

        Quan_Ly Quan_Ly = new Quan_Ly();
        private void textBox_ID_QL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                
                string Gioi_Tinh;
                if (radioButton_Nam.Checked == true)
                    Gioi_Tinh = "Nam";
                else
                    Gioi_Tinh = "Nữ";
                //check if the score is already set for this student on this score
                if (verif())
                {
                    int id_QL = Convert.ToInt32(textBox_ID_QL.Text);
                    string Ho_QL = textBox_Ho.Text;
                    string Ten_QL = textBox_Ten.Text;
                    string Ten_Dang_Nhap = textBox_Ten_Dang_Nhap.Text;
                    string Mat_Khau = textBox_Mat_Khau.Text;
                    string Email = textBox_Email.Text;
                    MemoryStream Anh = new MemoryStream();
                    pictureBox_Quan_Ly.Image.Save(Anh, pictureBox_Quan_Ly.Image.RawFormat);
                    if (Quan_Ly.insertQL(id_QL, Ho_QL, Ten_QL, Gioi_Tinh, Ten_Dang_Nhap, Mat_Khau, Email, Anh))
                    {
                        MessageBox.Show("Quản lý mới đã được thêm!!", "Thêm quản lý!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm quản lý mới!!", "Thêm quản lý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Không được bỏ trống!!", "Thêm quản lý!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm quản lý!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool verif()
        {
            if ((textBox_ID_QL.Text.Trim() == "")
                    || (textBox_Ho.Text.Trim() == "")
                    || (textBox_Ten.Text.Trim() == "")
                    || (textBox_Ten_Dang_Nhap.Text.Trim() == "")
                    || (textBox_Mat_Khau.Text.Trim() == "")
                    || (pictureBox_Quan_Ly.Image == null)
                    )
            {
                return false;
            }
            else return true;
        }

        private void Them_QL_Load(object sender, EventArgs e)
        {
            radioButton_Nam.Checked = true;
        }
        private void button_Upload_Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_Quan_Ly.Image = Image.FromFile(opf.FileName);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox_Mat_Khau.UseSystemPasswordChar == true)
            {
                textBox_Mat_Khau.UseSystemPasswordChar = false;
            }
            else if (textBox_Mat_Khau.UseSystemPasswordChar == false)
            {
                textBox_Mat_Khau.UseSystemPasswordChar = true;
            }
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (textBox_Email.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * From Quan_Ly WHERE Email=@Email", mydb.getConnection))
                    {
                        mydb.openConnection();

                        cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBox_Email.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Email của quản lý đã tồn tại!!, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBox_Email.Text = "";
                                return;
                            }
                        }
                        mydb.closeConnection();

                    }

                }
                if (textBox_ID_QL.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT id_QL From Quan_Ly WHERE id_QL=@id_QL", mydb.getConnection))
                    {
                        mydb.openConnection();

                        cmd.Parameters.Add("@id_QL", SqlDbType.Int).Value = textBox_ID_QL.Text;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("ID quản lý đã tồn tại!!, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBox_ID_QL.Text = "";
                                return;
                            }
                        }
                        mydb.closeConnection();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
