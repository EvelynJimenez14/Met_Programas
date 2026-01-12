using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Eliminacion_Gaussiana : Form
    {
        public int NumIncog;
        public float[,] MatrizAum;

        public Eliminacion_Gaussiana()
        {
            InitializeComponent();
        }

        private void Eliminacion_Gaussiana_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NumIncogtxt_TextChanged(object sender, EventArgs e)
        {
            int i;
            NumIncog = int.Parse(NumIncogtxt.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (i = 0; i <= NumIncog; i++)
                dataGridView1.Columns.Add($"col_{i}", i == NumIncog ? "Resultado" : $"X{i + 1}");
            for (i = 0; i < NumIncog; i++)
                dataGridView1.Rows.Add();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MatrizAum = new float[NumIncog, NumIncog + 1];
                for (int i = 0; i < NumIncog; i++)
                {
                    for (int j = 0; j <= NumIncog; j++)
                    {
                        MatrizAum[i, j] = float.Parse(dataGridView1.Rows[i].Cells[j].Value?.ToString());
                    }
                }

                Sist_Ec_Lineales ecuacionesLineales = new Sist_Ec_Lineales();


                if (gaussRB.Checked)
                {
                    if (ecuacionesLineales.eliminacion_gaussiana(MatrizAum, NumIncog))
                    {
                        float[] soluciones = ecuacionesLineales.SustitucionHaciaAtras(MatrizAum, NumIncog);
                        string resultados = string.Join(Environment.NewLine, soluciones.Select((x, idx) => $"X{idx + 1} = {x:F4}"));
                        MessageBox.Show($"Eliminación gaussiana realizada con éxito.\n\nResultados:\n{resultados}", "Éxito");
                        Resultado();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar la eliminación gaussiana.");
                    }

                }
                
                

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void Resultado()
        {
            int i, j;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            for (i = 0; i <= NumIncog; i++)
                dataGridView2.Columns.Add($"col_{i}", i == NumIncog ? "Resultado" : $"X{i + 1}");
            for (i = 0; i < NumIncog; i++)
                dataGridView2.Rows.Add();

            for (i = 0; i < NumIncog; i++)
            {
                for (j = 0; j <= NumIncog; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = MatrizAum[i, j].ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Función auxiliar para convertir una matriz a texto y mostrarla en MessageBox
        private string ImprimirMatriz(float[,] matriz, int n)
        {
            string texto = "";
            for (int i = 0; i < n; i++)
            {
                texto += "| ";
                for (int j = 0; j < n; j++)
                {
                    // F4 redondea a 4 decimales, \t agrega un tabulador para separar
                    texto += matriz[i, j].ToString("F4") + "\t";
                }
                texto += " |\n";
            }
            return texto;
        }
    }

}

