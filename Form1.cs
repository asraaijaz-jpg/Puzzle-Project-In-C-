using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VP_project_Puzzle_
{
    public partial class Form1 : Form
    {
        string path = @"original.jpg";
        int a = 2, b = 3, c = 4, d = 5, f = 6, g = 7, h = 8, i = 9;
        Random random = new Random();
        int Rand = 0;
        int counter = 0;
        int[] array1 = new int[15];
        int[] array2 = new int[15];
        bool value = false;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {  
           pictureBox1.Image = Image.FromFile(path);
            MessageBox.Show("INSTRUCTIONS That How To Play Game:"+'\n'+'\n'
                +"Click Start button to play game"+'\n'
                +"Click Shuffle at any time to shuffle the pictures"+'\n'
                +"Click Finish once you win the game and after that again click Start button to Restart game");
           }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.pictureBox3.Image == null)
            {
                this.pictureBox3.Image = pictureBox2.Image;
                pictureBox3.Tag = pictureBox2.Tag;
                this.pictureBox2.Image = null;
                pictureBox2.Tag ="";
            }
            if (this.pictureBox5.Image == null)
            {
                this.pictureBox5.Image = pictureBox2.Image;
                pictureBox5.Tag = pictureBox2.Tag;
                this.pictureBox2.Image = null;
                pictureBox2.Tag = "";
            }
            }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.pictureBox2.Image == null)
            {
                this.pictureBox2.Image = pictureBox3.Image;
                pictureBox2.Tag = pictureBox3.Tag;
                this.pictureBox3.Image = null;
                pictureBox3.Tag = "";
            }
            if (this.pictureBox4.Image == null)
            {
                this.pictureBox4.Image = pictureBox3.Image;
                pictureBox4.Tag = pictureBox3.Tag;
                this.pictureBox3.Image = null;
                pictureBox3.Tag = "";
            }
            if (this.pictureBox6.Image == null)
            {
                this.pictureBox6.Image = pictureBox3.Image;
                pictureBox6.Tag = pictureBox3.Tag;
                this.pictureBox3.Image = null;
                pictureBox3.Tag = "";
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (this.pictureBox2.Image == null)
            {
                this.pictureBox2.Image = pictureBox5.Image;
                pictureBox2.Tag = pictureBox5.Tag;
                pictureBox5.Image = null;
                pictureBox5.Tag="";
            }
            if (this.pictureBox6.Image == null)
            {
                this.pictureBox6.Image = pictureBox5.Image;
                pictureBox6.Tag = pictureBox5.Tag;
                this.pictureBox5.Image = null;
                pictureBox5.Tag = "";
            }
            if (this.pictureBox8.Image == null)
            {
                this.pictureBox8.Image = pictureBox5.Image;
                pictureBox8.Tag = pictureBox5.Tag;
                this.pictureBox5.Image = null;
                pictureBox5.Tag = "";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (this.pictureBox3.Image == null)
            {
                this.pictureBox3.Image = pictureBox6.Image;
                pictureBox3.Tag = pictureBox6.Tag;
                this.pictureBox6.Image = null;
                pictureBox6.Tag="";
            }
            if (this.pictureBox5.Image == null)
            {
                this.pictureBox5.Image = pictureBox6.Image;
                pictureBox5.Tag = pictureBox6.Tag;
                this.pictureBox6.Image = null;
                pictureBox6.Tag = "";
            }
            if (this.pictureBox7.Image == null)
            {
                this.pictureBox7.Image = pictureBox6.Image;
                pictureBox7.Tag = pictureBox6.Tag;
                this.pictureBox6.Image = null;
                pictureBox6.Tag ="";
            }
            if (this.pictureBox9.Image == null)
            {
                this.pictureBox9.Image = pictureBox6.Image;
                pictureBox9.Tag = pictureBox6.Tag;
                this.pictureBox6.Image = null;
                pictureBox6.Tag = "";
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (this.pictureBox3.Image == null)
            {
                this.pictureBox3.Image = pictureBox4.Image;
                pictureBox3.Tag = pictureBox4.Tag;
                this.pictureBox4.Image = null;
                pictureBox4.Tag = "";
            }
            if (this.pictureBox7.Image == null)
            {
                this.pictureBox7.Image = pictureBox4.Image;
                pictureBox7.Tag = pictureBox4.Tag;
                this.pictureBox4.Image = null;
                pictureBox4.Tag = "";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (this.pictureBox4.Image == null)
            {
                this.pictureBox4.Image = pictureBox7.Image;
                pictureBox4.Tag = pictureBox7.Tag;
                this.pictureBox7.Image = null;
                pictureBox7.Tag = "";
            }
            if (this.pictureBox6.Image == null)
            {
                this.pictureBox6.Image = pictureBox7.Image;
                pictureBox6.Tag = pictureBox7.Tag;
                this.pictureBox7.Image = null;
                pictureBox7.Tag = "";
            }
            if (this.pictureBox10.Image == null)
            {
                this.pictureBox10.Image = pictureBox7.Image;
                pictureBox10.Tag = pictureBox7.Tag;
                this.pictureBox7.Image = null;
                pictureBox7.Tag = "";
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (this.pictureBox7.Image == null)
            {
                this.pictureBox7.Image = pictureBox10.Image;
                pictureBox7.Tag = pictureBox10.Tag;
                this.pictureBox10.Image = null;
                pictureBox10.Tag = "";

         }
            if (this.pictureBox9.Image == null)
            {
                this.pictureBox9.Image = pictureBox10.Image;
                pictureBox9.Tag = pictureBox10.Tag;
                this.pictureBox10.Image = null;
                pictureBox10.Tag = "";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (this.pictureBox5.Image == null)
            {
                this.pictureBox5.Image = pictureBox8.Image;
                pictureBox5.Tag = pictureBox8.Tag;
                this.pictureBox8.Image = null;
                pictureBox8.Tag = "";
            }
            if (this.pictureBox9.Image == null)
            {
                this.pictureBox9.Image = pictureBox8.Image;
                pictureBox9.Tag = pictureBox8.Tag;
                this.pictureBox8.Image = null;
                pictureBox8.Tag = "";
            } 
                }
                private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (this.pictureBox8.Image == null)
            {
                this.pictureBox8.Image = pictureBox9.Image;
                pictureBox8.Tag = pictureBox9.Tag;
                this.pictureBox9.Image = null;
                pictureBox9.Tag = "";
            }
            if (this.pictureBox6.Image == null)
            {
                this.pictureBox6.Image = pictureBox9.Image;
                pictureBox6.Tag = pictureBox9.Tag;
                this.pictureBox9.Image = null;
                pictureBox9.Tag = "";
            }
            if (this.pictureBox10.Image == null)
            {
                this.pictureBox10.Image = pictureBox9.Image;
                pictureBox10.Tag = pictureBox9.Tag;
                this.pictureBox9.Image = null;
                pictureBox9.Tag = "";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
         /*        string str1 = a.ToString();
                 string str2 = b.ToString();
                 string str3 = c.ToString();
                 string str4 = d.ToString();
                 string str5 = f.ToString();
                 string str6 = g.ToString();
                 string str7 = h.ToString();
                 string str8 = i.ToString();

                 if(pictureBox2.Tag.ToString().Equals(str1))
                 {
                     if(pictureBox3.Tag.ToString().Equals(str2))
                     {
                         if(pictureBox4.Tag.ToString().Equals(str3))
                         {
                           if (pictureBox5.Tag.ToString().Equals(str4))
                           {
                               if (pictureBox6.Tag.ToString().Equals(str5))
                               {
                                   if (pictureBox7.Tag.ToString().Equals(str6))
                                   {
                                       if (pictureBox8.Tag.ToString().Equals(str7))
                                       {
                                           if (pictureBox9.Tag.ToString().Equals(str8))
                                           {
                                             }
                                       }
                                   }
                               }
                           }
                         }
                     }
                 }
               MessageBox.Show(pictureBox2.Tag.ToString() + " " + pictureBox3.Tag.ToString() + "  " + pictureBox4.Tag.ToString() + "  " + pictureBox5.Tag.ToString()
               + "  " + pictureBox6.Tag.ToString() + "  " + pictureBox7.Tag.ToString() + "  " + pictureBox8.Tag.ToString() + "  " + pictureBox9.Tag.ToString());
            */

            this.pictureBox10.Image = Image.FromFile("10.jpg");
            MessageBox.Show(" YOU WIN AND CLICK StART BUTTON TO PLAY AGAIN ");

            value = false;
          }
        private void button3_Click(object sender, EventArgs e)
        {
            value = true;
            this.pictureBox2.Enabled = true;
            this.pictureBox3.Enabled = true;
            this.pictureBox4.Enabled = true;
            this.pictureBox5.Enabled = true;
            this.pictureBox6.Enabled = true;
            this.pictureBox7.Enabled = true;
            this.pictureBox8.Enabled = true;
            this.pictureBox9.Enabled = true;
            this.pictureBox10.Enabled = true;


            int Rand = 0;
            int counter = 0;
            int[] array1 = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image =null;
            pictureBox6.Image = null;


            for (int i = 0; i < 50; i++)
            {
                Rand = random.Next(2, 10);
                if (array1.Contains(Rand))
                {

                }
                else
                {
                    array1[counter] = Rand;
                    if (counter == 7)
                    {
                        break;
                    }
                    counter++;
                }
            }
            pictureBox2.Image = Image.FromFile(array1[0] + ".JPG");
            pictureBox2.Tag = array1[0];
          
            pictureBox3.Image = Image.FromFile(array1[1] + ".JPG");
            pictureBox3.Tag = array1[1];

            pictureBox4.Image = Image.FromFile(array1[2] + ".JPG");
            pictureBox4.Tag = array1[2];

            pictureBox5.Image = Image.FromFile(array1[3] + ".JPG");
            pictureBox5.Tag = array1[3];

            pictureBox10.Image = Image.FromFile(array1[4] + ".JPG");
            pictureBox10.Tag = array1[4];

            pictureBox7.Image = Image.FromFile(array1[5] + ".JPG");
            pictureBox7.Tag = array1[5];

            pictureBox8.Image = Image.FromFile(array1[6] + ".JPG");
            pictureBox8.Tag = array1[6];
           
            pictureBox9.Image = Image.FromFile(array1[7] + ".JPG");
            pictureBox9.Tag = array1[7];

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (value == true)
              { 
                int Rand = 0;
                int counter = 0;
                int[] array1 = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox6.Image = null;


                for (int i = 0; i < 50; i++)
                {
                    Rand = random.Next(2, 10);
                    if (array1.Contains(Rand))
                    {

                    }
                    else
                    {
                        array1[counter] = Rand;
                        if (counter == 7)
                        {
                            break;
                        }
                        counter++;
                    }
                }
                pictureBox2.Image = Image.FromFile(array1[0] + ".JPG");

                pictureBox3.Image = Image.FromFile(array1[1] + ".JPG");

                pictureBox4.Image = Image.FromFile(array1[2] + ".JPG");

                pictureBox5.Image = Image.FromFile(array1[3] + ".JPG");

                pictureBox10.Image = Image.FromFile(array1[4] + ".JPG");

                pictureBox7.Image = Image.FromFile(array1[5] + ".JPG");

                pictureBox8.Image = Image.FromFile(array1[6] + ".JPG");

                pictureBox9.Image = Image.FromFile(array1[7] + ".JPG");

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            }
        
    }
}
