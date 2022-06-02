using QL_Xe.Quan_Ly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_Them_QL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Them_QL them_QL = new Them_QL();
            them_QL.Show();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            radioButton_Tho.Checked = true;
            label_Login_Wrong.Visible = false;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            QL_Xe db = new QL_Xe();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            try
            {
                if (radioButton_Quan_Ly.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Quan_Ly WHERE Ten_Dang_Nhap = @Ten_Dang_Nhap AND Mat_Khau = @Mat_Khau", db.getConnection);

                    command.Parameters.Add("@Ten_Dang_Nhap", SqlDbType.VarChar).Value = textBox_Username.Text;
                    command.Parameters.Add("@Mat_Khau", SqlDbType.VarChar).Value = textBox_Password.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if ((table.Rows.Count > 0))
                    {
                        int GlobalID = Convert.ToInt32(table.Rows[0][0].ToString());
                        Globals.SetGlobalsUserId(GlobalID);
                        string GlobaName = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
                        Globals.SetGlobalsUsername(GlobaName);
                        string GlobalRole = "Quản lý";
                        Globals.SetGlobalsUserRole(GlobalRole);

                        byte[] imgData = (byte[])table.Rows[0][6];
                        MemoryStream ms = new MemoryStream(imgData);
                        Globals.SetGlobalsUserImages(ms);
                        /*Image img = Image.FromStream(ms);
                        pictureBox1.Image = img;*/

                        progressBar1.Show();
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 100;
                        progressBar1.Step = 20;
                        for (int i = 0; i < 100; i += 5)
                        {
                            Thread.Sleep(30);
                            progressBar1.PerformStep();
                            progressBar1.Update();
                        }
                        //this.DialogResult = DialogResult.OK;
                        label_Login_Wrong.Text = "Chính xác";
                        label_Login_Wrong.ForeColor = Color.Lime;
                        label_Login_Wrong.Visible = true;
                        MainForm mainForm = new MainForm();
                        //mainForm.button_Trong_Coi_Xe.Visible = false;
                        mainForm.Show(this);
                    }
                    else
                    {
                        //MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Password.Text = "";
                        label_Login_Wrong.Text = "Tài khoản hoặc mật khẩu không đúng";
                        label_Login_Wrong.ForeColor = Color.Red;
                        label_Login_Wrong.Visible = true;
                    }
                }
                else if (radioButton_Tho.Checked == true)
                {
                    SqlCommand command = new SqlCommand("select * from Tho_Login inner join Tho on Tho_Login.ID_Tho = Tho.ID_Tho " +
                        "WHERE Ten_Dang_Nhap = @Ten_Dang_Nhap AND Mat_Khau = @Mat_Khau", db.getConnection);

                    command.Parameters.Add("@Ten_Dang_Nhap", SqlDbType.VarChar).Value = textBox_Username.Text;
                    command.Parameters.Add("@Mat_Khau", SqlDbType.VarChar).Value = textBox_Password.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if ((table.Rows.Count > 0))
                    {
                        int GlobalID = Convert.ToInt32(table.Rows[0][0].ToString());
                        Globals.SetGlobalsUserId(GlobalID);
                        string GlobaName = table.Rows[0][5].ToString();
                        Globals.SetGlobalsUsername(GlobaName);
                        string GlobalRole = "Thợ trông giữ xe";
                        Globals.SetGlobalsUserRole(GlobalRole);

                        byte[] imgData = (byte[])table.Rows[0][9];
                        MemoryStream ms = new MemoryStream(imgData);
                        Globals.SetGlobalsUserImages(ms);
                        /*Image img = Image.FromStream(ms);
                        pictureBox1.Image = img;*/

                        progressBar1.Show();
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 100;
                        progressBar1.Step = 20;
                        for (int i = 0; i < 100; i += 5)
                        {
                            Thread.Sleep(30);
                            progressBar1.PerformStep();
                            progressBar1.Update();
                        }
                        //this.DialogResult = DialogResult.OK;
                        label_Login_Wrong.Text = "Chính xác";
                        label_Login_Wrong.ForeColor = Color.Lime;
                        label_Login_Wrong.Visible = true;
                        MainForm mainForm = new MainForm();
                        //mainForm.button_Trong_Coi_Xe.Visible = false;
                        mainForm.Show(this);
                    }
                    else
                    {
                        //MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Password.Text = "";
                        label_Login_Wrong.Text = "Tài khoản hoặc mật khẩu không đúng";
                        label_Login_Wrong.ForeColor = Color.Red;
                        label_Login_Wrong.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(textBox_Password.UseSystemPasswordChar == false)
                textBox_Password.UseSystemPasswordChar = true;
            else
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
