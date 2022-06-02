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
    public partial class DS_Xe_Tim_Kiem : Form
    {
        public DS_Xe_Tim_Kiem()
        {
            InitializeComponent();
        }
        Xe xe = new Xe();
        MainForm mainForm = new MainForm();
        private void DS_Xe_Load(object sender, EventArgs e)
        {
            comboBox_Loai_Xe.DisplayMember = "Text";
            comboBox_Loai_Xe.ValueMember = "Value";
            comboBox_Loai_Xe.Items.Add(new { Text = "All" });
            comboBox_Loai_Xe.Items.Add(new { Text = "Xe Đạp" });
            comboBox_Loai_Xe.Items.Add(new { Text = "Xe Máy" });
            comboBox_Loai_Xe.Items.Add(new { Text = "Ô Tô" });

            comboBox_Tinh_Trang.DisplayMember = "Text";
            comboBox_Tinh_Trang.ValueMember = "Value";
            comboBox_Tinh_Trang.Items.Add(new { Text = "All" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Đang gửi" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Đã trả" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Công ty đang thuê" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Khách hàng đang thuê" });
            comboBox_Tinh_Trang.Items.Add(new { Text = "Sẵn sàng cho thuê" });

            comboBox_Loai_Xe.Text = "All";
            comboBox_Tinh_Trang.Text = "All";
            SqlCommand command = new SqlCommand("SELECT * FROM xe");
            fillGrid(command);
        }

        private void comboBox_Tinh_Trang_TextChanged(object sender, EventArgs e)
        {
            
            if(check_Loai_Xe() == true && check_Tinh_Trang()== true)
            {
                string loai_Xe = comboBox_Loai_Xe.Text;
                string tinh_trang_Xe = comboBox_Tinh_Trang.Text;
                if(loai_Xe == "All" && tinh_trang_Xe == "All")
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM xe");
                    fillGrid(command);
                }
                else if (loai_Xe == "All")
                {
                    SqlCommand command = new SqlCommand("select * from xe where Tinh_Trang like N'"+ tinh_trang_Xe + "'");
                    fillGrid(command);
                }
                else if (tinh_trang_Xe == "All")
                {
                    SqlCommand command = new SqlCommand("select * from xe where Loai_Xe like N'" + loai_Xe + "'");
                    fillGrid(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("select * from xe where Loai_Xe like N'" + loai_Xe + "' and Tinh_Trang like N'"+ tinh_trang_Xe + "'");
                    fillGrid(command);
                }
                    
            }
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView_DS_Xe.ReadOnly = true;
            dataGridView_DS_Xe.RowTemplate.Height = 80;
            dataGridView_DS_Xe.DataSource = xe.selectXeList(command);
            dataGridView_DS_Xe.AllowUserToAddRows = false;
            dataGridView_DS_Xe.AllowUserToResizeRows = false;
            dataGridView_DS_Xe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DS_Xe.RowHeadersVisible = false;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView_DS_Xe.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        public bool check_Loai_Xe()
        {
            if (comboBox_Loai_Xe.Text == "Xe Đạp"
                || comboBox_Loai_Xe.Text == "Xe Máy"
                || comboBox_Loai_Xe.Text == "Ô Tô"
                || comboBox_Loai_Xe.Text == "All"
                )
                return true;
            else
                return false;
        }
        public bool check_Tinh_Trang()
        {
            if(comboBox_Tinh_Trang.Text == "Đang gửi"
                || comboBox_Tinh_Trang.Text == "Đã trả"
                || comboBox_Tinh_Trang.Text == "Công ty đang thuê"
                || comboBox_Tinh_Trang.Text == "Khách hàng đang thuê"
                || comboBox_Tinh_Trang.Text == "Sẵn sàng cho thuê"
                || comboBox_Tinh_Trang.Text == "All"
                )
                return true;
            else
                return false;
        }

        private void comboBox_Loai_Xe_TextChanged(object sender, EventArgs e)
        {
            if (check_Loai_Xe() == true && check_Tinh_Trang() == true)
            {
                string loai_Xe = comboBox_Loai_Xe.Text;
                string tinh_trang_Xe = comboBox_Tinh_Trang.Text;
                if (loai_Xe == "All" && tinh_trang_Xe == "All")
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM xe");
                    fillGrid(command);
                }
                else if (loai_Xe == "All")
                {
                    SqlCommand command = new SqlCommand("select * from xe where Tinh_Trang like N'" + tinh_trang_Xe + "'");
                    fillGrid(command);
                }
                else if (tinh_trang_Xe == "All")
                {
                    SqlCommand command = new SqlCommand("select * from xe where Loai_Xe like N'" + loai_Xe + "'");
                    fillGrid(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("select * from xe where Loai_Xe like N'" + loai_Xe + "' and Tinh_Trang like N'" + tinh_trang_Xe + "'");
                    fillGrid(command);
                }

            }
        }

        private void textBox_Tim_Kiem_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from xe WHERE CONCAT(ID_Xe, So_Bien_So) LIKE N'%" + textBox_Tim_Kiem.Text + "%'");
            fillGrid(command);
        }

        private void dataGridView_DS_Xe_DoubleClick(object sender, EventArgs e)
        {
            Sua_Xoa_Xe sua_Xoa_Xe = new Sua_Xoa_Xe();
            sua_Xoa_Xe.textBox_ID_Xe.Text = dataGridView_DS_Xe.CurrentRow.Cells[0].Value.ToString();
            sua_Xoa_Xe.textBox_So_Bien.Text = dataGridView_DS_Xe.CurrentRow.Cells[1].Value.ToString();
            sua_Xoa_Xe.comboBox_Loai_Xe.Text = dataGridView_DS_Xe.CurrentRow.Cells[2].Value.ToString();
            sua_Xoa_Xe.comboBox_Tinh_Trang.Text = dataGridView_DS_Xe.CurrentRow.Cells[4].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView_DS_Xe.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            sua_Xoa_Xe.pictureBox.Image = Image.FromStream(picture);
            //this.Show();
            this.Close();   
            sua_Xoa_Xe.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xe");
            fillGrid(command);
        }
    }
}
