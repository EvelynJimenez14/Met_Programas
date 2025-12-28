using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmFactorizacionLU : Form
    {
        public FrmFactorizacionLU()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n) && n > 1)
            {
                ConfigurarGrid(dgvA, n, n, "A");
                ConfigurarGrid(dgvB, n, 1, "B");
                ConfigurarGrid(dgvL, n, n, "L");
                ConfigurarGrid(dgvU, n, n, "U");
            }
        }

        private void ConfigurarGrid(DataGridView dgv, int filas, int columnas, string nombre)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ColumnCount = columnas;
            dgv.RowCount = filas;
            for (int j = 0; j < columnas; j++) dgv.Columns[j].Width = 50;
            dgv.TopLeftHeaderCell.Value = nombre;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dgvA.RowCount;
                double[,] A = new double[n, n];
                double[] B = new double[n];
                double[,] L = new double[n, n];
                double[,] U = new double[n, n];

                for (int i = 0; i < n; i++)
                {
                    if (!double.TryParse(dgvB.Rows[i].Cells[0].Value?.ToString(), out B[i]))
                        throw new Exception($"Error en B[{i}]");

                    for (int j = 0; j < n; j++)
                    {
                        if (!double.TryParse(dgvA.Rows[i].Cells[j].Value?.ToString(), out A[i, j]))
                            throw new Exception($"Error en A[{i},{j}]");
                    }
                }

                Matrices.FactorizarLU(A, L, U, n);
                double[] X = Matrices.ResolverLU(L, U, B, n);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dgvL.Rows[i].Cells[j].Value = L[i, j].ToString("N4");
                        dgvU.Rows[i].Cells[j].Value = U[i, j].ToString("N4");
                    }
                }
                lblResultado.Text = "X = [" + string.Join(" | ", X) + "]";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Crítico: " + ex.Message);
            }
        }
    }
}