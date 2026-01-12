using System;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmIntegracionMultiple : Form
    {
        public FrmIntegracionMultiple()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Integracion motor = new Integracion();
                
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                int d = int.Parse(txtD.Text);

                // Número de subintervalos
                int n = int.Parse(txtN.Text);
                int m = int.Parse(txtM.Text);

                double resultado = 0;

                if (rbTrapecio.Checked)
                {
                    resultado = motor.IntegralDoble_trapecio(a, b, n, c, d, m);
                }
                else if (rbSimpson.Checked)
                {
                    resultado = motor.IntegralDoble_Simpson(a, b, n, c, d, m);
                }

                lblResultado.Text = $"Resultado: {resultado:N10}";
            }
            catch
            {
                MessageBox.Show("Error: Verifique que todos los campos sean numéricos.", "Entrada Inválida");
            }
        }
    }
}