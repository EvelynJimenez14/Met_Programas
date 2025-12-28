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
        
        public double FormulaTaylor(double x, double x0, double b, double incremento, DataGridView dgvResultado)
        {
            double T;
            double real;
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
                real = FuncPrin(x);
                T = FuncPrin(x0);

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

        public double FormulaTaylor1(double x, double x0, double b, double incremento, DataGridView dgvResultado)
        {
            double T;
            double real;
            int i = 1;
            double h;

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
                T = FuncPrin(x0) + (FuncDer_1(x0) * h);

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i;
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4);
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6);
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6);

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public double FormulaTaylor2(double x, double x0, double b, double incremento, DataGridView dgvResultado)
        {
            double T;
            double real;
            int i = 1;
            double h;

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
                h = x - x0;
                real = FuncPrin(x);

                T = FuncPrin(x0)
                       + (FuncDer_1(x0) * h)
                       + ((FuncDer_2(x0) / 2.0) * Math.Pow(h, 2.0));

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i;
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4);
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6);
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6);

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public double FormulaTaylor3(double x, double x0, double b, double incremento, DataGridView dgvResultado)
        {
            double T;
            double real;
            int i = 1;
            double h;

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
                h = x - x0;
                real = FuncPrin(x);

                T = FuncPrin(x0)
                       + (FuncDer_1(x0) * h)
                       + ((FuncDer_2(x0) / 2.0) * Math.Pow(h, 2.0))
                       + ((FuncDer_3(x0) / 6.0) * Math.Pow(h, 3.0));

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i;
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4);
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6);
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6);

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public double FormulaTaylor4(double x, double x0, double b, double incremento, DataGridView dgvResultado)
        {
            double T;
            double real;
            int i = 1;
            double h;

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
                h = x - x0;
                real = FuncPrin(x);

                T = FuncPrin(x0)
                       + (FuncDer_1(x0) * h)
                       + ((FuncDer_2(x0) / 2.0) * Math.Pow(h, 2.0))
                       + ((FuncDer_3(x0) / 6.0) * Math.Pow(h, 3.0))
                       + ((FuncPrin(x0) / 24.0) * Math.Pow(h, 4.0));

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i;
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4);
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6);
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6);

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        // Se renombraron los parámetros para coincidir con el resto de la clase
        public double FormulaTaylor5(double x, double x0, double b, double incremento, DataGridView dgvResultado)
        {
            double T;
            double real;
            int i = 1;
            double h;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("incremento", "x0");
            dgvResultado.Columns.Add("Aproximacion", "Taylor5");
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

                T = FuncPrin(x0)
                       + (FuncDer_1(x0) * h)
                       + ((FuncDer_2(x0) / 2.0) * Math.Pow(h, 2.0))
                       + ((FuncDer_3(x0) / 6.0) * Math.Pow(h, 3.0))
                       + ((FuncPrin(x0) / 24.0) * Math.Pow(h, 4.0))
                       + ((FuncDer_1(x0) / 120.0) * Math.Pow(h, 5.0));

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i;
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(x0, 4);
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(T, 6);
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6);

                x0 += incremento;
                x += incremento;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        private double FuncPrin(double x)
        {
            return Math.Cos(x);
        }

        private double FuncDer_1(double x)
        {
            return -Math.Sin(x);
        }

        private double FuncDer_2(double x)
        {
            return -Math.Cos(x);
        }

        private double FuncDer_3(double x)
        {
            return Math.Sin(x);
        }
    }
}