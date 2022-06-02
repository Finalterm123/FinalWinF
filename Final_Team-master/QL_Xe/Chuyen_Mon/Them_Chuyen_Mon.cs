using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe.Chuyen_Mon
{
    public partial class Them_Chuyen_Mon : Form
    {
        public Them_Chuyen_Mon()
        {
            InitializeComponent();
        }
        QL_Xe mydb = new QL_Xe();
        ChuyenMon chuyenMon = new ChuyenMon();
        Cong_Viec.Cong_Viec Cong_Viec = new Cong_Viec.Cong_Viec();
        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "")
            {
                int id = Convert.ToInt32(textBox_ID.Text);
                if (chuyenMon.checkExistID(id) == true)
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

        private void textBox_Ten_CM_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Ten_CM.Text != "")
            {
                string name = textBox_Ten_CM.Text;
                if (chuyenMon.checkExistName(name) == true)
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
            if (textBox_ID.Text != "" && textBox_Ten_CM.Text != "")
            {
                string name = textBox_Ten_CM.Text;
                int id = Convert.ToInt32(textBox_ID.Text);
                int ID_CV = Convert.ToInt32(comboBox_CV.SelectedValue);
                string Loai_xe = comboBox_Loaixe.Text;
                string Mo_Ta = textBox_Mo_Ta.Text;
                if(ID_CV ==0)
                {
                    MessageBox.Show("Tên công việc sai!!", "Thêm chuyên môn!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chuyenMon.checkExistName(name) == true && chuyenMon.checkExistID(id) == true)
                {
                    if (chuyenMon.insertCM(id, name, ID_CV,Loai_xe, Mo_Ta))
                    {
                        MessageBox.Show("Chuyên môn mới đã được thêm!!", "Thêm Chuyên môn!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm chuyên môn mới!!", "Thêm chuyên môn!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể thêm chuyên môn mới!!", "Thêm chuyên môn!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống ID và tên chuyên môn!!", "Thêm chuyên môn!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Them_Chuyen_Mon_Load(object sender, EventArgs e)
        {
            comboBox_CV.DataSource = Cong_Viec.getAllCV();
            comboBox_CV.DisplayMember = "Ten_CV";
            comboBox_CV.ValueMember = "ID_CV";

            comboBox_Loaixe.DisplayMember = "Text";
            comboBox_Loaixe.ValueMember = "Value";

            comboBox_Loaixe.Items.Add(new { Text = "Xe Đạp" });
            comboBox_Loaixe.Items.Add(new { Text = "Xe Máy" });
            comboBox_Loaixe.Items.Add(new { Text = "Xe Hơi" });

        }
    }
}
