using System;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Derivacion : Form
    {
        public Derivacion()
        {
            InitializeComponent();
            ConfigurarCombo();
        }

        private void ConfigurarCombo()
        {
            cmbMetodo.Items.Clear();
            cmbMetodo.Items.Add("2 Puntos (Adelante)");
            cmbMetodo.Items.Add("2 Puntos (Atrás)");
            cmbMetodo.Items.Add("3 Puntos (Centrada)");
            cmbMetodo.Items.Add("3 Puntos (Extremos/Adelante)");
            cmbMetodo.Items.Add("3 Puntos (Atrás)");
            cmbMetodo.Items.Add("5 Puntos (Centrada)");
            cmbMetodo.Items.Add("Diferente h (2 puntos)"); 
            cmbMetodo.SelectedIndex = 0;
        }

        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bool esHVariable = (cmbMetodo.SelectedIndex == 6);

            
            lblY0.Visible = txtY0.Visible = esHVariable;
            lblX1.Visible = txtX1.Visible = esHVariable;
            lblY1.Visible = txtY1.Visible = esHVariable;

            
            lblH.Visible = txtH.Visible = !esHVariable;

            lblX0.Text = esHVariable ? "x0:" : "Punto x0:";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float x0 = float.Parse(txtX0.Text);
                float resultado = 0;

                if (cmbMetodo.SelectedIndex < 6)
                {
                    float h = float.Parse(txtH.Text);
                    switch (cmbMetodo.SelectedIndex)
                    {
                        case 0: resultado = Derivadas_Numericas.Derivada_Dos_Puntos(x0, h); break;
                        case 1: resultado = Derivadas_Numericas.Derivada_Dos_Puntos_Atras(x0, h); break;
                        case 2: resultado = Derivadas_Numericas.Derivada_Tres_Puntos_Centrada(x0, h); break;
                        case 3: resultado = Derivadas_Numericas.Derivada_Tres_Puntos(x0, h); break;
                        case 4: resultado = Derivadas_Numericas.Derivada_Tres_Puntos_Atras(x0, h); break;
                        case 5: resultado = Derivadas_Numericas.Derivada_Cinco_Puntos_Centrada(x0, h); break;
                    }
                }
                else
                {
                    
                    float y0 = float.Parse(txtY0.Text);
                    float x1 = float.Parse(txtX1.Text);
                    float y1 = float.Parse(txtY1.Text);
                    resultado = (y1 - y0) / (x1 - x0);
                }

                lblResultado.Text = $"f'({x0}) ≈ {resultado.ToString("N6")}";
            }
            catch { MessageBox.Show("Verifica que los datos ingresados sean correctos."); }
        }
    }
}