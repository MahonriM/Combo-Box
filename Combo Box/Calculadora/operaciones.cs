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
    public partial class operaciones : Form
    {
        public operaciones()
        {
            InitializeComponent();
        }
        int num1, num2,resultado;
        
        private void radiosuma_CheckedChanged(object sender, EventArgs e)
        {
            lblop.Text = ("+");
            try
            {
                num1 = int.Parse(txtnum1.Text);
                num2 = int.Parse(txtnum2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Solo se aceptan numeros");
            }
            
            if (radiosuma.Checked==true)
            {   resultado = num1 + num2;
                txtresultado.Text=(""+resultado);
            }
            


        }

        private void radioresta_CheckedChanged(object sender, EventArgs e)
        {
            lblop.Text = "-";
            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            if (radioresta.Checked==true)
            {
                resultado = num1 - num2;
                txtresultado.Text = ("" + resultado);
                
            }
            

        }

        private void radiomultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            lblop.Text = "x";
            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            if (radiomultiplicacion.Checked==true)
            {
                resultado = num1 * num2;
                txtresultado.Text=(""+resultado);
            }
           
        }

        private void radioDivision_CheckedChanged(object sender, EventArgs e)
        {
            lblop.Text = "/";
            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            if (radioDivision.Checked==true)
            {
                resultado = num1 / num2;
                txtresultado.Text=(""+resultado);
                
            }
            
        }

    }
}
