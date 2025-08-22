using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro_2prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPeso.Text, out double peso) || peso <= 0)
            {
                MessageBox.Show("Por favor, ingresa un peso válido (número mayor que 0).");
                return;
            }

            if (!double.TryParse(txtAltura.Text, out double altura) || altura <= 0)
            {
                MessageBox.Show("Por favor, ingresa una altura válida (número mayor que 0).");
                return;
            }

           
            double imc = peso / (altura * altura);
            string categoria;

            if (imc < 18.5)
                categoria = "Bajo peso";
            else if (imc >18.5 || imc <= 24.9)
                categoria = "Peso normal";
            else if (imc < 25.0 || imc <= 29.9)
                categoria = "Sobrepeso";
            else
                categoria = "Obesidad";

            // Mostrar resultado
            lblResultado.Text = $"IMC: {imc} - {categoria}";
        }
    }
}
