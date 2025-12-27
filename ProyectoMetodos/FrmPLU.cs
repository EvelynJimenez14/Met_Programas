using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmPLU : Form
    {
        public FrmPLU()
        {
            InitializeComponent();
            ConfigurarTablas(3); // Inicia con 3x3 por defecto
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            int n = (int)numTamano.Value;
            ConfigurarTablas(n);
        }

        private void ConfigurarTablas(int n)
        {
            // Función para configurar cualquier Grid de forma dinámica
            Action<DataGridView> prepararGrid = (dgv) => {
                dgv.Columns.Clear();
                dgv.RowCount = n;
                dgv.ColumnCount = n;
                for (int i = 0; i < n; i++)
                {
                    dgv.Columns[i].Width = 40; // Ancho de celda profesional
                    dgv.Columns[i].HeaderText = (i + 1).ToString();
                }
                dgv.AllowUserToAddRows = false;
            };

            prepararGrid(dgvA);
            prepararGrid(dgvL);
            prepararGrid(dgvU);
            prepararGrid(dgvP);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)numTamano.Value;
                double[,] A = new double[n, n];

                // Leer matriz A
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        A[i, j] = Convert.ToDouble(dgvA.Rows[i].Cells[j].Value);

                // Llamada a tu clase Matrices (Paso a paso)
                Matrices.FactorizacionPLU(A, n, out double[,] L, out double[,] U, out double[,] P);

                // Mostrar resultados
                LlenarGrid(dgvL, L, n);
                LlenarGrid(dgvU, U, n);
                LlenarGrid(dgvP, P, n);
                lblStatus.Text = "PA = LU Calculado correctamente.";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LlenarGrid(DataGridView dgv, double[,] mat, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dgv.Rows[i].Cells[j].Value = Math.Round(mat[i, j], 4);
        }
    }
}