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

// Hi Friend

namespace pizza_progecte
{
    public partial class Form1 : Form
    {
      
        int price = 0;
        byte size = 0; 
        byte crust = 0;
        bool EatIn = true;



       
        public Form1()
        {
            InitializeComponent();
           


        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form Mune = new Form2();
            this.Hide();
            Mune.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                price += 5;

            }
            if (!radioButton1.Checked)
            {
                price -= 5;
            }
            label1.Text = price.ToString() + "$";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            size = 2;
            if (radioButton2.Checked)
            {
                price += 8;
               
            }
            if (!radioButton2.Checked)
            {
                price -= 8;
            }
            label1.Text = price.ToString() + "$";


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            size = 3;
            if (radioButton3.Checked)
            {
                price += 10;

            }
            if (!radioButton3.Checked)
            {
                price -= 10;
            }
            label1.Text = price.ToString() + "$";
 

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            crust = 1;
            if (radioButton4.Checked)
            {
                price += 5;
               
            }
            if (!radioButton4.Checked)
            {
                price -= 5;
            }
            label1.Text = price.ToString() + "$";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            size = 1;
           if(checkBox1.Checked)
                    { price += 5;
                    label1.Text = price.ToString() + "$";
                }

            if (!checkBox1.Checked)
            {
                price -= 5;
                label1.Text = price.ToString() + "$";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            crust = 2;    
            if (radioButton5.Checked)
            {
                price += 7;

            }
            if (!radioButton5.Checked)
            {
                price -= 7;
            }
            label1.Text = price.ToString() + "$";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                price += 2;

            }
            if(!checkBox2.Checked)
            {
                price -= 2;
            }
            label1.Text = price.ToString() + "$";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                price += 2;

            }
            if (!checkBox3.Checked)
            {
                price -= 2;
            }
            label1.Text = price.ToString() + "$";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                price += 2;

            }
            if (!checkBox6.Checked)
            {
                price -= 2;
            }
            label1.Text = price.ToString() + "$";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                price += 2;

            }
            if (!checkBox5.Checked)
            {
                price -= 2;
            }
            label1.Text = price.ToString() + "$";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                price += 2;

            }
            if (!checkBox4.Checked)
            {
                price -= 2;
            }
            label1.Text = price.ToString() + "$";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked) {

                EatIn = true;
            }

                
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                EatIn = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (size == 0)
            {
                MessageBox.Show("please select a size", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (crust == 0)
            {
                MessageBox.Show("please select a crust", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                if (MessageBox.Show("Are you sure about the order", "conferm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("the order has been confirmed", "thank you");
            }
        }
    }
}
