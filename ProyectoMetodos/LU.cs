using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmLU : Form
    {
        public FrmLU()
        {
            InitializeComponent();
            ConfigurarTablas(3); // Inicia con un tamaño estándar de 3x3
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            int n = (int)numTamano.Value;
            ConfigurarTablas(n);
        }

        private void ConfigurarTablas(int n)
        {
         
            Action<DataGridView> prepararGrid = (dgv) => {
                dgv.Columns.Clear();
                dgv.ColumnCount = n;
                dgv.RowCount = n;
                for (int i = 0; i < n; i++) dgv.Columns[i].Width = 45;
                dgv.AllowUserToAddRows = false;
            };

            prepararGrid(dgvA);
            prepararGrid(dgvL);
            prepararGrid(dgvU);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)numTamano.Value;
                double[,] A = new double[n, n];

              
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        A[i, j] = Convert.ToDouble(dgvA.Rows[i].Cells[j].Value);

                
                Matrices.FactorizacionLU(A, n, out double[,] L, out double[,] U);

                
                LlenarGrid(dgvL, L, n);
                LlenarGrid(dgvU, U, n);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nRecuerda que LU simple falla si hay ceros en la diagonal.");
            }
        }

        private void LlenarGrid(DataGridView dgv, double[,] mat, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dgv.Rows[i].Cells[j].Value = Math.Round(mat[i, j], 4);
        }
    }
}