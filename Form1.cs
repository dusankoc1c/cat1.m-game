using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectm
{
    public partial class Form1 : Form
    {


        /// <summary>
        /// 
        /// </summary>

        int i = 0;
        int br1 = 0;
        int br = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            pictureBox5.Hide(); 
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
        }


        /// <summary>
        /// 
        /// </summary>

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.SuspendLayout();

            if (br % 2 == 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);
            }
      
            this.ResumeLayout();
            br++;
            if (br >= 5)
            {
                pictureBox2.Show();
                pictureBox5.Show();
                pictureBox3.Hide();
                pictureBox4.Hide();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            br1++;
            switch (br1)
            {
                case 1:
                    Size size0 = new Size(125, 69);
                    pictureBox2.Size = size0;
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 5);
                    break;
                case 2:
                    Size size = new Size(130, 79);
                    pictureBox2.Size = size;
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 5);
                    break;
                case 3:
                    Size size1 = new Size(135, 89);
                    pictureBox2.Size = size1;
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 5);
                    break;
                case 4:
                    Size size2 = new Size(140, 99);
                    pictureBox2.Size = size2;
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 5);
                    break;
                case 5:
                    Size size3 = new Size(145, 109);
                    pictureBox2.Size = size3;
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 5);
                    break;
                case 6:
                    Size size4 = new Size(150, 119);
                    pictureBox2.Size = size4;
                    pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y - 5);
                    break;
                case 7:
                    Size size5 = new Size(170, 135);
                    pictureBox2.Size = size5;
                    pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y - 5);
                    break;
                case 8:
                    Size size6 = new Size(310, 280);
                    pictureBox2.Size = size6;
                    pictureBox2.Location = new Point(pictureBox2.Location.X - 30, pictureBox2.Location.Y - 45);
                    pictureBox5.Hide();
                    pictureBox6.Show();
                    pictureBox7.Show();
                    pictureBox8.Show();
                    break;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();  
            this.Close();
        }
    }
}
