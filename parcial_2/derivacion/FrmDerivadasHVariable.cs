using System;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class FrmDerivadasHVariable : Form
    {
        public FrmDerivadasHVariable()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.Rows.Clear();

                
                double x0 = double.Parse(txtX0.Text);
                double y0 = double.Parse(txtY0.Text);
                double x1 = double.Parse(txtX1.Text);
                double y1 = double.Parse(txtY1.Text);
                double x2 = double.Parse(txtX2.Text);
                double y2 = double.Parse(txtY2.Text);

                
                double d2 = Derivadas_Numericas.Derivada_H_Variable((float)x0, (float)y0, (float)x1, (float)y1);

             
                double d3 = Derivadas_Numericas.Derivada_Tres_Puntos_HVariable((float)x0, (float)y0, (float)x1, (float)y1, (float)x2, (float)y2);

                dgvResultados.Rows.Add(
                    x0.ToString("F4"),
                    y0.ToString("F6"),
                    d2.ToString("F6"),
                    d3.ToString("F6")
                );
            }
            catch
            {
                MessageBox.Show("Error en los datos de entrada.");
            }
        }
    }
}
