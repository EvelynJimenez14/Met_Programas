using System;

namespace ProyectoMetodos
{
    internal class Matrices
    {
        
        public static void FactorizarLU(double[,] A, double[,] L, double[,] U, int n)
        {
            // Inicializar matrices L y U
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) L[i, j] = 1.0;
                    else L[i, j] = 0.0;
                    U[i, j] = 0.0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                // Cálculo de U 
                for (int k = i; k < n; k++)
                {
                    double suma = 0;
                    for (int j = 0; j < i; j++) suma += (L[i, j] * U[j, k]);
                    U[i, k] = A[i, k] - suma;
                }

                // Cálculo de L 
                for (int k = i + 1; k < n; k++)
                {
                    double suma = 0;
                    for (int j = 0; j < i; j++) suma += (L[k, j] * U[j, i]);

                   
                    if (Math.Abs(U[i, i]) < 1e-15)
                        throw new Exception("Pivote nulo en LU");

                    L[k, i] = (A[k, i] - suma) / U[i, i];
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

                if (Math.Abs(U[i, i]) < 1e-15) throw new Exception("Matriz singular detectada.");
                X[i] = (Y[i] - suma) / U[i, i];
            }
            return X;
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

                L[i, i] = 1.0;
                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Abs(U[i, i]) < 1e-15) continue;
                    L[j, i] = U[j, i] / U[i, i];
                    for (int k = i; k < n; k++) U[j, k] -= L[j, i] * U[i, k];
                }
            }
        }

        private static double[,] Identidad(int n)
        {
            double[,] id = new double[n, n];
            for (int i = 0; i < n; i++) id[i, i] = 1.0;
            return id;
        }

        private static void IntercambiarFilas(double[,] matriz, int f1, int f2, int n)
        {
            if (f1 == f2) return;
            for (int j = 0; j < n; j++)
            {
                double temp = matriz[f1, j];
                matriz[f1, j] = matriz[f2, j];
                matriz[f2, j] = temp;
            }
        }
    }
}