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
    public partial class Metodo_euler : Form
    {
        public Metodo_euler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                float tMax, y0, h;
                EcuaDif metodoEuler = new EcuaDif();  // Crear una instancia de la clase EcuaDif
                int resultado;

                try
                {
                    tMax = float.Parse(tMaxtxt.Text);  // Suponiendo que tienes un TextBox tMaxtxt
                    y0 = float.Parse(y0txt.Text);      // Suponiendo que tienes un TextBox y0txt
                    h = float.Parse(htxt.Text);        // Suponiendo que tienes un TextBox htxt

                    resultado = metodoEuler.MetodoEuler(tMax, y0, h, this.dataGridView1);

                    if (resultado == -1)
                    {
                        MessageBox.Show("Hubo un error en los cálculos con el Método de Euler.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void y0txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void htxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tMaxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Metodo_euler_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
