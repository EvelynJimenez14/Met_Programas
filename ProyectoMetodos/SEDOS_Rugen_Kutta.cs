using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMetodos
{
    internal class SEDOS_Rugen_Kutta
    {
        public class RungeKutta
        {
            private const double Omega = 1.0; // Valor de omega

            // Función F1: Derivada de u1
            public static double F1(double t, double u1, double u2)
            {
                return u2;
            }

            // Función F2: Derivada de u2
            public static double F2(double t, double u1, double u2)
            {
                return -5 * u2 * u1 - (u1 + 7) * Math.Sin(Omega * t);
            }

            // Método para calcular un paso de Runge-Kutta
            public static (double, double) RKStep(double h, double t, double u1, double u2)
            {
                // k1
                double k1_1 = h * F1(t, u1, u2);
                double k1_2 = h * F2(t, u1, u2);

                // k2
                double k2_1 = h * F1(t + h / 2, u1 + k1_1 / 2, u2 + k1_2 / 2);
                double k2_2 = h * F2(t + h / 2, u1 + k1_1 / 2, u2 + k1_2 / 2);

                // k3
                double k3_1 = h * F1(t + h / 2, u1 + k2_1 / 2, u2 + k2_2 / 2);
                double k3_2 = h * F2(t + h / 2, u1 + k2_1 / 2, u2 + k2_2 / 2);

                // k4
                double k4_1 = h * F1(t + h, u1 + k3_1, u2 + k3_2);
                double k4_2 = h * F2(t + h, u1 + k3_1, u2 + k3_2);

                // Actualizar valores de u1 y u2
                double u1_next = u1 + (k1_1 + 2 * k2_1 + 2 * k3_1 + k4_1) / 6;
                double u2_next = u2 + (k1_2 + 2 * k2_2 + 2 * k3_2 + k4_2) / 6;

                return (u1_next, u2_next);
            }

            public static List<(int j, double tj, int i, double wij, double k1, double k2, double k3, double k4)> SolveWithTableFormat(
    double h, double t0, double w10, double w20, int steps)
            {
                var results = new List<(int j, double tj, int i, double wij, double k1, double k2, double k3, double k4)>();
                double t = t0, w1 = w10, w2 = w20;

                for (int j = 0; j < steps; j++)
                {
                    // Cálculo de k1
                    double k1_1 = h * F1(t, w1, w2);
                    double k1_2 = h * F2(t, w1, w2);

                    // Cálculo de k2
                    double k2_1 = h * F1(t + h / 2, w1 + k1_1 / 2, w2 + k1_2 / 2);
                    double k2_2 = h * F2(t + h / 2, w1 + k1_1 / 2, w2 + k1_2 / 2);

                    // Cálculo de k3
                    double k3_1 = h * F1(t + h / 2, w1 + k2_1 / 2, w2 + k2_2 / 2);
                    double k3_2 = h * F2(t + h / 2, w1 + k2_1 / 2, w2 + k2_2 / 2);

                    // Cálculo de k4
                    double k4_1 = h * F1(t + h, w1 + k3_1, w2 + k3_2);
                    double k4_2 = h * F2(t + h, w1 + k3_1, w2 + k3_2);

                    // Agregar resultados para W1,j
                    results.Add((j, t, 1, w1, k1_1, k2_1, k3_1, k4_1));
                    // Agregar resultados para W2,j
                    results.Add((j, t, 2, w2, k1_2, k2_2, k3_2, k4_2));

                    // Actualizar valores de w1 y w2
                    w1 += (k1_1 + 2 * k2_1 + 2 * k3_1 + k4_1) / 6;
                    w2 += (k1_2 + 2 * k2_2 + 2 * k3_2 + k4_2) / 6;

                    // Incrementar t
                    t += h;
                }

                return results;
            }

        }
    }
}
