using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmNeville : Form
    {
        public FrmNeville()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer datos de entrada (Ej: 1, 2, 3)
                double[] x = txtX.Text.Split(',').Select(double.Parse).ToArray();
                double[] y = txtY.Text.Split(',').Select(double.Parse).ToArray();
                double targetX = double.Parse(txtTarget.Text);
                int n = x.Length;

                // Matriz para la tabla de Neville (Q)
                double[,] Q = new double[n, n];

                // Inicializar la primera columna con los valores de f(x)
                for (int i = 0; i < n; i++)
                {
                    Q[i, 0] = y[i];
                }

                // Algoritmo de Neville: P(x) = [(x-xj)Qi,j-1 - (x-xi)Qi-1,j-1] / (xi-xj)
                for (int j = 1; j < n; j++)
                {
                    for (int i = j; i < n; i++)
                    {
                        Q[i, j] = ((targetX - x[i - j]) * Q[i, j - 1] - (targetX - x[i]) * Q[i - 1, j - 1]) / (x[i] - x[i - j]);
                    }
                }

                // Mostrar la tabla en el DataGridView
                MostrarTabla(Q, n);
                lblResultado.Text = $"Resultado P({targetX}) = " + Math.Round(Q[n - 1, n - 1], 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Verifique que x, y tengan la misma cantidad de datos separados por comas.\n" + ex.Message);
            }
        }

        private void MostrarTabla(double[,] Q, int n)
        {
            dgvNeville.ColumnCount = n;
            dgvNeville.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                dgvNeville.Columns[i].HeaderText = $"Grado {i}";
                for (int j = 0; j <= i; j++)
                {
                    dgvNeville.Rows[i].Cells[j].Value = Math.Round(Q[i, j], 6);
                }
            }
        }
    }
}