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


        //thiết lập phí cho xe
        float phi_xeDap = 1000;
        float phi_xeMay = 3000;
        float phi_xeOto = 20000;

        private void Doanh_Thu_Load(object sender, EventArgs e)
        {
            dataGridView_DaTra.DataSource = gui.getAllDaTra();


            //
            float giaTien = 0;
            for (int i = 0; i < dataGridView_DaTra.Rows.Count; i++)
            {
                int op = -1;

                if (dataGridView_DaTra.Rows[i].Cells[3].Value.ToString() == "Giờ")
                {
                    op = 0;
                }
                else if (dataGridView_DaTra.Rows[i].Cells[3].Value.ToString() == "Ngày")
                {
                    op = 1;

                }
                else if (dataGridView_DaTra.Rows[i].Cells[3].Value.ToString() == "Tuần")
                {
                    op = 2;
                }
                else if (dataGridView_DaTra.Rows[i].Cells[3].Value.ToString() == "Tháng") { op = 3; }

                if (dataGridView_DaTra.Rows[i].Cells[2].Value.ToString() == "Xe Máy")
                {
                    giaTien = phi_xeMay;
                }
                else if (dataGridView_DaTra.Rows[i].Cells[2].Value.ToString() == "Xe Đạp")
                {
                    giaTien = phi_xeDap;
                }
                else
                    giaTien = phi_xeOto;

                DateTime sd = Convert.ToDateTime( dataGridView_DaTra.Rows[i].Cells[4].Value.ToString());
                DateTime ed = Convert.ToDateTime(dataGridView_DaTra.Rows[i].Cells[5].Value.ToString());


                dataGridView_DaTra.Rows[i].Cells[6].Value =
                    doanhThu(0, op, giaTien, sd, ed) + gui.getTotalChiphibyIdGui(Convert.ToInt32( dataGridView_DaTra.Rows[i].Cells[0].Value));

                dataGridView_DaTra.Rows[i].Cells[7].Value =
                    doanhThu(1, op, giaTien, sd, ed);
            }

        }

        public float doanhThu(int option, int optionTime ,float giaTien, DateTime startDate, DateTime endDate)
        {
            float Phi = 0;
            float Phat = 0;

            var sd = startDate;
            var ed = endDate;
            var result = ed - sd;


            if (optionTime == 0)
            {


                Phi = giaTien*(int) result.TotalHours;

                if (result.TotalHours > 24)
                    Phat = 2 * 8 * giaTien;

            }
            else if (optionTime == 1)
            {
                Phi = 8*giaTien* result.Days;

                if (result.Days > 1)
                {
                    Phat = 3 * 8 * giaTien;
                }
            }
            else if (optionTime == 2)
            {
                int weeks = result.Days / 7;

                Phi =3* 8*giaTien * weeks;

                if (result.Days>10 && result.Days < 30)
                {
                    Phat = 2 * 3 * 8 * giaTien;
                }
            }
            else if (optionTime == 3)
            {
                int moths = Convert.ToInt32( ed.Subtract(sd).Days / (365.25 / 12));

                Phi = 2 * 3 * 8 * giaTien;
                if (moths>1 && result.Days > 15)
                {
                    Phat = 3 * 3 * 8 * giaTien;
                }
            }

            if (option == 0)
            {
                return Phi;
            }

            return Phat;

        }
    }
}
