using System;
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

        private void btnCalcularNeville_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNeville.Rows.Clear();
                dgvNeville.Columns.Clear();

                double[] x = txtPuntosX.Text.Split(',').Select(s => double.Parse(s.Trim())).ToArray();
                double[] y = txtPuntosY.Text.Split(',').Select(s => double.Parse(s.Trim())).ToArray();
                double xInt = double.Parse(txtValorAInterpolar.Text);

                if (x.Length != y.Length)
                {
                    MessageBox.Show("X y Y deben tener la misma cantidad de puntos.");
                    return;
                }

                double resultado = Interpolacion.InterpolarNeville(x, y, xInt);

                dgvNeville.Columns.Add("colStep", "Paso");
                for (int i = 0; i < x.Length; i++)
                    dgvNeville.Columns.Add("col" + i, $"Q{i}");

                MessageBox.Show($"Resultado de la interpolación: {resultado:F6}");
            }
            catch
            {
                MessageBox.Show("Error: Use comas para separar los números.");
            }
        }
    }
}

