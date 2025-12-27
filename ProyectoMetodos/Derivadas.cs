using System;

namespace ProyectoMetodos
{
    internal class Derivadas_Numericas
    {
      
        public static float Derivada_Dos_Puntos(float x0, float h) => (Func(x0 + h) - Func(x0)) / h;

        public static float Derivada_Tres_Puntos(float x0, float h) => (-3 * Func(x0) + 4 * Func(x0 + h) - Func(x0 + 2 * h)) / (2 * h);

        public static float Derivada_Cuatro_Puntos(float x0, float h) => (-25 * Func(x0) + 48 * Func(x0 + h) - 36 * Func(x0 + 2 * h) + 16 * Func(x0 + 3 * h)) / (12 * h);


        public static float Derivada_Dos_Puntos_Atras(float x0, float h) => (Func(x0) - Func(x0 - h)) / h;

        public static float Derivada_Tres_Puntos_Atras(float x0, float h) => (3 * Func(x0) - 4 * Func(x0 - h) + Func(x0 - 2 * h)) / (2 * h);

       
        public static float Derivada_Tres_Puntos_Centrada(float x0, float h) => (Func(x0 + h) - Func(x0 - h)) / (2 * h);

        public static float Derivada_Cinco_Puntos_Centrada(float x0, float h) => (Func(x0 - 2 * h) - 8 * Func(x0 - h) + 8 * Func(x0 + h) - Func(x0 + 2 * h)) / (12 * h);

        private static float Func(float x)
        {
            
            return (float)(x * x - 3 * x + 2);
        }
        public static float Derivada_H_Variable(float x0, float y0, float x1, float y1)
        {
            return (y1 - y0) / (x1 - x0); 
        }
    }
}