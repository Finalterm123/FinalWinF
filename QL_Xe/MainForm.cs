using QL_Xe.Chuyen_Mon;
using QL_Xe.Cong_Viec;
using QL_Xe.HD_CT_Cho_Thue;
using QL_Xe.HD_KH_Cho_Thue;
using QL_Xe.HD_KH_Thue_Xe;
using QL_Xe.Tho;
using QL_Xe.TrongCoiXe;
using QL_Xe.Xe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesing(); // Ẩn các panel đi
        }
        private void customizeDesing()
        {
            panel_Trong_Coi_xe.Visible = false;
            panel_CT_Cho_Thue.Visible = false;
            panel_KH_Cho_Thue.Visible = false;
            panel_KH_Thue_xe.Visible = false;
            panel_QL.Visible = false;
            panel_Xe.Visible = false;
            panel_Cong_Viec.Visible = false;
            panel_Chuyen_Mon.Visible = false;
            panel_Tho.Visible = false;
            //..
        }
        private void hide_All_Panel()
        {
            if (panel_Trong_Coi_xe.Visible == true)
                panel_Trong_Coi_xe.Visible = false;
            if (panel_CT_Cho_Thue.Visible == true)
                panel_CT_Cho_Thue.Visible = false;
            if (panel_KH_Cho_Thue.Visible == true)
                panel_KH_Cho_Thue.Visible = false;
            if (panel_KH_Thue_xe.Visible == true)
                panel_KH_Thue_xe.Visible = false;
            // QL

            if (panel_Xe.Visible == true)
                panel_Xe.Visible = false;
            if (panel_Cong_Viec.Visible == true)
                panel_Cong_Viec.Visible = false;
            if (panel_Tho.Visible == true)
                panel_Tho.Visible = false;
            if (panel_Chuyen_Mon.Visible == true)
                panel_Chuyen_Mon.Visible = false;
            if (panel_QL.Visible == true)
                panel_QL.Visible = false;
        }
        private void hide_Panel_Ql()
        {
            /*if (panel_QL.Visible == true)
                panel_QL.Visible = false;*/
            if (panel_Xe.Visible == true)
                panel_Xe.Visible = false;
            if (panel_Cong_Viec.Visible == true)
                panel_Cong_Viec.Visible = false;
            if (panel_Tho.Visible == true)
                panel_Tho.Visible = false;
            if (panel_Chuyen_Mon.Visible == true)
                panel_Chuyen_Mon.Visible = false;
        }
        private void Show_Sub_Menu(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hide_All_Panel();
                subPanel.Visible = true;
            }
            else
                subPanel.Visible = false;

        }
        private void Show_QL_Menu(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hide_Panel_Ql();
                subPanel.Visible = true;
            }
            else
                subPanel.Visible = false;

        }

        private void button_Trong_Coi_Xe_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Trong_Coi_xe);
        }

        private void button_Gui_Xe_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Gui_Xe());
            //..
            hide_All_Panel();
        }

        private void button_Tra_Xe_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Tra_Xe());
            //..
            hide_All_Panel();
            //..
        }

        private void button_Doanh_Thu_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Doanh_Thu());
            //..
            hide_All_Panel();
        }

        private void button_KH_Thue_Xe_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_KH_Thue_xe);
        }

        private void button_Them_HD_KH_Thue_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Them_HD_KH_Thue());
            //..
            hide_All_Panel();
        }

        private void button_Sua_HD_KH_Thue_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_HD_KH_Thue_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new DS_HD_KH_Thue());
            //..
            hide_All_Panel();
        }

        private void button_KH_Cho_Thue_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_KH_Cho_Thue);
        }

        private void button_Them_HD_KH_Cho_Thue_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Them_HD_KH_Cho_Thue());
            //..
            hide_All_Panel();
        }

        private void button_Sua_HD_KH_Cho_Thue_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_HD_KH_Cho_Thue_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new DS_HD_KH_Cho_Thue());
            //..
            hide_All_Panel();
        }

        private void button_CT_Cho_Thue_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_CT_Cho_Thue);
        }

        private void button_Them_HD_CT_Cho_Thue_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Them_HD_CT_Cho_Thue());
            //..
            hide_All_Panel();
        }

        private void button_Sua_HD_CT_Cho_Thue_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_HD_CT_Cho_Thue_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new DS_HD_CT_Cho_Thue());
            //..
            hide_All_Panel();
        }

        private Form activeForm = null;
        private void open_Child_Form(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Child_Form.Controls.Add(childForm);
            panel_Child_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Xe_Click(object sender, EventArgs e)
        {
            Show_QL_Menu(panel_Xe);
        }

        private void button_Cong_Viẹc_Click(object sender, EventArgs e)
        {
            Show_QL_Menu(panel_Cong_Viec);
        }

        private void button_Tho_Click(object sender, EventArgs e)
        {
            Show_QL_Menu(panel_Tho);
        }

        private void button_Chuyen_Mon_Click(object sender, EventArgs e)
        {
            Show_QL_Menu(panel_Chuyen_Mon);
        }

        private void button_Them_Xe_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Them_Xe());

            //..
            hide_All_Panel();
        }
        private void button_DS_Xe_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new DS_Xe_Tim_Kiem());

            //..
            hide_All_Panel();
        }

        private void button_Tim_Kiem_Xe_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_Them_Cong_Viec_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Them_Cong_Viec());
            //..
            hide_All_Panel();
        }

        private void button_Xoa_Cong_Viec_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_Cong_Viec_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_Tim_Kiem_Cong_Viec_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_Them_Tho_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Them_Tho());
            //..
            hide_All_Panel();
        }

        private void button_Xoa_Tho_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_Tho_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_Tim_Kiem_Tho_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_Them_Chuyen_Mon_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Them_Chuyen_Mon());
            //..
            hide_All_Panel();
        }

        private void button_Xoa_Chuyen_Mon_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_Chuyen_Mon_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_Tim_Kiem_Chuyen_Mon_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_QL_Click(object sender, EventArgs e)
        {

            Show_Sub_Menu(panel_QL);
            hide_Panel_Ql();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Image img = Image.FromStream(Globals.GlobalsUserImages);
            pictureBox_user.Image = img;

            label_Role.Text = Globals.GlobalsUserRole;
            label_Name.Text = Globals.GlobalsUserName;
            label_ID.Text = "ID: " + Globals.GlobalsUserId.ToString();
        }

        private void button_Sua_Xe_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Sua_Xoa_Xe());

            //..
            hide_All_Panel();
        }

        private void button_Sua_Cong_Viec_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Sua_Xoa_CV());

            //..
            hide_All_Panel();
        }

        private void button_Sua_Tho_Click(object sender, EventArgs e)
        {
            //..
            open_Child_Form(new Sua_Xoa_Tho());
            //..
            hide_All_Panel();
        }

        private void button_Sua_Chuyen_Mon_Click(object sender, EventArgs e)
        {
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_Tim_Cong_Viec_Click(object sender, EventArgs e)
        {
            open_Child_Form(new DS_Tim_CV());
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_Tim_Tho_Click(object sender, EventArgs e)
        {
            open_Child_Form(new DS_Tim_Tho());
            //..
            //..
            hide_All_Panel();
        }

        private void button_DS_Tim_Chuyen_Mon_Click(object sender, EventArgs e)
        {
            open_Child_Form(new DS_Xoa_CM());
            //..
            //..
            hide_All_Panel();
        }

        private void button_Tao_Acc_4_Tho_Click(object sender, EventArgs e)
        {
            open_Child_Form(new Create_Account());
            //..
            //..
            hide_All_Panel();
        }

        private void button_Danh_Sach_Trong_Coi_Xe_Click(object sender, EventArgs e)
        {
            open_Child_Form(new Danh_Sach_Trong_Coi_Xe());
            //..
            //..
            hide_All_Panel();
        }

        private void button_Xoa_Sua_HD_KH_Thue_Click(object sender, EventArgs e)
        {
            open_Child_Form(new Xoa_Sua_HD_KH_Thue());
            //..
            //..
            hide_All_Panel();
        }

        private void button_Xoa_Sua_HD_CT_Cho_Thue_Click(object sender, EventArgs e)
        {
            open_Child_Form(new Xoa_Sua_HD_CT_Cho_Thue());
            //..
            //..
            hide_All_Panel();
        }

        private void button_Xoa_Sua_HD_KH_Cho_Thue_Click(object sender, EventArgs e)
        {
            open_Child_Form(new Xoa_Sua_HD_KH_Cho_Thue());
            //..
            //..
            hide_All_Panel();
        }
    }
}
