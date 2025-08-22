using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_clics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            contador_b.Text = $"Clics: {contador}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
