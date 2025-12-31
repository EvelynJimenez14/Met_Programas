using System;
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

        private void btnCalcularLagrange_Click(object sender, EventArgs e)
        {
            try
            {
                dgvLagrange.Rows.Clear();
                dgvLagrange.Columns.Clear();

                double[] x = txtPuntosX.Text.Split(',').Select(s => double.Parse(s.Trim())).ToArray();
                double[] y = txtPuntosY.Text.Split(',').Select(s => double.Parse(s.Trim())).ToArray();
                double xInt = double.Parse(txtValorAInterpolar.Text);

                if (x.Length != y.Length)
                {
                    MessageBox.Show("X y Y deben tener la misma cantidad de puntos.");
                    return;
                }

                
                double resultado = Interpolacion.InterpolarLagrange(x, y, xInt);

                dgvLagrange.Columns.Add("colIndex", "i");
                dgvLagrange.Columns.Add("colLi", "L_i(x)");
                dgvLagrange.Columns.Add("colTerm", "y_i * L_i(x)");

                for (int i = 0; i < x.Length; i++)
                {
                    double Li = 1;
                    for (int j = 0; j < x.Length; j++)
                    {
                        if (i != j)
                            Li *= (xInt - x[j]) / (x[i] - x[j]);
                    }
                    double term = y[i] * Li;

                    int rowIdx = dgvLagrange.Rows.Add();
                    dgvLagrange.Rows[rowIdx].Cells[0].Value = i;
                    dgvLagrange.Rows[rowIdx].Cells[1].Value = Math.Round(Li, 6);
                    dgvLagrange.Rows[rowIdx].Cells[2].Value = Math.Round(term, 6);
                }

                MessageBox.Show($"Resultado de la interpolación en x={xInt}: {resultado:F6}");
            }
            catch
            {
                MessageBox.Show("Error: Use comas para separar los números.");
            }
        }
    }
}
