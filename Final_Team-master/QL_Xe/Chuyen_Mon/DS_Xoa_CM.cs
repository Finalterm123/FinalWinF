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

namespace QL_Xe.Chuyen_Mon
{
    public partial class DS_Xoa_CM : Form
    {
        public DS_Xoa_CM()
        {
            InitializeComponent();
        }
        ChuyenMon chuyenMon = new ChuyenMon();
        public void fillGrid(SqlCommand command)
        {
            dataGridView_DS_Chuyen_Mon.ReadOnly = true;
            dataGridView_DS_Chuyen_Mon.RowTemplate.Height = 80;
            dataGridView_DS_Chuyen_Mon.DataSource = chuyenMon.selectCMList(command);
            dataGridView_DS_Chuyen_Mon.AllowUserToAddRows = false;
            dataGridView_DS_Chuyen_Mon.AllowUserToResizeRows = false;
            dataGridView_DS_Chuyen_Mon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DS_Chuyen_Mon.RowHeadersVisible = false;
        }

        private void DS_Xoa_CM_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Chuyen_Mon");
            fillGrid(command);
        }

        private void textBox_Tim_Kiem_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Chuyen_Mon WHERE CONCAT(id_CM, Ten_CM,Loai_xe, ID_CV) LIKE N'%" + textBox_Tim_Kiem.Text + "%'");
            fillGrid(command);
        }

        private void dataGridView_DS_Chuyen_Mon_DoubleClick(object sender, EventArgs e)
        {
            int ID_CM = Convert.ToInt32(dataGridView_DS_Chuyen_Mon.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("Bạn có chắc muốn xóa chuyên môn " + dataGridView_DS_Chuyen_Mon.CurrentRow.Cells[1].Value.ToString() + " này chứ?", "Xóa chuyên môn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (chuyenMon.deleteCM(ID_CM) == true)
                {
                    MessageBox.Show("Đã xóa công việc", "Xóa công việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlCommand command = new SqlCommand("SELECT * FROM Chuyen_Mon");
                    fillGrid(command);
                }
            }
                
        }
    }
}
