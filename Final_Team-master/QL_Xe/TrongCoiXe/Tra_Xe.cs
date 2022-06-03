using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe.TrongCoiXe
{
    public partial class Tra_Xe : Form
    {
        public Tra_Xe()
        {
            InitializeComponent();
        }

        VITRI vt = new VITRI();
        Xe.Xe xe = new Xe.Xe();
        DICHVU dv = new DICHVU();
        GUI gui = new GUI();

        private void Tra_Xe_Load(object sender, EventArgs e)
        {
            dataGridView_Traxe.DataSource = gui.getAllGui();

            this.dataGridView_Traxe.Columns["ID_HDG"].Visible = false;
            this.dataGridView_Traxe.Columns["ID_Xe"].Visible = false;
            this.dataGridView_Traxe.Columns["ID_VT"].Visible = false;
            this.dataGridView_Traxe.Columns["ID_Tho"].Visible = false;
            this.dataGridView_Traxe.Columns["ID_DV"].Visible = false;
            this.dataGridView_Traxe.Columns["End_Time"].Visible = false;
            this.dataGridView_Traxe.Columns["Phi"].Visible = false;
            this.dataGridView_Traxe.Columns["Phat"].Visible = false;
            this.dataGridView_Traxe.Columns["Mo_Ta"].Visible = false;
            this.dataGridView_Traxe.Columns["ID_Xe"].Visible = false;
            this.dataGridView_Traxe.Columns["Hinh"].Visible = false;
            this.dataGridView_Traxe.Columns["Tinh_Trang"].Visible = false;
            this.dataGridView_Traxe.Columns["ID_Xe1"].Visible = false;
        }

        private void button_Tra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ok??","Trả xe",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                xe.updateXeTrabyID(Convert.ToInt32(dataGridView_Traxe.CurrentRow.Cells[2].Value.ToString()));
                gui.updateEndTime(Convert.ToInt32(dataGridView_Traxe.CurrentRow.Cells[0].Value.ToString()));
                vt.updateVTTrabyID(Convert.ToInt32(dataGridView_Traxe.CurrentRow.Cells[3].Value.ToString()));
            }
            

            Tra_Xe_Load(null, null);
        }
    }
}
