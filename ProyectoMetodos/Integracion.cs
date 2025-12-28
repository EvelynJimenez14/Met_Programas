using System;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    internal class Integracion
    {
        private const int MAX_NIVEL = 20;
        public double MetodoTrapecio(double x0, double xn, int NumSubInt)
        {
            if (NumSubInt <= 0)
            {
                MessageBox.Show("El numero de subintervalos debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            double h = (xn - x0) / NumSubInt;
            double sumatoria = 0;

            for (int i = 1; i < NumSubInt; i++)
            {
                sumatoria += funcion(x0 + i * h);
            }

            
            return (h / 2.0) * (funcion(x0) + 2 * sumatoria + funcion(xn));
        }

        public double Simpson1_3(double x0, double xn, int k)
        {
            if (k <= 0) return -1;

            double n = 2.0 * k;
            double h = (xn - x0) / n;
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 1; i <= k; i++)
                sum1 += funcion(x0 + (2 * i - 1) * h);

            for (int i = 1; i < k; i++)
                sum2 += funcion(x0 + 2 * i * h);

            return (h / 3.0) * (funcion(x0) + 4 * sum1 + 2 * sum2 + funcion(xn));
        }

        public double Simpson3_8(double x0, double xn, int k)
        {
            if (k <= 0) return -1;

            double n = 3.0 * k;
            double h = (xn - x0) / n;
            double sum1 = 0, sum2 = 0, sum3 = 0;

            for (int i = 1; i <= k; i++)
            {
                sum1 += funcion(x0 + (3 * i - 2) * h);
                sum2 += funcion(x0 + (3 * i - 1) * h);
            }

            for (int i = 1; i < k; i++)
                sum3 += funcion(x0 + (3 * i) * h);

            return ((3.0 * h) / 8.0) * (funcion(x0) + 3 * sum1 + 3 * sum2 + 2 * sum3 + funcion(xn));
        }

        public double IntegralDoble_trapecio(double a, double b, double c, double d, int n_x, int n_y)
        {
            double h_x = (b - a) / n_x;
            double h_y = (d - c) / n_y;
            double sum = 0;

            for (int i = 0; i <= n_x; i++)
            {
                double x_i = a + i * h_x;
                
                double pesoX = (i == 0 || i == n_x) ? 0.5 : 1.0;

                for (int j = 0; j <= n_y; j++)
                {
                    double y_j = c + j * h_y;
                    double pesoY = (j == 0 || j == n_y) ? 0.5 : 1.0;
                    sum += pesoX * pesoY * Func(x_i, y_j);
                }
            }
            return sum * h_x * h_y;
        }

        public double IntegralDoble_Simpson(double a, double b, double c, double d, int n_x, int n_y)
        {
            double h_x = (b - a) / n_x;
            double h_y = (d - c) / n_y;
            double sum = 0;

            for (int i = 0; i <= n_x; i++)
            {
                double x_i = a + i * h_x;
                double pesoX = (i == 0 || i == n_x) ? 1.0 : (i % 2 == 0 ? 2.0 : 4.0);

                for (int j = 0; j <= n_y; j++)
                {
                    double y_j = c + j * h_y;
                    double pesoY = (j == 0 || j == n_y) ? 1.0 : (j % 2 == 0 ? 2.0 : 4.0);
                    sum += pesoX * pesoY * Func(x_i, y_j);
                }
            }
            return (h_x * h_y / 9.0) * sum;
        }

        public double MetodoCuadraturaGaussiana(double x0, double xn)
        {
            double c1 = (xn - x0) / 2.0;
            double c2 = (xn + x0) / 2.0;
            double x1 = -1.0 / Math.Sqrt(3.0);
            double x2 = 1.0 / Math.Sqrt(3.0);
            return c1 * (funcion(c1 * x1 + c2) + funcion(c1 * x2 + c2));
        }
        public double MetodoCuadraturaAdaptativa(double a, double b, double tolerancia, int nivel = 0)
        {
            
            double c = (a + b) / 2.0;
            double h = (b - a) / 6.0;
            double areaTotal = h * (funcion(a) + 4 * funcion(c) + funcion(b));

            
            double d = (a + c) / 2.0;
            double e = (c + b) / 2.0;
            double h2 = (b - a) / 12.0;
            double areaIzquierda = h2 * (funcion(a) + 4 * funcion(d) + funcion(c));
            double areaDerecha = h2 * (funcion(c) + 4 * funcion(e) + funcion(b));

            
           
            if (Math.Abs(areaIzquierda + areaDerecha - areaTotal) <= 15 * tolerancia || nivel >= MAX_NIVEL)
            {
                return areaIzquierda + areaDerecha + (areaIzquierda + areaDerecha - areaTotal) / 15.0;
            }

            
            return MetodoCuadraturaAdaptativa(a, c, tolerancia / 2.0, nivel + 1) +
                   MetodoCuadraturaAdaptativa(c, b, tolerancia / 2.0, nivel + 1);
        }

        private double funcion(double x) => x * Math.Sin(x);

        private double Func(double x, double y) => x * x + y * y;
    }
}