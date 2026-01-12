using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMetodos
{
    internal class Sist_Ec_Lineales
    {

        public bool eliminacion_gaussiana(float[,] matriz, int n)
        {
            int i, j, r;
            float multiplicador;

            for (i = 0; i < n - 1; i++)
            {
                for (r = i + 1; r < n; r++)
                {
                    multiplicador = -matriz[r, i] / matriz[i, i];
                    matriz[r, i] = 0;

                    for (j = i + 1; j <= n; j++)
                    {
                        matriz[r, j] = multiplicador * matriz[i, j] + matriz[r, j];
                    }
                }
            }
            return true;
        }

        public float[] SustitucionHaciaAtras(float[,] matriz, int n)
        {
            float[] soluciones = new float[n];
            int i;

            for (i = n - 1; i >= 0; i--)
            {
                float suma = 0;
                for (int j = i + 1; j < n; j++)
                {
                    suma += matriz[i, j] * soluciones[j];
                }
                soluciones[i] = (matriz[i, n] - suma) / matriz[i, i];
            }

            return soluciones;
        }



        public bool PivoteoParcial(float[,] matriz, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                float maxVal = Math.Abs(matriz[i, i]);
                int maxRow = i;

                for (int r = i + 1; r < n; r++)
                {
                    if (Math.Abs(matriz[r, i]) > maxVal)
                    {
                        maxVal = Math.Abs(matriz[r, i]);
                        maxRow = r;
                    }
                }

                if (maxVal < 1e-6) return false;

                if (maxRow != i)
                {
                    for (int k = i; k <= n; k++) 
                    {
                        float temp = matriz[i, k];
                        matriz[i, k] = matriz[maxRow, k];
                        matriz[maxRow, k] = temp;
                    }
                }

                for (int r = i + 1; r < n; r++)
                {
                    float factor = matriz[r, i] / matriz[i, i];
                    matriz[r, i] = 0;
                    for (int c = i + 1; c <= n; c++)
                    {
                        matriz[r, c] -= factor * matriz[i, c];
                    }
                }
            }
            return true;
        }

        public bool PivoteoParcialEscalado(float[,] matriz, int n)
        {
            float[] escalas = new float[n];

            for (int i = 0; i < n; i++)
            {
                float maxFila = 0;
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(matriz[i, j]) > maxFila) maxFila = Math.Abs(matriz[i, j]);
                }
                if (maxFila == 0) return false; 
                escalas[i] = maxFila;
            }

            for (int i = 0; i < n - 1; i++)
            {
                int mejorFila = i;
                float maxRatio = 0;

                for (int k = i; k < n; k++)
                {
                    float ratio = Math.Abs(matriz[k, i]) / escalas[k];
                    if (ratio > maxRatio)
                    {
                        maxRatio = ratio;
                        mejorFila = k;
                    }
                }

                if (maxRatio == 0) return false;

               
                if (mejorFila != i)
                {
                   
                    for (int k = i; k <= n; k++)
                    {
                        float temp = matriz[i, k];
                        matriz[i, k] = matriz[mejorFila, k];
                        matriz[mejorFila, k] = temp;
                    }
                   
                    float tempEsc = escalas[i];
                    escalas[i] = escalas[mejorFila];
                    escalas[mejorFila] = tempEsc;
                }

               
                for (int r = i + 1; r < n; r++)
                {
                    float factor = matriz[r, i] / matriz[i, i];
                    matriz[r, i] = 0;
                    for (int c = i + 1; c <= n; c++)
                    {
                        matriz[r, c] -= factor * matriz[i, c];
                    }
                }
            }
            return true;
        }
        // Método para Gauss con Pivoteo Total
        public bool GaussPivoteoTotal(float[,] matriz, int n, out float[] soluciones)
        {
            soluciones = new float[n];
            int[] etiquetas = new int[n]; 
            for (int i = 0; i < n; i++) etiquetas[i] = i;

            for (int i = 0; i < n - 1; i++) 
            {
               
                float maxVal = 0;
                int maxRow = i, maxCol = i;

                for (int r = i; r < n; r++)
                {
                    for (int c = i; c < n; c++)
                    {
                        if (Math.Abs(matriz[r, c]) > maxVal)
                        {
                            maxVal = Math.Abs(matriz[r, c]);
                            maxRow = r;
                            maxCol = c;
                        }
                    }
                }

                if (maxVal < 1e-6) return false; 
                if (maxRow != i)
                {
                    for (int j = i; j <= n; j++) 
                    {
                        float temp = matriz[i, j];
                        matriz[i, j] = matriz[maxRow, j];
                        matriz[maxRow, j] = temp;
                    }
                }

               
                if (maxCol != i)
                {
                   
                    for (int r = 0; r < n; r++)
                    {
                        float temp = matriz[r, i];
                        matriz[r, i] = matriz[r, maxCol];
                        matriz[r, maxCol] = temp;
                    }
                    
                    int tempTag = etiquetas[i];
                    etiquetas[i] = etiquetas[maxCol];
                    etiquetas[maxCol] = tempTag;
                }

                
                for (int r = i + 1; r < n; r++)
                {
                    float factor = matriz[r, i] / matriz[i, i];
                    matriz[r, i] = 0;
                    for (int c = i + 1; c <= n; c++)
                    {
                        matriz[r, c] -= factor * matriz[i, c];
                    }
                }
            }

            
            float[] solDesordenada = SustitucionHaciaAtras(matriz, n); // Usa tu método existente

            
            for (int i = 0; i < n; i++)
            {
                soluciones[etiquetas[i]] = solDesordenada[i];
            }

            return true;
        }
        public void FactorizacionPLU(float[,] matriz, int n, out float[,] L, out float[,] U, out int[] P)
        {
            L = new float[n, n];
            U = new float[n, n];
            P = new int[n]; // Vector de permutación (es más fácil que una matriz llena)

            // Inicializar P y L
            for (int i = 0; i < n; i++)
            {
                P[i] = i;
                L[i, i] = 1; // Diagonal de L es 1
            }

            // Copiar matriz a U para trabajar sobre ella
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    U[i, j] = matriz[i, j];

            for (int i = 0; i < n - 1; i++)
            {
                // Pivoteo Parcial (solo filas) sobre U
                int maxRow = i;
                for (int r = i + 1; r < n; r++)
                    if (Math.Abs(U[r, i]) > Math.Abs(U[maxRow, i])) maxRow = r;

                // Intercambiar filas en U
                if (maxRow != i)
                {
                    
                    for (int k = i; k < n; k++)
                    {
                        float temp = U[i, k]; U[i, k] = U[maxRow, k]; U[maxRow, k] = temp;
                    }
                    
                    for (int k = 0; k < i; k++)
                    {
                        float temp = L[i, k]; L[i, k] = L[maxRow, k]; L[maxRow, k] = temp;
                    }
                   
                    int tempP = P[i]; P[i] = P[maxRow]; P[maxRow] = tempP;
                }

                // Eliminación
                for (int r = i + 1; r < n; r++)
                {
                    float factor = U[r, i] / U[i, i];
                    L[r, i] = factor; 
                    U[r, i] = 0;
                    for (int c = i + 1; c < n; c++)
                    {
                        U[r, c] -= factor * U[i, c];
                    }
                }
            }
        }
    }
}

