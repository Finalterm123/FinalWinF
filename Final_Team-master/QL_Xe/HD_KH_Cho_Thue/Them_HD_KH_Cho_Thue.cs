using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe.HD_KH_Cho_Thue
{
    public partial class Them_HD_KH_Cho_Thue : Form
    {
        public Them_HD_KH_Cho_Thue()
        {
            InitializeComponent();
        }

        private void Them_HD_KH_Cho_Thue_Load(object sender, EventArgs e)
        {
            panel_CTHD.Hide();
        }

        private void button_CTHD_Click(object sender, EventArgs e)
        {
            panel_CTHD.Show();

        }

        private void button_AddCTHD_Click(object sender, EventArgs e)
        {


            panel_CTHD.Hide();
        }
    }
}
