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
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                int n = int.Parse(txtN.Text);
                double c = double.Parse(txtC.Text);
                double d = double.Parse(txtD.Text);
                int m = int.Parse(txtM.Text);

                Integracion motor = new Integracion();
                double resultado = 0;

                if (rbTrapecio.Checked)
                {
                    resultado = motor.IntegralDoble_trapecio(a, b, c, d, n, m);
                    lblResultado.Text = $"Res (Trapecio): {resultado:N8}";
                }
                else
                {
                    if (n % 2 != 0 || m % 2 != 0)
                    {
                        MessageBox.Show("n y m deben ser pares.");
                        return;
                    }
                    resultado = motor.IntegralDoble_Simpson(a, b, c, d, n, m);
                    lblResultado.Text = $"Res (Simpson): {resultado:N8}";
                }
            }
            catch { MessageBox.Show("Error en datos"); }
        }
    }
}