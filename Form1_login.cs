using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holaMun
{
    public partial class Form1 : Form
    {
        private int intento = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = ctUsuario.Text;
            string clave = ctContraseña.Text;

            if (usuario == "admin" && clave == "admin123")
            {
                MessageBox.Show("Bienvenido, " + usuario);
                intento = 0; // Reinicia
            }
            else
            {
                intento++;
                MessageBox.Show("Contraseña incorrecta. Intento " + intento + " de 3.");

                if (intento >= 3)
                {
                    MessageBox.Show("Has superado el número máximo de intentos.");
                    btIniciar.Enabled = false;
                    Close();
                }
            }
        }

        private void laContraseña_Click(object sender, EventArgs e)
        {
            
        }
    }
}
