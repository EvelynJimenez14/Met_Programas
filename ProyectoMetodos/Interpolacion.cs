using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace ProyectoMetodos
{
    class Interpolacion
    {
       
        public double InterpolacionNewton(double[] x, double[] y, double valorAInterpolar, DataGridView tabla)
        {
            int n = x.Length;
            double[,] matrizDD = new double[n, n];

    
            for (int i = 0; i < n; i++)
            {
                matrizDD[i, 0] = y[i];
            }

           
            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    
                    matrizDD[i, j] = (matrizDD[i + 1, j - 1] - matrizDD[i, j - 1]) / (x[i + j] - x[i]);
                }
            }

            // Mostrar la tabla 
            if (tabla != null)
            {
                tabla.Rows.Clear();
                tabla.Columns.Clear();

                tabla.Columns.Add("colX", "Xi");
                
                for (int k = 0; k < n; k++) tabla.Columns.Add("colF" + k, (k == 0) ? "f(Xi)" : "DD " + k);

                for (int i = 0; i < n; i++)
                {
                    tabla.Rows.Add();
                    tabla.Rows[i].Cells[0].Value = x[i]; // Valor X
                    for (int j = 0; j < n - i; j++)
                    {
                        // Valor de la diferencia dividida
                        tabla.Rows[i].Cells[j + 1].Value = Math.Round(matrizDD[i, j], 6);
                    }
                }
            }

          
            double resultado = matrizDD[0, 0]; 
            double factorX = 1;

            for (int i = 1; i < n; i++)
            {
                factorX = factorX * (valorAInterpolar - x[i - 1]); 
                resultado = resultado + (matrizDD[0, i] * factorX);
            }

            return resultado;
        }

      
        public double MetodoNeville(double[] x, double[] y, double valorX, DataGridView tabla)
        {
            int n = x.Length;
            double[,] Q = new double[n, n];

            
            for (int i = 0; i < n; i++)
            {
                Q[i, 0] = y[i];
            }

            // 2. Calcular tabla Q usando fórmula recursiva
            for (int j = 1; j < n; j++)
            {
                for (int i = j; i < n; i++)
                {
                    // Fórmula de Neville
                    Q[i, j] = ((valorX - x[i - j]) * Q[i, j - 1] - (valorX - x[i]) * Q[i - 1, j - 1]) / (x[i] - x[i - j]);
                }
            }

            // 3. Mostrar tabla visualmente
            if (tabla != null)
            {
                tabla.Rows.Clear();
                tabla.Columns.Clear();

                for (int k = 0; k < n; k++) tabla.Columns.Add("Q" + k, "Q" + k);

                for (int i = 0; i < n; i++)
                {
                    tabla.Rows.Add();
                    for (int j = 0; j <= i; j++)
                    {
                        tabla.Rows[i].Cells[j].Value = Math.Round(Q[i, j], 6);
                    }
                }
            }

            
            return Q[n - 1, n - 1];
        }
    }
}