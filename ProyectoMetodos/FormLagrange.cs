using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FormLagrange : Form
    {
        public FormLagrange()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Procedimiento: Convertimos el texto en arreglos numéricos usando Select
                double[] x = txtX.Text.Split(',').Select(s => double.Parse(s.Trim())).ToArray();
                double[] y = txtY.Text.Split(',').Select(s => double.Parse(s.Trim())).ToArray();
                double valor = double.Parse(txtValor.Text);

                if (x.Length != y.Length)
                {
                    MessageBox.Show("Error: Los arreglos X y Y deben tener el mismo tamaño.");
                    return;
                }

                // Aplicación del polinomio de Lagrange
                double resultado = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    double termino = y[i];
                    for (int j = 0; j < x.Length; j++)
                    {
                        if (j != i)
                        {
                            termino = termino * (valor - x[j]) / (x[i] - x[j]);
                        }
                    }
                    resultado += termino;
                }

                lblResultado.Text = $"Resultado: {resultado:F5}";
            }
            catch
            {
                MessageBox.Show("Error en los datos. Asegúrate de usar números separados por comas.");
            }
        }
    }
}