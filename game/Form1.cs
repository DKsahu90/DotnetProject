using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool flag = false;
        private void button10_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                maskedTextBox1.Text = "00:00";
                sec = 0;
                min = 0;
            }
           
                timer1.Start();
                label3.Text = "Best of Luck...";
                button1.Text = "5";
                button2.Text = "2";
                button3.Text = "8";
                button4.Text = "4";
                button5.Text = "";
                button6.Text = "1";
                button7.Text = "6";
                button8.Text = "7";
                button9.Text = "3";
            
            button10.Enabled = false;
            button11.Enabled = true;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            sec = min = 0;
            timer1.Stop();
            label3.Text = "Best of Luck...";
            button1.Text = "5";
            button2.Text = "2";
            button3.Text = "8";
            button4.Text = "4";
            button5.Text = "";
            button6.Text = "1";
            button7.Text = "6";
            button8.Text = "7";
            button9.Text = "3";
            button11.Enabled = false;
            button10.Enabled = true;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button2.Text=="")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            else if(button6.Text=="")
            {
                button6.Text = button1.Text;
                button1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button1.Text=="")
            {
                button1.Text = button2.Text;
                button2.Text = "";

            }
            else if(button5.Text=="")
            {
                button5.Text = button2.Text;
                button2.Text = "";
            }
            else if(button3.Text=="")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";

            }
            else if (button5.Text == "")
            {
                button5.Text = button8.Text;
                button8.Text = "";
            }
            else if (button9.Text == "")
            {
                button9.Text = button8.Text;
                button8.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button6.Text;
                button6.Text = "";

            }
            else if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
            else if (button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = button4.Text;
                button4.Text = "";

            }
            else if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }
            else if (button3.Text == "")
            {
                button3.Text = button4.Text;
                button4.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";

            }
            else if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }
            else if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }
            else if(button8.Text=="")
            {
                button8.Text = button5.Text;
                button5.Text = "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button9.Text;
                button9.Text = "";
            }
            else if (button8.Text == "")
            {
                button8.Text = button9.Text;
                button9.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (button4.Text == "")
            {
                button4.Text = button7.Text;
                button7.Text = "";
            }
            else if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
            if((button1.Text=="1") && (button2.Text=="2")&&(button3.Text=="3")&&(button6.Text=="4")&&(button5.Text=="5")&&(button4.Text=="6")&&(button9.Text=="7")&&(button8.Text=="8"))
            {
                MessageBox.Show("Winner... You have Crossed level 1 for next Level visit DIlip sahu...");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            else if (button4.Text == "")
            {
                button4.Text = button3.Text;
                button3.Text = "";
            }
        }
       
        private void button12_Click(object sender, EventArgs e)
        {
            string caption = "Confirmation Box";
            DialogResult dr=MessageBox.Show("sure Do You want to Close the Game...",caption,MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                timer1.Stop();
            }
        }
        int sec, min; string secstr, minstr;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sec<59)
                sec+=1;
            else
            {
                sec = 0;
                min += 1;
            }
            if(sec<10)
            {
                secstr = "0" + sec.ToString();
            }
            else
            {
                secstr=sec.ToString();
            }
            if(min<10)
            {
                minstr = "0" + min.ToString();
            }
            else
            {
                minstr = min.ToString();
            }
            maskedTextBox1.Text = minstr + secstr;
            if (maskedTextBox1.Text == "04:00")
            {
                flag = true;
                timer1.Stop();
                maskedTextBox1.Text = "00:00";
                MessageBox.Show(" Sorry Time Overed.....Try again");
               
                button10.Enabled = true;
            }
        }
    }
}
