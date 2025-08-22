using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conver_temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnFtoC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTemperatura.Text, out double tempOriginal))
            {
                MessageBox.Show("Por favor, ingresa una temperatura válida.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double resultado;

            if (rbtnCtoF.Checked)
            {
                resultado = (tempOriginal * 9 / 5) + 32;
                lblResultado.Text = $"{tempOriginal} °C = {resultado:F2} °F";
            }
            else if (rbtnFtoC.Checked)
            {
                resultado = (tempOriginal - 32) * 5 / 9;
                lblResultado.Text = $"{tempOriginal} °F = {resultado:F2} °C";
            }
            else
            {
                MessageBox.Show("Selecciona una opción de conversión.", "Opción faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
