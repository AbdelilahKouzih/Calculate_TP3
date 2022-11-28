using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_TP3
{
   

    public partial class Form1 : Form
    {

        private decimal firstvalue = 0.0m;
        private decimal Secondvalue = 0.0m;
        private decimal resultat = 0.0m;

        private string operation ="-";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtb.Text=="0")

            { 
                txtb.Text="0"; 
                lbl1.Text="0";
            }
            else
            {
                txtb.Text+="0";
                lbl1.Text+="0";
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if(!txtb.Text.Contains(".")) 
            {
                txtb.Text += ".";
                lbl1.Text = ".";
            }
           
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            if(txtb.Text=="0") 
            {
              txtb.Text="1";
                lbl1.Text="1";
            }
            else
            {
                txtb.Text+="1";
                lbl1.Text+="1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                txtb.Text = "2";
                lbl1.Text="2";
            }
            else
            {
                txtb.Text += "2";
                lbl1.Text+="2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                txtb.Text = "3";
                lbl1.Text="3";
            }
            else
            {
                txtb.Text += "3";
                lbl1.Text+="3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                txtb.Text = "4";
                lbl1.Text="4";
            }
            else
            {
                txtb.Text += "4";
                lbl1.Text+="4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                txtb.Text = "5";
                lbl1.Text="5";
            }
            else
            {
                txtb.Text += "5";
                    lbl1.Text+="5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                txtb.Text = "6";
                lbl1.Text="6";
            }
            else
            {
                txtb.Text += "6";
                lbl1.Text+="6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                txtb.Text = "7";
                lbl1.Text = "7";
            }
            else
            {
                txtb.Text += "7";
                lbl1.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                txtb.Text = "8";
                lbl1.Text = "8";
            }
            else
            {
                txtb.Text += "8";
                lbl1.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                txtb.Text = "9";
                lbl1.Text = "9";
            }
            else
            {
                txtb.Text += "9";
                lbl1.Text += "9";
            }
        }

        private void btnmoins_Click(object sender, EventArgs e)
        {
            firstvalue = Decimal.Parse(txtb.Text);
            txtb.Clear();
            operation = "-";
            lbl1.Text += "-";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            firstvalue = Decimal.Parse(txtb.Text);
            txtb.Clear();
            operation = "+";
            lbl1.Text += "+";
        }

        private void btnfois_Click(object sender, EventArgs e)
        {
            firstvalue = Decimal.Parse(txtb.Text);
            txtb.Clear();
            operation = "*";
            lbl1.Text += "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {

            firstvalue = Decimal.Parse(txtb.Text);
            txtb.Clear();
            operation = "/";
            lbl1.Text += "/";
        }

        private void btnegal_Click(object sender, EventArgs e)
        {
            lbl1.Text += "=";
            switch (operation)
            {
                case "-":
                    Secondvalue=Decimal.Parse(txtb.Text);
                    resultat = firstvalue - Secondvalue;
                    txtb.Text = resultat.ToString();
                    break;
                case "+":
                    Secondvalue = Decimal.Parse(txtb.Text);
                    resultat = firstvalue + Secondvalue;
                    txtb.Text = resultat.ToString();
                    break;
                case "*":
                    Secondvalue = Decimal.Parse(txtb.Text);
                    resultat = firstvalue * Secondvalue;
                    txtb.Text = resultat.ToString();
                    break;
                case "/":
                    Secondvalue = Decimal.Parse(txtb.Text);
                    if(Secondvalue!=0)
                    { 
                    resultat = firstvalue / Secondvalue;
                    txtb.Text = resultat.ToString();
                    }
                    else
                    {
                        txtb.Text = "we can't divise by 0 !!!";
                    }
                    break;

            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            Secondvalue= 0.0m;
            firstvalue = 0.0m;
            txtb.Text = "0";
            lbl1.Text="";
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.NumPad0) 
            {
               btn0.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                bttn1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                btn2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                btn3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                btn4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                btn5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                btn6.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                btn1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                btn8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                btn9.PerformClick();
            }
          
           


        }
    }
}
