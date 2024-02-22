using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectm
{
    public partial class Form2 : Form
    {
        int br1 = 0, br2=0;
        bool moveRight, moveLeft, moveUp, moveDown, rr;
        int speed = 12;

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Hide();
            pictureBox4.Hide();
            label4.Hide();
            label5.Hide();
            Size size4 = new Size(150, 119);
            pictureBox4.Size = size4;
            pictureBox4.Location = new Point(pbduda.Location.X-20, pbduda.Location.Y-30);
        }

        private void pbduda_MouseDown(object sender, MouseEventArgs e)
        {
            br2++;
            if (br2 > 4)
            {
                label4.Show();
                label3.Text = "";
                label5.Text = "";
            }
            pbduda.Hide();
            pictureBox4.Show();
        }

        private void pbduda_MouseUp(object sender, MouseEventArgs e)
        {
            pbduda.Show();
            pictureBox4.Hide();
        }

        private void pbduda_Click(object sender, EventArgs e)
        {
            
        }

        public Form2()
        {
          
            InitializeComponent();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(moveLeft == true && pbduda.Left > 0)
            {
                pbduda.Left -= speed;    
            }
            if (moveRight == true && pbduda.Left < 566)
            {
                pbduda.Left += speed;
            }
            if (moveUp == true && pbduda.Top > 0)
            {
                pbduda.Top -= speed;
            }
            if (moveDown == true && pbduda.Top < 453)
            {
                pbduda.Top += speed;
            } 
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "object")
                {
                    if (pbduda.Bounds.IntersectsWith(x.Bounds))
                    {
                        
                        this.Controls.Remove(x);
                        br1++;
                        label1.Text = br1 + "/4";
                    }
                    
                }
                if (br1 >= 4)
                {
                    label3.Show();
                    label1.Hide();
                    label2.Hide();
                    label5.Show();
                    Size size4 = new Size(150, 119);
                    pbduda.Size = size4;
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;    
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
            
        }
    }    
}
