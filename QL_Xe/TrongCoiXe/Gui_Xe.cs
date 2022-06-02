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
    public partial class Gui_Xe : Form
    {
        public Gui_Xe()
        {
            InitializeComponent();
            label_IDxe.Hide();
        }
        

        VITRI vt = new VITRI();
        Xe.Xe xe = new Xe.Xe();
        DICHVU dv = new DICHVU();
        GUI Gui = new GUI();

        List<List<string>> listDV = new List<List<string>>();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gui_Xe_Load(object sender, EventArgs e)
        {
            ///load... vi tri

            panel_Chon_Vi_Chi.Hide();
            //dataGridView_Vitri.DataSource = vt.getVitri();

            ///load... xe
            panel_selectXe.Hide();

            ///load..dịch vụ
            panel_DichVu.Hide();
            panel_selectXe.Show();

            


            comboBox_Loai_Xe.DisplayMember = "Text";
            comboBox_Loai_Xe.ValueMember = "Value";

            comboBox_Loai_Xe.Items.Add(new { Text = "Xe Đạp" });
            comboBox_Loai_Xe.Items.Add(new { Text = "Xe Máy" });
            comboBox_Loai_Xe.Items.Add(new { Text = "Ô Tô" });

            comboBox_LoaiHinhGui.DisplayMember = "Text";
            comboBox_LoaiHinhGui.ValueMember = "Value";

            comboBox_LoaiHinhGui.Items.Add(new { Text = "Giờ" });
            comboBox_LoaiHinhGui.Items.Add(new { Text = "Ngày" });
            comboBox_LoaiHinhGui.Items.Add(new { Text = "Tuần" });
            comboBox_LoaiHinhGui.Items.Add(new { Text = "Tháng" });


        }

        private void comboBox_Loai_Xe_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_Loai_Xe.Text.ToString() == "Xe Đạp")
            {
                dataGridView_chonDV.DataSource = dv.getCurDataDV(comboBox_Loai_Xe.Text.ToString());

                dataGridView_Vitri.DataSource = vt.getVitri(1);

                dataGridView_selectXe.ReadOnly = true;
                dataGridView_selectXe.RowTemplate.Height = 80;
                dataGridView_selectXe.DataSource = xe.listXetoSelect(comboBox_Loai_Xe.Text.ToString());
                dataGridView_selectXe.AllowUserToAddRows = false;
                dataGridView_selectXe.AllowUserToResizeRows = false;
                dataGridView_selectXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_selectXe.RowHeadersVisible = false;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dataGridView_selectXe.Columns[3];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            else if (comboBox_Loai_Xe.Text.ToString() == "Xe Máy")
            {
                dataGridView_chonDV.DataSource = dv.getCurDataDV(comboBox_Loai_Xe.Text.ToString());

                dataGridView_Vitri.DataSource = vt.getVitri(2);

                dataGridView_selectXe.ReadOnly = true;
                dataGridView_selectXe.RowTemplate.Height = 80;
                dataGridView_selectXe.DataSource = xe.listXetoSelect(comboBox_Loai_Xe.Text.ToString());
                dataGridView_selectXe.AllowUserToAddRows = false;
                dataGridView_selectXe.AllowUserToResizeRows = false;
                dataGridView_selectXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_selectXe.RowHeadersVisible = false;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dataGridView_selectXe.Columns[3];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            }
            else if (comboBox_Loai_Xe.Text.ToString() == "Ô Tô")
            {
                dataGridView_chonDV.DataSource = dv.getCurDataDV(comboBox_Loai_Xe.Text.ToString());

                dataGridView_Vitri.DataSource = vt.getVitri(3);

                dataGridView_selectXe.ReadOnly = true;
                dataGridView_selectXe.RowTemplate.Height = 80;
                dataGridView_selectXe.DataSource = xe.listXetoSelect(comboBox_Loai_Xe.Text.ToString());
                dataGridView_selectXe.AllowUserToAddRows = false;
                dataGridView_selectXe.AllowUserToResizeRows = false;
                dataGridView_selectXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_selectXe.RowHeadersVisible = false;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dataGridView_selectXe.Columns[3];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            else
            {
                MessageBox.Show("Loại xe không hợp lệ!!");
                comboBox_Loai_Xe.Text = "";
            }
        }

        private void button_Chon_VT_Click(object sender, EventArgs e)
        {
            panel_Chon_Vi_Chi.Show(); panel_selectXe.Hide();panel_DichVu.Hide();
        }

        private void dataGridView_Vitri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_viTri.Text = dataGridView_Vitri.CurrentRow.Cells[0].Value.ToString();
            panel_Chon_Vi_Chi.Hide();            
        }

        private void button_Chon_Xe_Click(object sender, EventArgs e)
        {
            panel_selectXe.Show();panel_Chon_Vi_Chi.Hide();panel_DichVu.Hide();
        }

