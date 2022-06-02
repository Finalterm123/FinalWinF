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
using QL_Xe.Account_Tho;
using QL_Xe.Tho;
namespace QL_Xe
{
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }
        Tho.Tho tho = new Tho.Tho();
        Tho_Login login = new Tho_Login(); 
        public void fillGrid(SqlCommand command)
        {
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 80;
            dataGridView.DataSource = tho.selectThoList(command);
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowHeadersVisible = false;
/*            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;*/
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho from tho " +
                "inner join Chuyen_Mon on Tho.ID_CM = Chuyen_Mon.ID_CM " +
                "inner join Cong_Viec on Chuyen_Mon.ID_CV = Cong_Viec.ID_CV " +
                "where Cong_Viec.Ten_CV = N'Trông Coi Xe' and ConCat(ID_Tho, Ten_Tho) like N'%" + textBox_Search.Text + "%'");
            fillGrid(command);
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                label_ID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                label_Ten.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
            
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho from tho " +
                "inner join Chuyen_Mon on Tho.ID_CM = Chuyen_Mon.ID_CM " +
                "inner join Cong_Viec on Chuyen_Mon.ID_CV = Cong_Viec.ID_CV " +
                "where Cong_Viec.Ten_CV = N'Trông Coi Xe'" );
            fillGrid(command);

            label_Check_ID.Visible = false;
            label_Check_Acc_name.Visible = false;
            label_Check_Email.Visible = false;
        }

        private void textBox_Ten_Dang_Nhap_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Ten_Dang_Nhap.Text != "")
            {
                string AccName = textBox_Ten_Dang_Nhap.Text;
                if (login.checkExistAccName(AccName) != true)
                {
                    label_Check_Acc_name.Visible = true;

                }
                else
                {
                    label_Check_Acc_name.Visible = false;
                }
            }
            else
            {
                label_Check_Acc_name.Visible = false;
            }
        }

        private void label_ID_TextChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(label_ID.Text);
            if (login.checkExistID(ID) != true)
            {
                label_Check_ID.Visible = true;

            }
            else
            {
                label_Check_ID.Visible = false;
            }
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Email.Text != "")
            {
                string Email = textBox_Email.Text;
                if (login.checkExistEmail(Email) != true)
                {
                    label_Check_Email.Visible = true;

                }
                else
                {
                    label_Check_Email.Visible = false;
                }
            }
            else
            {
                label_Check_Email.Visible = false;
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    if(label_ID.Text == "Trống")
                    {
                        MessageBox.Show("Vui lòng chọn thợ trước!!");
                        return;
                    }
                    int ID_Tho = Convert.ToInt32(label_ID.Text);
                    if(login.checkExistID(ID_Tho) != true)
                    {
                        MessageBox.Show("Thợ này đã có tài khoản rồi!!", "Thêm tài khoản!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    string Ten_Dang_Nhap = textBox_Ten_Dang_Nhap.Text;
                    if (login.checkExistAccName(Ten_Dang_Nhap) != true)
                    {
                        MessageBox.Show("Có tên tài khoản này rồi!!", "Thêm tài khoản!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string Mat_Khau = textBox_Mat_Khau.Text;
                    string Email = textBox_Email.Text;
                    if (login.checkExistEmail(Email) != true)
                    {
                        MessageBox.Show("Có Email này rồi!!", "Thêm tài khoản!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (login.insertAcc(ID_Tho, Ten_Dang_Nhap, Mat_Khau, Email))
                    {
                        MessageBox.Show("Tài khoản cho nhóm thợ trông xe đã được tạo!!", "Thêm tài khoản!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo tài khoản!!", "Thêm tài khoản!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Không được bỏ trống!!", "Thêm tài khoản!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm tài khoản!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool verif()
        {
            if ((textBox_Ten_Dang_Nhap.Text.Trim() == "")
                    || (textBox_Mat_Khau.Text.Trim() == "")
                    || (textBox_Email.Text.Trim() == "")
                    )
            {
                return false;
            }
            else return true;
        }
    }
}
