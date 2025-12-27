using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmDifDivididas : Form
    {
        public FrmDifDivididas()
        {
            InitializeComponent();
        }

        private void btnCalcularNewton_Click(object sender, EventArgs e)
        {
            try
            {
                
                double[] x = txtPuntosX.Text.Split(',').Select(double.Parse).ToArray();
                double[] y = txtPuntosY.Text.Split(',').Select(double.Parse).ToArray();
                double xInterpolar = double.Parse(txtValorAInterpolar.Text);
                int n = x.Length;

               
                double[,] F = new double[n, n];

                
                for (int i = 0; i < n; i++)
                {
                    F[i, 0] = y[i];
                }

                
                for (int j = 1; j < n; j++)
                {
                    for (int i = 0; i < n - j; i++)
                    {
                        F[i, j] = (F[i + 1, j - 1] - F[i, j - 1]) / (x[i + j] - x[i]);
                    }
                }

                
                double resultado = F[0, 0];
                double productoX = 1.0;
                for (int i = 1; i < n; i++)
                {
                    productoX *= (xInterpolar - x[i - 1]);
                    resultado += F[0, i] * productoX;
                }

                //Tabla en el DataGridView
                MostrarTablaEnPantalla(F, n);

                MessageBox.Show($"El valor interpolado en x={xInterpolar} es: {resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Revisa que los números estén separados por comas. " + ex.Message);
            }
        }

        private void MostrarTablaEnPantalla(double[,] F, int n)
        {
            dgvTablaDiferencias.Rows.Clear();
            dgvTablaDiferencias.ColumnCount = n;

            for (int i = 0; i < n; i++)
            {
                string[] fila = new string[n];
                for (int j = 0; j < n - i; j++)
                {
                    fila[j] = Math.Round(F[i, j], 4).ToString();
                }
                dgvTablaDiferencias.Rows.Add(fila);
            }
        }

        private void btnCalcularNewton_Click_1(object sender, EventArgs e)
        {

        }
    }
}