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
    public partial class Inf_Xe : Form
    {
        /*public Inf_Xe()
        {
            InitializeComponent();
            //panel1.Location = new System.Drawing.Point(446, 185);
            //panel1.Name = "panel1";z
            //panel1.Size = new System.Drawing.Size(251, 317);
            int x = 0, y = 0;
            for (int i = 0; i < 10; i++)
            {
                panel3.Controls.Add(create(20 + x * 260, 185 + 400 * y));
                if (i % 5 == 0 && i != 0)
                {
                    x = 0;
                    y++;
                }
                else
                    x++;
            }
        }

        Panel create(int x, int y)
        {


            // 
            // label1
            // 
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(103, 29);
            label1.Size = new System.Drawing.Size(60, 19);
            label1.Text = "label1";
            // 
            Panel panel2 = new Panel();
            panel2.BackColor = System.Drawing.Color.SkyBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(251, 69);
            panel2.TabIndex = 0;
            // label2
            // 
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 19);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.Click += (s, e) =>
            {
                Panel tmp = (s as Label).Parent as Panel;
                MessageBox.Show(tmp.Controls[0].Text);
            };
            // 
            // label3
            // 
            Label label3 = new Label();
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 123);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 19);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            //
            Label label4 = new Label();
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 163);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 19);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // pictureBox1
            // 
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new System.Drawing.Point(78, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 100);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;

            Panel panel1 = new System.Windows.Forms.Panel();

            Label id = new Label()
            {
                Text ="trung ngu",
                Visible =false
            };
            panel1.Controls.Add(id);
            //  panel1.Controls[0].Text;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(x, y);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(251, 317);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            return panel1;
        }*/
    }
}
