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
    public partial class DS_Tim_CV : Form
    {
        public DS_Tim_CV()
        {
            InitializeComponent();
        }
        Cong_Viec cong_Viec = new Cong_Viec();
        private void DS_Tim_CV_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cong_Viec");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView_CV.ReadOnly = true;
            dataGridView_CV.RowTemplate.Height = 80;
            dataGridView_CV.DataSource = cong_Viec.selectCVList(command);
            dataGridView_CV.AllowUserToAddRows = false;
            dataGridView_CV.AllowUserToResizeRows = false;
            dataGridView_CV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_CV.RowHeadersVisible = false;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cong_Viec");
            fillGrid(command);
        }

        private void textBox_Tim_Kiem_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Cong_Viec WHERE CONCAT(ID_CV, Ten_CV) LIKE N'%" + textBox_Tim_Kiem.Text + "%'");
            fillGrid(command);   
        }

        private void dataGridView_CV_DoubleClick(object sender, EventArgs e)
        {
            Sua_Xoa_CV sua_Xoa_CV = new Sua_Xoa_CV();
            sua_Xoa_CV.textBox_ID.Text = dataGridView_CV.CurrentRow.Cells[0].Value.ToString();
            sua_Xoa_CV.textBox_Ten_CV.Text = dataGridView_CV.CurrentRow.Cells[1].Value.ToString();
            sua_Xoa_CV.textBox_Mo_Ta.Text = dataGridView_CV.CurrentRow.Cells[2].Value.ToString();
            this.Close();
            sua_Xoa_CV.Show();
        }
    }
}
