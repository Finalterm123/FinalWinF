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
    public partial class Doanh_Thu : Form
    {
        public Doanh_Thu()
        {
            InitializeComponent();
        }

        VITRI vt = new VITRI();
        Xe.Xe xe = new Xe.Xe();
        DICHVU dv = new DICHVU();
        GUI gui = new GUI();

        private void Doanh_Thu_Load(object sender, EventArgs e)
        {
            dataGridView_DaTra.DataSource = gui.getAllDaTra();

            //phí theo giờ
            
        }
    }
}
