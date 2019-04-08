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
    public partial class Combobox : Form
    {
        public Combobox()
        {
            InitializeComponent();
        }
        int indice;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtadd.Text.Length != 0)
            {
                CMB.Items.Add(txtadd.Text);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (CMB.SelectedIndex < 0) return;
            CMB.Items.RemoveAt(CMB.SelectedIndex);
        }

        private void btnvaciar_Click(object sender, EventArgs e)
        {
            if (btnvaciar.Enabled==true)
            {
                CMB.Items.Clear();
            }
            
        }

        private void btnverelemento_Click(object sender, EventArgs e)
        {
            indice = CMB.SelectedIndex;

            MessageBox.Show(indice.ToString());
            
        }

        private void btnindice_Click(object sender, EventArgs e)
        {
            indice = CMB.SelectedIndex;
            MessageBox.Show(CMB.Items[indice].ToString());

        }
    }
}
