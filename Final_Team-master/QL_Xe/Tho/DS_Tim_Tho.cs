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

namespace QL_Xe.Tho
{
    public partial class DS_Tim_Tho : Form
    {
        public DS_Tim_Tho()
        {
            InitializeComponent();
        }
        Tho tho = new Tho();
        public void fillGrid(SqlCommand command)
        {
            dataGridView_Tho.ReadOnly = true;
            dataGridView_Tho.RowTemplate.Height = 80;
            dataGridView_Tho.DataSource = tho.selectThoList(command);
            dataGridView_Tho.AllowUserToAddRows = false;
            dataGridView_Tho.AllowUserToResizeRows = false;
            dataGridView_Tho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Tho.RowHeadersVisible = false;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView_Tho.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void DS_Tim_Tho_Load(object sender, EventArgs e)
        {
            radioButton_All.Checked = true;
            SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, Ten_CM " +
                "from tho inner join Chuyen_Mon on tho.ID_CM = Chuyen_Mon.ID_CM");
            fillGrid(command);
        }
        private void textBox_Tim_Kiem_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_Nu.Checked)
            {
                SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, Ten_CM " +
                                            "from tho inner join Chuyen_Mon on tho.ID_CM = Chuyen_Mon.ID_CM " +
                                            "WHERE CONCAT(ID_Tho, Ten_Tho) LIKE N'%" + textBox_Tim_Kiem.Text + "%'" +
                                            " and Gioi_Tinh = N'Nữ'");
                fillGrid(command);

            }
            else if (radioButton_Nam.Checked)
            {
                SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, Ten_CM " +
                                            "from tho inner join Chuyen_Mon on tho.ID_CM = Chuyen_Mon.ID_CM " +
                                            "WHERE CONCAT(ID_Tho, Ten_Tho) LIKE N'%" + textBox_Tim_Kiem.Text + "%'" +
                                            " and Gioi_Tinh = N'Nam'");
                fillGrid(command);

            }
            else
            {
                SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, Ten_CM " +
                                            "from tho inner join Chuyen_Mon on tho.ID_CM = Chuyen_Mon.ID_CM " +
                                            " WHERE CONCAT(tho.ID_Tho, tho.Ten_Tho) LIKE N'%" + textBox_Tim_Kiem.Text + "%'");
                fillGrid(command);

            }

        }

        private void radioButton_All_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, Ten_CM " +
                                            "from tho inner join Chuyen_Mon on tho.ID_CM = Chuyen_Mon.ID_CM " +
                                            " WHERE CONCAT(tho.ID_Tho, tho.Ten_Tho) LIKE N'%" + textBox_Tim_Kiem.Text + "%'");
            fillGrid(command);
        }

        private void radioButton_Nam_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, Ten_CM " +
                                            "from tho inner join Chuyen_Mon on tho.ID_CM = Chuyen_Mon.ID_CM " +
                                            "WHERE CONCAT(ID_Tho, Ten_Tho) LIKE N'%" + textBox_Tim_Kiem.Text + "%'" +
                                            " and Gioi_Tinh = N'Nam'");
            fillGrid(command);
        }

        private void radioButton_Nu_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select ID_Tho, Ten_Tho, NgSinh, Gioi_Tinh, Phone, Anh, Ten_CM " +
                                            "from tho inner join Chuyen_Mon on tho.ID_CM = Chuyen_Mon.ID_CM " +
                                            "WHERE CONCAT(ID_Tho, Ten_Tho) LIKE N'%" + textBox_Tim_Kiem.Text + "%'" +
                                            " and Gioi_Tinh = N'Nữ'");
            fillGrid(command);
        }

        private void dataGridView_Tho_DoubleClick(object sender, EventArgs e)
        {
            Sua_Xoa_Tho Sua_Xoa_Tho = new Sua_Xoa_Tho();
            Sua_Xoa_Tho.textBox_ID.Text = dataGridView_Tho.CurrentRow.Cells[0].Value.ToString();
            Sua_Xoa_Tho.textBox_Tho.Text = dataGridView_Tho.CurrentRow.Cells[1].Value.ToString();
            Sua_Xoa_Tho.dateTimePicker1.Value = Convert.ToDateTime(dataGridView_Tho.CurrentRow.Cells[2].Value.ToString());
            
            string gioitinh = dataGridView_Tho.CurrentRow.Cells[3].Value.ToString();
            if(gioitinh == "Nam")
            {
                Sua_Xoa_Tho.radioButton_Nam.Checked = true;
            }
            else
            {
                Sua_Xoa_Tho.radioButton_Nu.Checked = true;
            }
            Sua_Xoa_Tho.textBox_SDT.Text = dataGridView_Tho.CurrentRow.Cells[4].Value.ToString();
            Sua_Xoa_Tho.comboBox_CM.Text = dataGridView_Tho.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView_Tho.CurrentRow.Cells[5].Value;
            MemoryStream picture = new MemoryStream(pic);
            Sua_Xoa_Tho.pictureBox.Image = Image.FromStream(picture);
            //this.Show();
            this.Close();
            Sua_Xoa_Tho.Show();
        }
    }
}
