using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe.Cong_Viec
{
    public partial class Sua_Xoa_CV : Form
    {
        public Sua_Xoa_CV()
        {
            InitializeComponent();
        }
        QL_Xe mydb = new QL_Xe();
        Cong_Viec Cong_Viec = new Cong_Viec();
        private void radioButton_Chon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Chon.Checked == true)
            {
                button_Chon_CV.Visible = true;
                textBox_ID.ReadOnly = true;
            }
        }

        private void radioButton_Nhap_Tay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Nhap_Tay.Checked == true)
            {
                button_Chon_CV.Visible = false;
                textBox_ID.ReadOnly = false;
            }
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                if (textBox_Ten_CV.Text != "")
                {
                    if (Cong_Viec.checkExistIDnName(Convert.ToInt32(textBox_ID.Text), textBox_Ten_CV.Text)!= true){
                        label_Check_ID.Show();
                        label_Check_ID.Text = "ID có sẵn của công việc này";
                        label_Check_ID.ForeColor = Color.Orange;
                    }
                    else if (Cong_Viec.checkExistID(Convert.ToInt32(textBox_ID.Text)) != true)
                    {
                        label_Check_ID.Show();
                        label_Check_ID.Text = "Có ID công việc này rồi";
                        label_Check_ID.ForeColor = Color.Red;
                    }
                    else
                    {
                        label_Check_ID.Show();
                        label_Check_ID.Text = "Hợp lý";
                        label_Check_ID.ForeColor = Color.Lime;
                    }
                }
            }
            else if (textBox_ID.Text == "")
            {
                label_Check_ID.Show();
                label_Check_ID.Text = "Không được bỏ trống ID!!";
            }
        }

        private void Sua_Xoa_CV_Load(object sender, EventArgs e)
        {
            radioButton_Chon.Checked = true;
            label_Check_Name.Visible = false;
            label_Check_ID.Visible = false;
        }

        private void textBox_Ten_CV_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Ten_CV.Text != "")
            {
                if (Cong_Viec.checkExistIDnName(Convert.ToInt32(textBox_ID.Text.Trim()), textBox_Ten_CV.Text.Trim()) != true)
                {
                    label_Check_Name.Show();
                    label_Check_Name.Text = "Tên công việc có sẵn của ID này";
                    label_Check_Name.ForeColor = Color.Orange;
                }
                else if (Cong_Viec.checkExistName(textBox_Ten_CV.Text.Trim()) != true)
                {
                    label_Check_Name.Show();
                    label_Check_Name.Text = "Có tên công việc này rồi";
                    label_Check_Name.ForeColor = Color.Red;
                }
                else
                {
                    label_Check_Name.Show();
                    label_Check_Name.Text = "Hợp lý";
                    label_Check_Name.ForeColor = Color.Lime;
                
                }    
            }
            else if (textBox_Ten_CV.Text == "")
            {
                label_Check_Name.Show();
                label_Check_Name.Text = "Không được bỏ trống tên!!";
            }
        }

        private void button_Chon_CV_Click(object sender, EventArgs e)
        {
            this.Close();
            DS_Tim_CV dS_Tim_CV = new DS_Tim_CV();
            dS_Tim_CV.Show();
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_CV= Convert.ToInt32(textBox_ID.Text);

                if (MessageBox.Show("Bạn có chắc muốn xóa công việc có ID này chứ ?", "Xóa công việc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Cong_Viec.deleteCV(ID_CV))
                    {
                        MessageBox.Show("Đã xóa công việc", "Xóa công việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_ID.Text = "";
                        textBox_Ten_CV.Text = "";
                        textBox_Mo_Ta.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa!!", "Xóa công việc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("ID không chính xác", "Xóa công việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Cap_Nhat_Click(object sender, EventArgs e)
        {
            if(textBox_ID.Text != "" && textBox_Ten_CV.Text != "")
            {
                int ID_CV = Convert.ToInt32(textBox_ID.Text);
                string Ten_CV = Convert.ToString(textBox_Ten_CV.Text);
                string Mo_Ta = textBox_Mo_Ta.Text;
                if (Cong_Viec.updateCVbyIDnName(ID_CV, Ten_CV, Mo_Ta))
                {
                    MessageBox.Show("Đã cập nhật lại công việc!!", "Cập nhật công việc!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (Cong_Viec.updateCVbyID(ID_CV, Ten_CV, Mo_Ta))
                {
                    MessageBox.Show("Đã cập nhật lại công việc!!", "Cập nhật công việc!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Không thể Cập nhật công việc !!", "Cập nhật công việc!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }
    }
}
