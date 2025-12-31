using System;

namespace ProyectoMetodos
{
    public class Interpolacion
    {
       
        public static double[,] ConstruirTablaNewton(double[] x, double[] y)
        {
            int n = x.Length;
            double[,] F = new double[n, n];
            for (int i = 0; i < n; i++) F[i, 0] = y[i];

            for (int j = 1; j < n; j++)
                for (int i = 0; i < n - j; i++)
                    F[i, j] = (F[i + 1, j - 1] - F[i, j - 1]) / (x[i + j] - x[i]);

            return F;
        }

        public static double InterpolarNewtonAdelante(double[] x, double[,] F, double xInt)
        {
            int n = x.Length;
            double resultado = F[0, 0];
            double prod = 1.0;

            for (int i = 1; i < n; i++)
            {
                prod *= (xInt - x[i - 1]);
                resultado += F[0, i] * prod;
            }
            return resultado;
        }

        public static double InterpolarNewtonAtras(double[] x, double[,] F, double xInt)
        {
            int n = x.Length;
            double resultado = F[n - 1, 0];
            double prod = 1.0;

            for (int i = 1; i < n; i++)
            {
                prod *= (xInt - x[n - i]);
                resultado += F[n - 1 - i, i] * prod;
            }
            return resultado;
        }

       
        public static double InterpolarNeville(double[] x, double[] y, double xInt)
        {
            int n = x.Length;
            double[,] Q = new double[n, n];

            for (int i = 0; i < n; i++) Q[i, 0] = y[i];

            for (int j = 1; j < n; j++)
                for (int i = 0; i < n - j; i++)
                    Q[i, j] = ((xInt - x[i]) * Q[i + 1, j - 1] - (xInt - x[i + j]) * Q[i, j - 1]) / (x[i + j] - x[i]);

            return Q[0, n - 1];
        }

        
        public static double InterpolarLagrange(double[] x, double[] y, double xInt)
        {
            int n = x.Length;
            double resultado = 0;

            for (int i = 0; i < n; i++)
            {
                double Li = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        Li *= (xInt - x[j]) / (x[i] - x[j]);
                }
                resultado += y[i] * Li;
            }

            return resultado;
        }
       
           
        }
    }
