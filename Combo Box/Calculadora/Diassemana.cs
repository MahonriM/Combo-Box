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
    public partial class Diassemana : Form
    {
        public Diassemana()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object elemento = listBox1.SelectedItem;
            textBox1.Text = elemento.ToString();
            if (listBox1.SelectedIndex < 0) return;
            string s = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                s = s + listBox1.SelectedItems[i].ToString() + Environment.NewLine;
            MessageBox.Show(s);
        }
    }
}
