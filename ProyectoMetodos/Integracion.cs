using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    internal class Integracion
    {
        public float x0;
        public float xn;
        public int n;
        
        public float MetodoTrapecio(float x0, float xn, int NumSubInt)
        {
            float h;
            float sumatoria;
            float a = x0;
            float b = xn;
            int n = NumSubInt;
            int i;

            if (NumSubInt <= 0)
            {
                MessageBox.Show("El numero de subintervalos debe ser mayor a 0", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            h = (b - a) / n;
            sumatoria = 0;

            for (i = 1; i < n; i++)
            {
                sumatoria += funcion(a + i * h);
            }
            
            sumatoria = sumatoria * h;
            sumatoria += h * (funcion(a) + funcion(b)) / 2;
            return sumatoria;
        }

        public float MetodoTrapecioMultiple(float x0, float xn, int numSubIntX, float y0, float ym, float numSubIntY)
        {

            float hx, hy;
            float resultado = 0;
            float n = numSubIntX;
            float m = numSubIntY;
            
            hx = (xn - x0) / n;
            hy = (ym - y0) / m;

            float sum = 0;
            float sum2 = 0;
            float sum3 = 0;

       
            for (int j = 0; (j < m - 1); j ++)
            {
                sum = funcion2(x0, y0 + (hy * j));
            }

            resultado += ((hx * hy) / 2) * (funcion2(x0, y0) / 2) + sum + (funcion2(x0, ym) / 2) ;

            sum = 0;
            for (int i = 0;  (i < n - 1); i++)
            {
                sum = funcion2(x0 + (hx * i), y0);
            }

            for (int i = 0; (i < n - 1); i++)
            {
                for (int j = 0; (j < m - 1); j++)
                {
                    sum2 = funcion2(x0 + (hx * i) , y0 + (hy * j));
                }
            }

            for (int i = 1; (i < (n - 1)); i++)
            {
                sum3 = funcion2(x0 + (hx * (i + 1)), ym);
            }

            resultado += hx * hy * ((sum / 2) + sum2 + (sum3 / 2));

            sum = 0;
            for (int j = 0; j < (m - 1); j++)
            {
                sum += funcion2(xn, y0 + (hy * j));
            }

            resultado += ((hx * hy) / 2) * ( (funcion2(xn, y0) / 2) + sum + (funcion2(xn, ym) / 2)) ;

            return resultado;
        }

        public float Simpson1_3(float x0, float xn, int k)
        {
            float h;
            float sum1 = 0;
            float sum2 = 0;
            float n = 2 * k;
            float a = x0;
            float b = xn;

            if (k <= 0)
            {
                MessageBox.Show("El numero de k debe ser mayor a 0", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            h = (b - a) / n;

            for (int i = 1; i <= k; i++)
            {
                sum1 += funcion(a + (2 * i - 1) * h);
            }

            sum1 = 4 * sum1;

            for (int i = 1; i < k; i++)
            {
                sum2 += funcion(a + 2 * i * h);
            }
            sum2 = 2 * sum2;

            sum1 = (h / 3) * (funcion(a) + sum1 + sum2 + funcion(b));
            return sum1;
        }

        public float Simpson3_8(float x0, float xn, int k)
        {
            float h;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;
            float n = 3 * k;
            float a = x0;
            float b = xn;
            float formula;

            if (k <= 0)
            {
                MessageBox.Show("El numero de k debe ser mayor a 0", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            h = (b - a) / n;

            for(int i = 1; i <= k; i++)
            {
                sum1 += funcion(a + (3 * i - 2) * h);
            }

            sum1 = 3 * sum1;

            for (int i = 1; i <= k; i++)
            {
                sum2 += funcion(a + (3 * i - 1) * h);
            }

            sum2 = 3 * sum2;

            for (int i = 1; i < k; i++)
            {
                sum3 += funcion(a + (3 * i) * h);
            }

            sum3 = 2 * sum3;

            formula =  ((3 * h) / 8) * (funcion(a) + sum1 + sum2 + sum3 + funcion(b));

            return formula;

        }

        public float IntegralDoble_trapecio(float a, float b, float c, float d, int n_x, int n_y)
        {
            // Paso en x y en y
            float h_x = (b - a) / n_x;
            float h_y = (d - c) / n_y;

            float sum = 0;

            for (int i = 0; i <= n_x; i++)
            {
                float x_i = a + i * h_x;

                float f_c = Func(x_i, c);
                float f_d = Func(x_i, d);

                sum += (1/2) * (f_c + f_d); 

                for (int j = 1; j < n_y; j++)
                {
                    float y_j = c + j * h_y;
                    sum += 2 * Func(x_i, y_j);
                }
            }

            sum *= h_x * h_y;

            return sum;
        }

        public float IntegralDoble_Simpson(float a, float b, float c, float d, int n_x, int n_y)
        {
            float h_x = (b - a) / n_x;
            float h_y = (d - c) / n_y;

            float sum = 0;

            sum += Func(a, c) + Func(a, d) + Func(b, c) + Func(b, d);

            for (int i = 1; i < n_x; i++)
            {
                float x_i = a + i * h_x;

                sum += 4 * Func(x_i, c) + 4 * Func(x_i, d);

                for (int j = 1; j < n_y; j++)
                {
                    float y_j = c + j * h_y;
                    sum += 2 * Func(x_i, y_j);
                }
            }

            for (int j = 1; j < n_y; j++)
            {
                float y_j = c + j * h_y;

                sum += 4 * Func(a, y_j) + 4 * Func(b, y_j);

                for (int i = 1; i < n_x; i++)
                {
                    float x_i = a + i * h_x;
                    sum += 16 * Func(x_i, y_j);
                }
            }

            sum *= h_x * h_y / 9;

            return sum;
        }
        /*

        float integral_doble_numerica(float x0, float xn, 
            float y0, float ym, int n, int m)
        {
            float resultado = 0;
            float hx, hy;
            float sum1 = 0;
            float sum2 = 0;
            int i, j;

            hx = (xn - x0) / 2;
            hy = (ym - y0) / 2;

            for(j=1; j<m; j++)
            {
                sum1 = sum1 + funcion2(x0, y0 + hy * j);
                
            }
            sum1 = (sum1 + funcion2(x0, y0) / 2 + funcion2(x0, ym) / 2);
            resultado = sum1;
            sum1 = 0;

            for (i = 1; i<xn; i++)
            {
                sum1=
            }
            return resultado;
        }
        */


        public float MetodoCuadraturaAdaptativa(float x0, float xn, int NumSubInt, float tolerancia)
        {
            float h;
            float suma;
            float a = x0;
            float b = xn;
            int n = NumSubInt;
            int i;

            if (NumSubInt <= 0)
            {
                MessageBox.Show("El número de subintervalos debe ser mayor a 0", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            h = (b - a) / n;
            suma = (funcion(a) + funcion(b)) / 2;
            for (i = 1; i < n; i++)
            {
                suma += funcion(a + i * h);
            }
            suma *= h;

            float error = EstimarError(x0, xn, n);

            if (error <= tolerancia)
            {
                return suma;
            }
            else
            {
                float medio = (a + b) / 2;
                float sumaIzq = MetodoCuadraturaAdaptativa(a, medio, n / 2, tolerancia);
                float sumaDer = MetodoCuadraturaAdaptativa(medio, b, n / 2, tolerancia);

                return sumaIzq + sumaDer;
            }
        }

        public float EstimarError(float x0, float xn, int n)
        {
            float h = (xn - x0) / n;
            float suma1 = (funcion(x0) + funcion(xn)) / 2;

            for (int i = 1; i < n; i++)
            {
                suma1 += funcion(x0 + i * h);
            }
            suma1 *= h;

            int n2 = 2 * n;
            float h2 = (xn - x0) / n2;
            float suma2 = (funcion(x0) + funcion(xn)) / 2;

            for (int i = 1; i < n2; i++)
            {
                suma2 += funcion(x0 + i * h2);
            }
            suma2 *= h2;

            return Math.Abs(suma2 - suma1) / 3;
        }

        public float MetodoCuadraturaGaussiana(float x0, float xn)
        {
            float suma = 0;
            float c1 = (xn - x0) / 2;
            float c2 = (xn + x0) / 2;

            float x1 = (float)(-1 / Math.Sqrt(3));
            float x2 = (float) (1 / Math.Sqrt(3));

            suma += c1 * (funcion(c1 * x1 + c2) + funcion(c1 * x2 + c2));

            return suma;
        }

        public float MetodoTrapecioabierto(float x0, float h)
        {
            return 2 * h * funcion(x0);
        }

        public float MetodoSimpsonAbierto(float x0, float h)
        {
            return (float) ((3 * h) / 2) * funcion(x0);
        }

        float funcion(float x)
        {
            float r;
            r = x * (float)Math.Sin(x);
            return r;
        }

        float funcion2(float x, float y)
        {
            float res;
            float r = (float) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            res =  r * (float) Math.Sin(r);

            return res;
        }

        public float Func(float x, float y)
        {
            return x * x + y * y;
        }
    }
}
