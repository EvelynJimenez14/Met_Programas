using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Met_Pivoteo : Form
    {
        public Met_Pivoteo()
        {
            InitializeComponent();
            ConfigurarCombo();
        }

        private void ConfigurarCombo()
        {
            cmbTipoPivoteo.Items.AddRange(new string[] { "Pivoteo Parcial", "Pivoteo Escalado", "Pivoteo Total" });
            cmbTipoPivoteo.SelectedIndex = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n) && n > 1)
            {
                dgvMatriz.AllowUserToAddRows = false;
                dgvMatriz.ColumnCount = n + 1;
                dgvMatriz.Rows.Clear();
                dgvMatriz.RowCount = n;

                for (int i = 0; i < n; i++)
                {
                    dgvMatriz.Columns[i].HeaderText = "X" + (i + 1);
                    dgvMatriz.Columns[i].Width = 60;
                }
                dgvMatriz.Columns[n].HeaderText = "B";
                dgvMatriz.Columns[n].DefaultCellStyle.BackColor = Color.LightGray;

                dgvResultado.Rows.Clear();
                dgvResultado.ColumnCount = 0;
                lblOrden.Text = "Orden: ---";
            }
            else
            {
                MessageBox.Show("Ingresa un número entero válido mayor a 1.");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dgvMatriz.RowCount;
                double[,] A = new double[n, n];
                double[] B = new double[n];
                int[] orden = new int[n];

                for (int i = 0; i < n; i++) orden[i] = i + 1;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (dgvMatriz.Rows[i].Cells[j].Value == null) throw new Exception();
                        A[i, j] = Convert.ToDouble(dgvMatriz.Rows[i].Cells[j].Value);
                    }
                    if (dgvMatriz.Rows[i].Cells[n].Value == null) throw new Exception();
                    B[i] = Convert.ToDouble(dgvMatriz.Rows[i].Cells[n].Value);
                }

                for (int etapa = 0; etapa < n - 1; etapa++)
                {
                    switch (cmbTipoPivoteo.SelectedIndex)
                    {
                        case 0: Pivoteo.Parcial(A, B, etapa, n); break;
                        case 1: Pivoteo.Escalado(A, B, etapa, n); break;
                        case 2: Pivoteo.Total(A, B, etapa, n, orden); break;
                    }

                    
                    for (int i = etapa + 1; i < n; i++)
                    {
                        double factor = A[i, etapa] / A[etapa, etapa];
                        for (int j = etapa; j < n; j++)
                            A[i, j] -= factor * A[etapa, j];
                        B[i] -= factor * B[etapa];
                    }
                }
                MostrarResultado(A, B, n, orden);
            }
            catch
            {
                MessageBox.Show("Error: Llena todas las celdas con números válidos.");
            }
        }

        private void MostrarResultado(double[,] A, double[] B, int n, int[] orden)
        {
            dgvResultado.AllowUserToAddRows = false;
            dgvResultado.ColumnCount = n + 1;
            dgvResultado.Rows.Clear();
            dgvResultado.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                dgvResultado.Columns[i].HeaderText = "X" + (i + 1);
                dgvResultado.Columns[i].Width = 60;
                for (int j = 0; j < n; j++)
                {
                    dgvResultado.Rows[i].Cells[j].Value = A[i, j];
                }
                dgvResultado.Rows[i].Cells[n].Value = B[i];
            }
            dgvResultado.Columns[n].HeaderText = "B";
            
        }
    }
}