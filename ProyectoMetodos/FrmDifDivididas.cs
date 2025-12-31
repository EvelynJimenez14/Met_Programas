using System;
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
                dgvTablaDiferencias.Rows.Clear();
                dgvTablaDiferencias.Columns.Clear();

                double[] x = txtPuntosX.Text.Split(',').Select(s => double.Parse(s.Trim())).ToArray();
                double[] y = txtPuntosY.Text.Split(',').Select(s => double.Parse(s.Trim())).ToArray();
                double xInt = double.Parse(txtValorAInterpolar.Text);
                int n = x.Length;

                if (n != y.Length)
                {
                    MessageBox.Show("X y Y deben tener la misma cantidad de puntos.");
                    return;
                }

                
                double[,] F = Interpolacion.ConstruirTablaNewton(x, y);

                
                double resultado = rbAdelante.Checked
                    ? Interpolacion.InterpolarNewtonAdelante(x, F, xInt)
                    : Interpolacion.InterpolarNewtonAtras(x, F, xInt);

                
                dgvTablaDiferencias.Columns.Add("colX", "Xi");
                dgvTablaDiferencias.Columns.Add("colF", "f(Xi)");
                for (int k = 1; k < n; k++)
                    dgvTablaDiferencias.Columns.Add("colDD" + k, "DD " + k);

                
                if (rbAdelante.Checked)
                {
                    
                    for (int i = 0; i < n; i++)
                    {
                        int rowIdx = dgvTablaDiferencias.Rows.Add();
                        dgvTablaDiferencias.Rows[rowIdx].Cells[0].Value = x[i];
                        for (int j = 0; j < n - i; j++)
                            dgvTablaDiferencias.Rows[rowIdx].Cells[j + 1].Value = Math.Round(F[i, j], 4);
                    }
                }
                else
                {
                    
                    for (int i = n - 1; i >= 0; i--)
                    {
                        int rowIdx = dgvTablaDiferencias.Rows.Add();
                        dgvTablaDiferencias.Rows[rowIdx].Cells[0].Value = x[i];
                        for (int j = 0; j <= i; j++)
                            dgvTablaDiferencias.Rows[rowIdx].Cells[j + 1].Value = Math.Round(F[i - j, j], 4);
                    }
                }

                MessageBox.Show($"Resultado de la interpolación: {resultado:F6}");
            }
            catch
            {
                MessageBox.Show("Error: Use comas para separar los números.");
            }
        }

    }
}
