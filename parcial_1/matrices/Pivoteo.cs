using System;

namespace ProyectoMetodos
{
    public static class Pivoteo
    {
        
        public static void Parcial(double[,] A, double[] B, int filaActual, int n)
        {
            int max = filaActual;
            for (int i = filaActual + 1; i < n; i++)
            {
                if (Math.Abs(A[i, filaActual]) > Math.Abs(A[max, filaActual]))
                    max = i;
            }
            IntercambiarFilas(A, B, filaActual, max, n);
        }

       
        public static void Escalado(double[,] A, double[] B, int filaActual, int n)
        {
            double[] s = new double[n]; 
            for (int i = filaActual; i < n; i++)
            {
                double maxFila = 0;
                for (int j = 0; j < n; j++)
                    maxFila = Math.Max(maxFila, Math.Abs(A[i, j]));
                s[i] = Math.Abs(A[i, filaActual]) / maxFila;
            }

            int filaMax = filaActual;
            for (int i = filaActual + 1; i < n; i++)
            {
                if (s[i] > s[filaMax]) filaMax = i;
            }
            IntercambiarFilas(A, B, filaActual, filaMax, n);
        }

        
        public static void Total(double[,] A, double[] B, int etapa, int n, int[] orden)
        {
            int filaMax = etapa, colMax = etapa;
            double maxVal = 0;

            for (int i = etapa; i < n; i++)
            {
                for (int j = etapa; j < n; j++)
                {
                    if (Math.Abs(A[i, j]) > maxVal)
                    {
                        maxVal = Math.Abs(A[i, j]);
                        filaMax = i;
                        colMax = j;
                    }
                }
            }

            IntercambiarFilas(A, B, etapa, filaMax, n);
            IntercambiarColumnas(A, etapa, colMax, n, orden);
        }

        private static void IntercambiarFilas(double[,] A, double[] B, int f1, int f2, int n)
        {
            if (f1 == f2) return;
            for (int j = 0; j < n; j++)
            {
                double temp = A[f1, j];
                A[f1, j] = A[f2, j];
                A[f2, j] = temp;
            }
            double tempB = B[f1];
            B[f1] = B[f2];
            B[f2] = tempB;
        }

        private static void IntercambiarColumnas(double[,] A, int c1, int c2, int n, int[] orden)
        {
            if (c1 == c2) return;
            for (int i = 0; i < n; i++)
            {
                double temp = A[i, c1];
                A[i, c1] = A[i, c2];
                A[i, c2] = temp;
            }
            
            int tempO = orden[c1];
            orden[c1] = orden[c2];
            orden[c2] = tempO;
        }
    }
}