using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    internal class EcuaDif
    {
        private float Funcion(float t, float y)
        {
            return -2 * t * y;
        }

        private float FuncPrin(float x)
        {
            return (float)Math.Exp(-x * x);
        }

        public int MetodoEuler(float tMax, float y0, float h, DataGridView dgvResultado)
        {
            float t = 0;
            float y = y0;
            int i = 1;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("Aproximacion_Euler", "Euler");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

            if (h <= 0)
            {
                MessageBox.Show("El paso h debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            while (t <= tMax)
            {
                float real = FuncPrin(t);
                y = y + h * Funcion(t, y);

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i;
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(t, 4);
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(y, 6);
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6);

                t += h;
                i++;
            }
            return 0;
        }

        public int RungeKuta4(float tMax, float y0, float h, DataGridView dgvResultado)
        {
            if (h <= 0 || tMax <= 0) return -1;

            float t = 0;
            float w = y0;
            int iteracion = 0;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("aproximacionRK", "Runge-Kutta 4");

            try
            {
                while (t <= tMax + 0.0001)
                {
                    dgvResultado.Rows.Add(iteracion, Math.Round(t, 4), Math.Round(w, 6));

                    float k1 = h * Funcion(t, w);
                    float k2 = h * Funcion(t + h / 2, w + k1 / 2);
                    float k3 = h * Funcion(t + h / 2, w + k2 / 2);
                    float k4 = h * Funcion(t + h, w + k3);

                    w += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                    t += h;
                    iteracion++;
                }
                return 0;
            }
            catch { return -1; }
        }

        public int RungeKutta2(float tMax, float y0, float h, DataGridView dgvResultado)
        {
            if (h <= 0 || tMax <= 0) return -1;

            float t = 0;
            float w = y0;
            int iteracion = 0;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("aproximacionRK2", "Runge-Kutta 2");

            try
            {
                while (t <= tMax + 0.0001)
                {
                    dgvResultado.Rows.Add(iteracion, Math.Round(t, 4), Math.Round(w, 6));

                    float k1 = h * Funcion(t, w);
                    float k2 = h * Funcion(t + h, w + k1);

                    w = w + (k1 + k2) / 2;
                    t += h;
                    iteracion++;
                }
                return 0;
            }
            catch { return -1; }
        }

        public int MetodoRK3(float tMax, float y0, float h, DataGridView dgvResultado)
        {
            if (h <= 0 || tMax <= 0) return -1;

            float t = 0;
            float w = y0;
            int i = 0;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iter", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("w", "RK3");

            try
            {
                while (t <= tMax + 0.0001)
                {
                    dgvResultado.Rows.Add(i, Math.Round(t, 4), Math.Round(w, 6));

                    float k1 = h * Funcion(t, w);
                    float k2 = h * Funcion(t + h / 2, w + k1 / 2);
                    float k3 = h * Funcion(t + h, w - k1 + 2 * k2);

                    w = w + (k1 + 4 * k2 + k3) / 6;
                    t += h;
                    i++;
                }
                return 0;
            }
            catch { return -1; }
        }

        public int MetodoAdams(float tMax, float y0, float h, DataGridView dgvResultado)
        {
            if (h <= 0) return -1;

            List<float> t = new List<float>();
            List<float> w = new List<float>();

            float t_actual = 0;
            float w_actual = y0;

            for (int k = 0; k < 4; k++)
            {
                t.Add(t_actual);
                w.Add(w_actual);

                float k1 = h * Funcion(t_actual, w_actual);
                float k2 = h * Funcion(t_actual + h / 2, w_actual + k1 / 2);
                float k3 = h * Funcion(t_actual + h / 2, w_actual + k2 / 2);
                float k4 = h * Funcion(t_actual + h, w_actual + k3);

                w_actual += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                t_actual += h;
            }

            int i = 3;
            while (t[i] < tMax)
            {
                float f_i = Funcion(t[i], w[i]);
                float f_i1 = Funcion(t[i - 1], w[i - 1]);
                float f_i2 = Funcion(t[i - 2], w[i - 2]);
                float f_i3 = Funcion(t[i - 3], w[i - 3]);

                float w_pred = w[i] + (h / 24.0f) * (55 * f_i - 59 * f_i1 + 37 * f_i2 - 9 * f_i3);
                float t_next = t[i] + h;

                float f_next = Funcion(t_next, w_pred);
                float w_corr = w[i] + (h / 24.0f) * (9 * f_next + 19 * f_i - 5 * f_i1 + f_i2);

                t.Add(t_next);
                w.Add(w_corr);
                i++;
            }

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iter", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("w", "Adams ");

            for (int k = 0; k < t.Count; k++)
            {
                dgvResultado.Rows.Add(k, Math.Round(t[k], 4), Math.Round(w[k], 6));
            }
            return 0;
        }
    }
}