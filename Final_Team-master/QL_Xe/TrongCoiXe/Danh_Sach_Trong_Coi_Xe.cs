using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            panel1.Hide();
        }

        VITRI vt = new VITRI();
        Xe.Xe xe = new Xe.Xe();
        DICHVU dv = new DICHVU();
        GUI gui = new GUI();
        Chuyen_Mon.ChuyenMon cm = new Chuyen_Mon.ChuyenMon();

        bool flag = true;
        int count = 0;
        int idDv;
        int begin_Count = 0;

        List<List<string>> listDV = new List<List<string>>();

        private void Danh_Sach_Trong_Coi_Xe_Load(object sender, EventArgs e)
        {
            dataGridView_Trongcoixe.DataSource = gui.getAllGui();
            this.dataGridView_Trongcoixe.Columns["ID_HDG"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["ID_Xe"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["ID_VT"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["ID_Tho"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["ID_DV"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["End_Time"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["Phi"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["Phat"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["Mo_Ta"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["ID_Xe"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["Hinh"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["Tinh_Trang"].Visible = false;
            this.dataGridView_Trongcoixe.Columns["ID_Xe1"].Visible = false;


            panel_DichVu.Hide();
            
            //load panel1


        }

        private void dataGridView_Trongcoixe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Show();


            textBox_ID_Gui.Text = dataGridView_Trongcoixe.CurrentRow.Cells[0].Value.ToString();
            comboBox_LoaiHinhGui.Text = dataGridView_Trongcoixe.CurrentRow.Cells[8].Value.ToString();
            dateTimePicker_Bat_Dau.Value = Convert.ToDateTime(dataGridView_Trongcoixe.CurrentRow.Cells[6].Value);
            textBox_viTri.Text = dataGridView_Trongcoixe.CurrentRow.Cells[3].Value.ToString();
            textBox_Mo_Ta.Text = dataGridView_Trongcoixe.CurrentRow.Cells[11].Value.ToString();
            if (dataGridView_Trongcoixe.CurrentRow.Cells[5].Value.ToString() == "-1")
            {
                radioButton_noDV.Checked = true;
            }
            else
                radioButton_yesDV.Checked = true;

            byte[] pic;
            pic = (byte[])dataGridView_Trongcoixe.CurrentRow.Cells[1].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox_ImageGui.Image = Image.FromStream(picture);

            comboBox_Loai_Xe.Text = dataGridView_Trongcoixe.CurrentRow.Cells[14].Value.ToString();
            byte[] pic1;
            pic1 = (byte[])dataGridView_Trongcoixe.CurrentRow.Cells[1].Value;
            MemoryStream picture1 = new MemoryStream(pic1);
            pictureBox_ImageGui.Image = Image.FromStream(picture1);

            setListandCount();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            listDV.Clear();
            count = 0;
            begin_Count = 0;
            dataGridView_chonDV.Refresh();
            dataGridView_chonDV.DataSource = null;
            dataGridView_chonDV.Columns.Clear();

        }

        private void setListandCount()
        {
            idDv = Convert.ToInt32(dataGridView_Trongcoixe.CurrentRow.Cells[5].Value.ToString());
            if ((dataGridView_Trongcoixe.CurrentRow.Cells[5].Value.ToString()) != "-1")

            {
                DataTable dt = new DataTable();
                int s = Convert.ToInt32( dataGridView_Trongcoixe.CurrentRow.Cells[5].Value);
                dt = dv.getIdCM(s);
                foreach (DataRow dr in dt.Rows)
                {
                    //add dịch vụ vào list
                    listDV.Add(new List<string>());
                    listDV[count] = new List<string>();
                    listDV[count].Add(dataGridView_Trongcoixe.CurrentRow.Cells[5].Value.ToString());
                    listDV[count].Add(dataGridView_Trongcoixe.CurrentRow.Cells[0].Value.ToString());
                    listDV[count].Add(dr[0].ToString());
                    DataTable dataTable = new DataTable();
                    dataTable = cm.getCMById(Convert.ToInt32(dr[0].ToString()));
                    listDV[count].Add(dataTable.Rows[0][1].ToString());

                    count++;
                    begin_Count++;
                }

            }


        }

        private void button_chonDV_Click(object sender, EventArgs e)
        {

            if (!radioButton_noDV.Checked)
            {
                panel_DichVu.Show();
                //dich vu
                dataGridView_chonDV.DataSource = dv.getCurDataDV(comboBox_Loai_Xe.Text.ToString());
                //kiểm tra dịch vụ đã nằm trong danh sách chọn chưa
                if (count != 0)
                {
                    for (int i = 0; i < listDV.Count; i++)
                    {
                        foreach (DataGridViewRow row in dataGridView_chonDV.Rows)
                        {
                            if (listDV[i][2] == row.Cells[0].Value.ToString())
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                
                            }

                        }
                    }
                }


                //thông báo dịch vụ được chọn
                if (count != 0)
                {
                    string text_ = "";
                    label_thongbaoDV.Text = "Dịch vụ: ";
                    for (int i = 0; i < listDV.Count; i++)
                    {
                        text_ += listDV[i][3].ToString();
                        text_ += "\n";
                        text_ += "                ";
                    }
                    label_thongbaoDV.Text += text_;
                }
                else
                    label_thongbaoDV.Text = "Dịch vụ trống! ";
            }
            else
            {

            }
        }

        private void button_selectDV_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                if (idDv == -1)
                {
                    idDv = dv.getMaxIdDV() + 1;
                }

                //add dịch vụ vào list
                listDV.Add(new List<string>());
                listDV[count] = new List<string>();
                //int idDv = dv.getMaxIdDV() + 1;
                listDV[count].Add(idDv.ToString());
                listDV[count].Add(textBox_ID_Gui.Text);
                listDV[count].Add(dataGridView_chonDV.CurrentRow.Cells[0].Value.ToString());
                listDV[count].Add(dataGridView_chonDV.CurrentRow.Cells[1].Value.ToString());

                count++;
            }
            else
            {
                for (int i = 0; i < listDV.Count; i++)
                {
                    foreach (DataGridViewRow row in dataGridView_chonDV.Rows)
                    {
                        if (listDV[i][2] == row.Cells[0].Value.ToString())
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                            listDV.RemoveAt(i);
                            count--;
                            i = listDV.Count - 1;
                            break;
                        }

                    }
                }
            }
            //tô màu danh sách
            if (count != 0)
            {
                for (int i = 0; i < listDV.Count; i++)
                {
                    foreach (DataGridViewRow row in dataGridView_chonDV.Rows)
                    {
                        if (listDV[i][2] == row.Cells[0].Value.ToString() &&
                            row.DefaultCellStyle.BackColor != Color.Red)
                        {
                            row.DefaultCellStyle.BackColor = Color.Blue;
                        }

                    }
                }
            }

            //thông báo dịch vụ được chọn
            if (count != 0)
            {
                string text_ = "";
                label_thongbaoDV.Text = "Dịch vụ: ";
                for (int i = 0; i < listDV.Count; i++)
                {
                    text_ += listDV[i][3];
                    text_ += "\n";
                    text_ += "                ";
                }
                label_thongbaoDV.Text += text_;
            }
            else
                label_thongbaoDV.Text = "Dịch vụ trống! ";


            button_selectDV.Enabled = false;
            button_selectDV.Text = "Chọn";
            flag = true;
            dataGridView_chonDV.ClearSelection();
        }

        private void dataGridView_chonDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tô màu danh sách
            if (count != 0)
            {
                for (int i = 0; i < listDV.Count; i++)
                {
                    if (listDV[i][2] == dataGridView_chonDV.CurrentRow.Cells[0].Value.ToString())
                    {
                        if ( dataGridView_chonDV.CurrentRow.DefaultCellStyle.BackColor == Color.Red)
                        {
                            button_selectDV.Enabled = false;
                            return;
                        }
                        
                        flag = false;
                        button_selectDV.Text = "Hủy";
                        break;
                    }
                }
            }

            button_selectDV.Enabled = true;
        }

        private void button_CloseDV_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                for (int i = begin_Count; i < count; i++)
                {
                    int id = Convert.ToInt32(listDV[i][0]);
                    int idGui = Convert.ToInt32(listDV[i][1]);
                    int idCM = Convert.ToInt32(listDV[i][2]);

                    if (dv.insertDV(id, idGui, idCM))
                    {
                        gui.updateIdDV(idGui, idDv);

                        MessageBox.Show("thêm dịch vụ thành công!");
                        panel1.Hide();
                        listDV.Clear();
                        count = 0;
                        begin_Count = 0;
                        dataGridView_chonDV.Refresh();
                        dataGridView_chonDV.DataSource = null;
                        dataGridView_chonDV.Columns.Clear();
                    }
                    else
                    {
                        MessageBox.Show("thêm dịch vụ thất bại!");
                    }


                }
            }
            else
            {
                MessageBox.Show("not running!!");
            }


        }
    }
}