/*        private void dataGridView_selectXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_So_Bien.Text = dataGridView_selectXe.CurrentRow.Cells[1].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView_selectXe.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox_Xe.Image = Image.FromStream(picture);
            panel_selectXe.Hide();
        }*/

        private void button_chonDV_Click(object sender, EventArgs e)
        {
            panel_DichVu.Show();panel_selectXe.Hide();panel_Chon_Vi_Chi.Hide();
        }

        private void dataGridView_selectXe_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            label_IDxe.Text = dataGridView_selectXe.CurrentRow.Cells[0].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView_selectXe.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox_Xe.Image = Image.FromStream(picture);
            panel_selectXe.Hide();
        }

        int count = 0;
        private void button_selectDV_Click(object sender, EventArgs e)
        {
            //add dịch vụ vào list
            listDV.Add(new List<string>());
            listDV[count] = new List<string>();
            int idDv = dv.getMaxIdDV()+1;
            listDV[count].Add(idDv.ToString());
            listDV[count].Add(textBox_ID_Gui.Text);
            listDV[count].Add(dataGridView_chonDV.CurrentRow.Cells[0].Value.ToString());
            listDV[count].Add(dataGridView_chonDV.CurrentRow.Cells[1].Value.ToString());

            count++;

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

            button_selectDV.Enabled = false;
        }

        private void dataGridView_chonDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            button_selectDV.Enabled = true;
        }

        private void button_Upload_Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_ImageGui.Image = Image.FromFile(opf.FileName);
            }


        }

        private void button_Xong_Click(object sender, EventArgs e)
        {
            int idGUi = Convert.ToInt32( textBox_ID_Gui.Text);
            MemoryStream Hinh = new MemoryStream();
            pictureBox_ImageGui.Image.Save(Hinh, pictureBox_ImageGui.Image.RawFormat);
            int idXe = Convert.ToInt32(label_IDxe.Text);
            int idVT = Convert.ToInt32(textBox_viTri.Text);
            int idTho = Globals.GlobalsUserId;
            int idDv = Convert.ToInt32(textBox_Dichvu.Text);
            DateTime Sd = Convert.ToDateTime(dateTimePicker_Bat_Dau.Value.ToString());
            DateTime Ed;
            string loaihinhGui = comboBox_LoaiHinhGui.Text;
            float phi = 0;
            float phat = 0;
            string mota = textBox_Mo_Ta.Text;

            if (Gui.insertGui(idGUi, Hinh, idXe, idVT, idTho, idDv, Sd, loaihinhGui, 0, 0, mota))
            {
                MessageBox.Show("SUCCESS");
            }
            else
            {
                MessageBox.Show("Fail!");
            }

            //load DV
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int id = Convert.ToInt32(listDV[i][0]);
                    int idGui = Convert.ToInt32(listDV[i][1]);
                    int idCM = Convert.ToInt32(listDV[i][2]);

                    if (dv.insertDV(id, idGui, idCM))
                    {
                        MessageBox.Show("success!");
                    }
                    else
                    {
                        MessageBox.Show("fail!");
                    }


                }
            }
        }
    }
}
