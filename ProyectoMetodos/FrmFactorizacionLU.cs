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
                dgvA.ColumnCount = n; dgvA.RowCount = n;
                dgvB.ColumnCount = 1; dgvB.RowCount = n;
                dgvL.ColumnCount = n; dgvL.RowCount = n;
                dgvU.ColumnCount = n; dgvU.RowCount = n;
                dgvA.AllowUserToAddRows = false;
                dgvB.AllowUserToAddRows = false;
            }
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
                    for (int j = 0; j < n; j++) A[i, j] = Convert.ToDouble(dgvA.Rows[i].Cells[j].Value);
                    B[i] = Convert.ToDouble(dgvB.Rows[i].Cells[0].Value);
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
            catch { MessageBox.Show("Error en los datos."); }
        }
    }
}