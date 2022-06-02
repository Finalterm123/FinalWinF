using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe.Cong_Viec
{
    public partial class Them_Cong_Viec : Form
    {
        public Them_Cong_Viec()
        {
            InitializeComponent();
        }
        QL_Xe mydb = new QL_Xe();
        Cong_Viec congviec = new Cong_Viec();

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            if(textBox_ID.Text != "")
            {
                int id = Convert.ToInt32(textBox_ID.Text);
                if (congviec.checkExistID(id) == true)
                {
                    label_Check_ID.Text = "Hợp lệ";
                    label_Check_ID.ForeColor = Color.Lime;
                    label_Check_ID.BackColor = Color.White;

                }
                else
                {
                    label_Check_ID.Text = "Trùng ID!!";
                    label_Check_ID.ForeColor = Color.Red;
                    label_Check_ID.BackColor = Color.White;

                }
            }
            else
            {
                label_Check_ID.Text = "Không được bỏ trống ID!!";
                label_Check_ID.ForeColor = Color.Red;
                label_Check_ID.BackColor = Color.White;
            }    
        }

        private void Them_Cong_Viec_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Ten_CV_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Ten_CV.Text != "")
            {
                string name = textBox_Ten_CV.Text;
                if (congviec.checkExistName(name) == true)
                {
                    label_Check_Ten.Text = "Hợp lệ";
                    label_Check_Ten.ForeColor = Color.Lime;
                    label_Check_Ten.BackColor = Color.White;

                }
                else
                {
                    label_Check_Ten.Text = "Trùng ID!!";
                    label_Check_Ten.ForeColor = Color.Red;
                    label_Check_Ten.BackColor = Color.White;

                }
            }
            else
            {
                label_Check_Ten.Text = "Không được bỏ trống tên!!";
                label_Check_Ten.ForeColor = Color.Red;
                label_Check_Ten.BackColor = Color.White;
            } 
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if(textBox_ID.Text != "" && textBox_Ten_CV.Text != "")
            {
                string name = textBox_Ten_CV.Text;
                int id = Convert.ToInt32(textBox_ID.Text);
                string Mo_Ta = textBox_Mo_Ta.Text;
                if (congviec.checkExistName(name) == true && congviec.checkExistID(id) == true)
                {
                    if(congviec.insertCV(id, name, Mo_Ta))
                    {
                        MessageBox.Show("Công việc mới đã được thêm!!", "Thêm công việc!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm công việc mới!!", "Thêm công việc!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể thêm công việc mới!!", "Thêm công việc!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống ID và tên công việc!!", "Thêm công việc!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
