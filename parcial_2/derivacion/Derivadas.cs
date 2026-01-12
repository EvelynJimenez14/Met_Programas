using System;

namespace ProyectoMetodos
{
    internal class Derivadas_Numericas
    {
        // 2 puntos 
        public static float Derivada_Dos_Puntos(float x0, float h)
            => (Func(x0 + h) - Func(x0)) / h; 

        public static float Derivada_Dos_Puntos_Atras(float x0, float h)
            => (Func(x0) - Func(x0 - h)) / h; 

        // 3 puntos
        public static float Derivada_Tres_Puntos(float x0, float h)
            => (-3 * Func(x0) + 4 * Func(x0 + h) - Func(x0 + 2 * h)) / (2 * h); // adelante

        public static float Derivada_Tres_Puntos_Atras(float x0, float h)
            => (3 * Func(x0) - 4 * Func(x0 - h) + Func(x0 - 2 * h)) / (2 * h); // atrás

        public static float Derivada_Tres_Puntos_Centrada(float x0, float h)
            => (Func(x0 + h) - Func(x0 - h)) / (2 * h); 

        //5 puntos
        public static float Derivada_Cinco_Puntos_Adelante(float x0, float h)
            => (-25 * Func(x0) + 48 * Func(x0 + h) - 36 * Func(x0 + 2 * h) + 16 * Func(x0 + 3 * h) - 3 * Func(x0 + 4 * h)) / (12 * h);

        public static float Derivada_Cinco_Puntos_Atras(float x0, float h)
            => (25 * Func(x0) - 48 * Func(x0 - h) + 36 * Func(x0 - 2 * h) - 16 * Func(x0 - 3 * h) + 3 * Func(x0 - 4 * h)) / (12 * h);

        public static float Derivada_Cinco_Puntos_Centrada(float x0, float h)
            => (Func(x0 - 2 * h) - 8 * Func(x0 - h) + 8 * Func(x0 + h) - Func(x0 + 2 * h)) / (12 * h);

        
        private static float Func(float x)
        {

           // return (float)(Math.Sin(x) + Math.Pow(x, 2));
            return (float)(3 * Math.Pow(x, 3) + Math.Cos(2 * x - 8) * Math.Exp(x));
        }

        //Derivada exacta
        public static float DerivadaExacta(float x)
        {
           
            // f'(x) = 9x^2 - 2 sin(2x-8) e^x + cos(2x-8) e^x
            float t1 = 9 * (float)Math.Pow(x, 2);
            float t2 = -2 * (float)Math.Sin(2 * x - 8) * (float)Math.Exp(x);
            float t3 = (float)Math.Cos(2 * x - 8) * (float)Math.Exp(x);
            return t1 + t2 + t3;
            //return (float) (Math.Cos(x)+2*x);
        }

        public static float Derivada_H_Variable(float x0, float y0, float x1, float y1)
        {
            
            return (y1 - y0) / (x1 - x0);
        }
        public static float Derivada_Tres_Puntos_HVariable(float x0, float y0, float x1, float y1, float x2, float y2)
        {
            return (-(x1 - x2) * y0 / ((x0 - x1) * (x0 - x2)))
                 + ((x0 - x2) * y1 / ((x1 - x0) * (x1 - x2)))
                 + ((x0 - x1) * y2 / ((x2 - x0) * (x2 - x1)));
        }

    }
}
