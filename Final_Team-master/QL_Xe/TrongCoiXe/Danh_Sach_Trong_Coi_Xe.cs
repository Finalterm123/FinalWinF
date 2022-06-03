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
    public partial class Danh_Sach_Trong_Coi_Xe : Form
    {
        public Danh_Sach_Trong_Coi_Xe()
        {
            InitializeComponent();
        }

        VITRI vt = new VITRI();
        Xe.Xe xe = new Xe.Xe();
        DICHVU dv = new DICHVU();
        GUI gui = new GUI();

        private void Danh_Sach_Trong_Coi_Xe_Load(object sender, EventArgs e)
        {
            dataGridView_Trongcoixe.DataSource = gui.getAllGui();

        }

        private void dataGridView_Trongcoixe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Gui_Xe gui_Xe = new Gui_Xe();
            gui_Xe.ShowDialog();

        }
    }
}
