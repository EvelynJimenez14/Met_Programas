using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace ProyectoMetodos
{
    internal class Taylor
    {

        public float FormulaTaylor(float x, float x0, float b, float incremento, DataGridView dgvResultado)
        {
            float T;
            float real; 
            int i = 1;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("incremento", "incremento");
            dgvResultado.Columns.Add("Aproximacion", "Taylor");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

            if (incremento <= 0)
            {
                MessageBox.Show("El incremento de x debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            while (x0 <= b)
            {
                real = FuncPrin(x);     // Valor real
                T = FuncPrin(x0); // Aprox

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i;
                dgvResultado.Rows[newRowIdx].Cells[1].Value = x;
                dgvResultado.Rows[newRowIdx].Cells[2].Value = real;
                dgvResultado.Rows[newRowIdx].Cells[3].Value = T;


                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public float FormulaTaylor1(float x, float x0, float b, float incremento, DataGridView dgvResultado)
        {
            float T; // aproximacion con Taylor
            float real; // Sol real
            int i = 1;
            float h;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("incremento", "incremento");
            dgvResultado.Columns.Add("Aproximacion", "Taylor1");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

            if (incremento <= 0)
            {
                MessageBox.Show("El incremento de x debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            while (x0 <= b)
            {
                h = x - x0;
                real = FuncPrin(x);  
                T = FuncPrin(x0) // Término constante
                       + (FuncDer_1(x0) * h); //primer orden

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i; // Iteración
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4); // Valor de x0
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6); // Aprox
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6); //real


                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public float FormulaTaylor2(float x, float x0, float b, float incremento, DataGridView dgvResultado)
        {
            float T; 
            float real;
            int i = 1;
            float h;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("incremento", "x0");
            dgvResultado.Columns.Add("Aproximacion", "Taylor2");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

            if (incremento <= 0)
            {
                MessageBox.Show("El incremento de x debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            while (x0 <= b)
            {
                h = x - x0; // Recalcular h en cada iteración

                real = FuncPrin(x);

                // Aproximación con Taylor de segundo orden
                T = FuncPrin(x0) // Término constante
                       + (FuncDer_1(x0) * h) // primer orden
                       + ((FuncDer_2(x0) / 2) * (float)Math.Pow(h, 2.0)); //segundo orden

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i; // Iteración
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4); // Valor de x0
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6); // Aprox
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6); //real

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public float FormulaTaylor3(float x, float x0, float b, float incremento, DataGridView dgvResultado)
        {
            float T;
            float real;
            int i = 1;
            float h;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("incremento", "x0");
            dgvResultado.Columns.Add("Aproximacion", "Taylor3");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

            if (incremento <= 0)
            {
                MessageBox.Show("El incremento de x debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            while (x0 <= b)
            {
                h = x - x0; // Recalcular h en cada iteración

                real = FuncPrin(x);

                // Aproximación con Taylor de segundo orden
                T = FuncPrin(x0) // Término constante
                       + (FuncDer_1(x0) * h) // primer orden
                       + ((FuncDer_2(x0) / 2) * (float)Math.Pow(h, 2.0)) //segundo orden
                       + ((FuncDer_3(x0) / 6) * (float)Math.Pow(h, 3.0)); //tercer orden

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i; // Iteración
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4); // Valor de x0
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6); // Aprox
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6); //real

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public float FormulaTaylor4(float x, float x0, float b, float incremento, DataGridView dgvResultado)
        {
            float T;
            float real;
            int i = 1;
            float h;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("incremento", "x0");
            dgvResultado.Columns.Add("Aproximacion", "Taylor4");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

            if (incremento <= 0)
            {
                MessageBox.Show("El incremento de x debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            while (x0 <= b)
            {
                h = x - x0; // Recalcular h en cada iteración

                real = FuncPrin(x);

                // Aproximación con Taylor de segundo orden
                T = FuncPrin(x0) // Término constante
                       + (FuncDer_1(x0) * h) // primer orden
                       + ((FuncDer_2(x0) / 2) * (float)Math.Pow(h, 2.0)) //segundo orden
                       + ((FuncDer_3(x0) / 6) * (float)Math.Pow(h, 3.0)) //tercer orden
                       + ((FuncPrin(x0) / 24) *(float)Math.Pow(h, 4.0)); //cuarto orden

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i; // Iteración
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4); // Valor de x0
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6); // Aprox
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6); //real

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public float FormulaTaylor5(float x, float x0, float b, float incremento, DataGridView dgvResultado)
        {
            float T;
            float real;
            int i = 1;
            float h;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("incremento", "x0");
            dgvResultado.Columns.Add("Aproximacion", "Taylor4");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

            if (incremento <= 0)
            {
                MessageBox.Show("El incremento de x debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            while (x0 <= b)
            {
                h = x - x0; // Recalcular h en cada iteración

                real = FuncPrin(x);

                // Aproximación con Taylor de segundo orden
                T = FuncPrin(x0) // Término constante
                       + (FuncDer_1(x0) * h) // primer orden
                       + ((FuncDer_2(x0) / 2) * (float)Math.Pow(h, 2.0)) //segundo orden
                       + ((FuncDer_3(x0) / 6) * (float)Math.Pow(h, 3.0)) //tercer orden
                       + ((FuncPrin(x0) / 24) * (float)Math.Pow(h, 4.0)) //cuarto orden
                       + ((FuncDer_1(x0) / 120) * (float)Math.Pow(h, 5.0)); //quinto orden

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i; // Iteración
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4); // Valor de x0
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6); // Aprox
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6); //real

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }


        private float FuncPrin(float x) //funcion principal, derivada 4
        {
            return (float)Math.Cos(x);
        }

        private float FuncDer_1(float x) //derivada 1 y 5
        {
            float y;
            y = -((float)Math.Sin(x));
            return y;
        }

        private float FuncDer_2(float x) //derivada 2
        {
            float y;
            y = -(float)Math.Cos(x);
            return y;
        }

        private float FuncDer_3(float x) //derivada 3
        {
            float y;
            y= ((float)Math.Sin(x));
            return y;
        }
    }
}

