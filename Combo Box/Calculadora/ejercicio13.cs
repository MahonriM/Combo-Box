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
    public partial class ejercicio13 : Form
    {
        public ejercicio13()
        {
            InitializeComponent();
        }

        private void radiohombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radiohombre.Checked==true)
            {
                MessageBox.Show("Haz seleccionado el sexo de hombre");
            }
            if (radiomujer.Checked==true)
            {
                
            }
        }
    }
}
