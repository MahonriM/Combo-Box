using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Covertir_a_Mayusculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox.Checked==true)
            {
                string texto = txtnombre.Text; ;
                txtnombre.Text = texto.ToUpper();
                btnaceptar.Enabled=true;//Propiedad para habilitar boton
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
