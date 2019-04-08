using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2;
        string op;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text== "")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }
            MessageBox.Show("INgresaste el boton 1");
        }

        private void btnclean_Click(object sender, EventArgs e)//LImpiar pantalla
        {
            num1 = 0;
            num2 = 0;
            txtpantalla.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtpantalla.Text);
            //num2 = double.Parse(txtpantalla.Text);
            op = "/";
            this.txtpantalla.Clear();//limpiar pantalla
            txtpantalla.Focus();//Regrese a la pantalla una vez que se presiono un boton
        }

        private void btnmul_Click(object sender, EventArgs e)
        {num1 = double.Parse(txtpantalla.Text);
            //num2 = double.Parse(txtpantalla.Text);
            op = "x";
            this.txtpantalla.Clear();//limpiar pantalla
            txtpantalla.Focus();

        }

        private void btnsuman_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtpantalla.Text);
            //num2 = double.Parse(txtpantalla.Text);
            op = "+";
            this.txtpantalla.Clear();//limpiar pantalla
            txtpantalla.Focus();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtpantalla.Text);
            op = "-";
            this.txtpantalla.Clear();//limpiar pantalla
            txtpantalla.Focus();
        }

        private void btnigual_Click(object sender, EventArgs e)//Boton de igual
        {
            num2 = double.Parse(txtpantalla.Text);
            switch (op)
            {case "+":
                    txtpantalla.Text = Convert.ToString(num1 + num2);
                    break;
                case "x":
                    txtpantalla.Text = Convert.ToString(num1 * num2);
                    break;
                case"/":
                    txtpantalla.Text = Convert.ToString(num1/num2);
                    break;
                case "-":
                    txtpantalla.Text = Convert.ToString(num1-num2);
                    break;
                default:
                    break;
            }

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text.Contains('.')== false)
            {
                txtpantalla.Text = txtpantalla.Text + ".";
            }
        }

        private void txtpantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!='.')
            {
                e.Handled = true;
            }
            if (e.KeyChar=='.'&& txtpantalla.Text.IndexOf('.')>-1)
            {
                 e.Handled = true;
            }
        }

        
    }
}
