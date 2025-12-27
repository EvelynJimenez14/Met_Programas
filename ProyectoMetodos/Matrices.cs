using System;

namespace ProyectoMetodos
{
    internal class Matrices
    {
        
        public static void FactorizacionLU(double[,] A, int n, out double[,] L, out double[,] U)
        {
            L = new double[n, n];
            U = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                L[i, i] = 1; 
                for (int j = i; j < n; j++)
                {
                    double suma = 0;
                    for (int k = 0; k < i; k++) suma += L[i, k] * U[k, j];
                    U[i, j] = A[i, j] - suma;
                }
                for (int j = i + 1; j < n; j++)
                {
                    double suma = 0;
                    for (int k = 0; k < i; k++) suma += L[j, k] * U[k, i];
                    if (Math.Abs(U[i, i]) < 1e-12) throw new Exception("Error: LU falló (división entre cero). Use PLU.");
                    L[j, i] = (A[j, i] - suma) / U[i, i];
                }
            }
        }

        
        public static void FactorizacionPLU(double[,] A, int n, out double[,] L, out double[,] U, out double[,] P)
        {
            L = new double[n, n];
            U = (double[,])A.Clone();
            P = Identidad(n);

            for (int i = 0; i < n; i++)
            {
                
                int filaMax = i;
                double valMax = Math.Abs(U[i, i]);
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(U[k, i]) > valMax) { valMax = Math.Abs(U[k, i]); filaMax = k; }
                }

                
                IntercambiarFilas(U, i, filaMax, n);
                IntercambiarFilas(P, i, filaMax, n);
                IntercambiarFilas(L, i, filaMax, i); 
                L[i, i] = 1;
                for (int j = i + 1; j < n; j++)
                {
                    L[j, i] = U[j, i] / U[i, i];
                    for (int k = i; k < n; k++) U[j, k] -= L[j, i] * U[i, k];
                }
            }
        }


        public static void FactorizarLU(double[,] A, double[,] L, double[,] U, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = i; k < n; k++)
                {
                    double suma = 0;
                    for (int j = 0; j < i; j++) suma += (L[i, j] * U[j, k]);
                    U[i, k] = A[i, k] - suma;
                }
                for (int k = i; k < n; k++)
                {
                    if (i == k) L[i, i] = 1;
                    else
                    {
                        double suma = 0;
                        for (int j = 0; j < i; j++) suma += (L[k, j] * U[j, i]);
                        L[k, i] = (A[k, i] - suma) / U[i, i];
                    }
                }
            }
        }

        public static double[] ResolverLU(double[,] L, double[,] U, double[] B, int n)
        {
            double[] Y = new double[n];
            for (int i = 0; i < n; i++)
            {
                double suma = 0;
                for (int j = 0; j < i; j++) suma += L[i, j] * Y[j];
                Y[i] = B[i] - suma;
            }

            double[] X = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double suma = 0;
                for (int j = i + 1; j < n; j++) suma += U[i, j] * X[j];
                X[i] = (Y[i] - suma) / U[i, i];
            }
            return X;
        }
        private static double[,] Identidad(int n)
        {
            double[,] id = new double[n, n];
            for (int i = 0; i < n; i++) id[i, i] = 1.0;
            return id;
        }

        private static void IntercambiarFilas(double[,] matriz, int f1, int f2, int limiteCol)
        {
            for (int j = 0; j < limiteCol; j++)
            {
                double temp = matriz[f1, j];
                matriz[f1, j] = matriz[f2, j];
                matriz[f2, j] = temp;
            }
        }
    }
}