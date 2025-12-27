using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Runtime.Remoting.Messaging;

namespace ProyectoMetodos
{
    internal class MetSolEc
    {

        public int NumIter;
        public float errorMax;
        float AproxRaiz;
        Complex AproxRaizc;


        public bool MetodoDeBiseccion(float a, float b, DataGridView dgvResultado)
        {
            float c, ErrorAct;
            int i;
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("aproximacion", "c");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("F_a", "F(a)");
            dgvResultado.Columns.Add("F_c", "F(c)");
            dgvResultado.Columns.Add("F_b", "F(b)");
            dgvResultado.Columns.Add("Error", "error");

            if (Func(a) * Func(b) > 0)
            {
                MessageBox.Show("No se puede aplicar el metodo de biseccion", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            i = 1;
            while (i <= NumIter)
            {
                c = (a + b) / 2;
                ErrorAct = (b - a) / 2;
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = c;
                dgvResultado.Rows[i - 1].Cells[3].Value = b;
                dgvResultado.Rows[i - 1].Cells[4].Value = Func(a);
                dgvResultado.Rows[i - 1].Cells[5].Value = Func(c);
                dgvResultado.Rows[i - 1].Cells[6].Value = Func(b);
                dgvResultado.Rows[i - 1].Cells[7].Value = ErrorAct;
                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado" + c.ToString(),
                        "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                if (Func(a) * Func(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                i++;
            }
            MessageBox.Show("No se pudo obtener la raiz con el error deseado", "AVISO",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        public bool MetodoFalsaPosicion(float a, float b, DataGridView dgvResultado)
        {
            float p, ErrorAct = 0;
            int i;
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();

            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("aproximacion", "p");
            dgvResultado.Columns.Add("F_a", "F(a)");
            dgvResultado.Columns.Add("F_b", "F(b)");
            dgvResultado.Columns.Add("F_p", "F(p)");
            dgvResultado.Columns.Add("Error", "error");

            i = 1;
            while (i <= NumIter)
            {
                p = (b - (Func(b) * ((b - a) / (Func(b) - Func(a)))));

                if (Func(a) * Func(p) < 0)
                {
                    ErrorAct = Math.Abs(b - p);
                }
                else if (Func(b) * Func(p) < 0)
                {
                    ErrorAct = Math.Abs(a - p);
                }


                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = b;
                dgvResultado.Rows[i - 1].Cells[3].Value = p;
                dgvResultado.Rows[i - 1].Cells[4].Value = Func(a);
                dgvResultado.Rows[i - 1].Cells[5].Value = Func(b);
                dgvResultado.Rows[i - 1].Cells[6].Value = Func(p);
                dgvResultado.Rows[i - 1].Cells[7].Value = ErrorAct;

                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado" + p.ToString(),
                        "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                if (Func(a) * Func(p) < 0)
                {
                    b = p;
                }
                else
                {
                    a = p;
                }
                i++;
            }
            MessageBox.Show("No se pudo obtener la raiz con el error deseado", "AVISO",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        public bool MetodoNewton(float a, DataGridView dgvResultado)
        {
            float c, ErrorAct;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("F_a", "F(a)");
            dgvResultado.Columns.Add("FD_a", "F'(a)");
            dgvResultado.Columns.Add("aproximacion", "c");
            dgvResultado.Columns.Add("Error", "error");

            if (FuncD(a) == 0)
            {
                MessageBox.Show("No se puede aplicar el método de Newton", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            i = 1;
            while (i <= NumIter)
            {
                c = a - (Func(a) / FuncD(a));
                ErrorAct = Math.Abs(c - a);

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = Func(a);
                dgvResultado.Rows[i - 1].Cells[3].Value = FuncD(a);
                dgvResultado.Rows[i - 1].Cells[4].Value = c;
                dgvResultado.Rows[i - 1].Cells[5].Value = ErrorAct;

                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado. Raiz=" + c.ToString(), "AVISO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                a = c;

                i++;

            }
            MessageBox.Show("No se pudo obtener la raiz con el error deseado", "AVISO",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }


        public bool MetodoPuntoFijo(float a, DataGridView dgvResultado)
        {
            float c, ErrorAct;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("aproximacion", "g(a)");
            dgvResultado.Columns.Add("Error", "error");

            i = 1;
            while (i <= NumIter)
            {
                c = FuncG(a);
                ErrorAct = Math.Abs(FuncG(a) - a);

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = c;
                dgvResultado.Rows[i - 1].Cells[3].Value = ErrorAct;

                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado" + c.ToString(),
                        "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                a = c;

                i++;
            }
            MessageBox.Show("No se pudo obtener la raiz con el error deseado", "AVISO",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        public bool MetSecante(float a, float b, DataGridView dgvResultado)
        {
            float c, ErrorAct;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("aproximacion", "c");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("F_a", "F(a)");
            dgvResultado.Columns.Add("F_b", "F(b)");
            dgvResultado.Columns.Add("F_c", "F(c)");
            dgvResultado.Columns.Add("Error", "error");

            i = 1;
            while (i <= NumIter)
            {
                c = a - Func(a) * (b - a) / (Func(b) - Func(a));
                ErrorAct = Math.Abs(c - b);

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = b;
                dgvResultado.Rows[i - 1].Cells[3].Value = c;
                dgvResultado.Rows[i - 1].Cells[4].Value = Func(a);
                dgvResultado.Rows[i - 1].Cells[5].Value = Func(b);
                dgvResultado.Rows[i - 1].Cells[6].Value = Func(c);
                dgvResultado.Rows[i - 1].Cells[7].Value = ErrorAct;

                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado. Raiz=" + c.ToString(), "AVISO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                a = b;
                b = c;

                i++;

            }
            MessageBox.Show("No se pudo obtener la raiz con el error deseado", "AVISO",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }


        public bool MetodoMuller(Complex p0, Complex p1, Complex p2, ref DataGridView dgvResultado)
        {
            float ErrorAct;
            Complex p = new Complex(), a = new Complex(), b = new Complex(), c = new Complex();
            Complex Fp1MFp2 = new Complex();
            Complex Fp0MFp2 = new Complex();
            Complex p0Mp2 = new Complex();
            Complex p0Mp1 = new Complex();
            Complex p1Mp2 = new Complex();
            Complex Divisor = new Complex();
            Complex D = new Complex();
            Complex E = new Complex();
            Complex Aux = new Complex();

            int i;
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_p0", "p0");
            dgvResultado.Columns.Add("valor_p1", "p1");
            dgvResultado.Columns.Add("valor_p2", "p2");
            dgvResultado.Columns.Add("p", "p");
            dgvResultado.Columns.Add("Error", "error");

            i = 1;
            while (i <= NumIter)
            {
                p0Mp2 = Complex.Subtract(p0, p2);
                p0Mp1 = Complex.Subtract(p0, p1);
                p1Mp2 = Complex.Subtract(p1, p2);
                Fp1MFp2 = Complex.Subtract(FunCompleja(p1), FunCompleja(p2));
                Fp0MFp2 = Complex.Subtract(FunCompleja(p0), FunCompleja(p1));

                Divisor = Complex.Multiply(p0Mp2, p1Mp2);
                Divisor = Complex.Multiply(Divisor, p0Mp1);

                c = FunCompleja(p2);

                b = Complex.Pow(p0Mp2, 2) * Fp1MFp2 - Complex.Pow(p1Mp2, 2) * Fp0MFp2;
                b = Complex.Divide(b, Divisor);

                a = p1Mp2 * Fp0MFp2 - p0Mp2 * Fp1MFp2;
                a = Complex.Divide(a, Divisor);

                D = Complex.Sqrt(Complex.Subtract(Complex.Pow(b, 2), Complex.Multiply(new Complex(4, 0), Complex.Multiply(a, c))));


                if (Complex.Abs(Complex.Subtract(b, D)) < Complex.Abs(Complex.Add(b, D)))
                {
                    E = Complex.Add(b, D);
                }
                else
                {
                    E = Complex.Subtract(b, D);
                }
                p = Complex.Subtract(p2, Complex.Divide(Complex.Multiply(new Complex(2, 0), c), E));

                ErrorAct = (float)Complex.Abs(Complex.Divide(Complex.Multiply(new Complex(2, 0), c), E));

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = p0;
                dgvResultado.Rows[i - 1].Cells[2].Value = p1;
                dgvResultado.Rows[i - 1].Cells[3].Value = p2;
                dgvResultado.Rows[i - 1].Cells[4].Value = p;
                dgvResultado.Rows[i - 1].Cells[5].Value = ErrorAct;

                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado. Raiz =" + p.ToString(), "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                p0 = p1;
                p1 = p2;
                p2 = p;
                i++;
            }
            MessageBox.Show("No se pudo obtener la aprox con el error deseado.", "AVISO", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;


        }


        public bool MetodoSteffensen(float p0, DataGridView dgvResultado)
        {
            float p1, p2, p, ErrorAct;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_p0", "p0");
            dgvResultado.Columns.Add("valor_p1", "p1");
            dgvResultado.Columns.Add("valor_p2", "p2");
            dgvResultado.Columns.Add("aproximacion", "p");
            dgvResultado.Columns.Add("Error", "error");

            i = 1;
            while (i <= NumIter)
            {
                p1 = FuncS(p0);
                p2 = FuncS(p1);
                p = p0 - (float)Math.Pow(p1 - p0, 2) / (p2 - 2 * p1 + p0);

                ErrorAct = Math.Abs(p - p2);

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = p0;
                dgvResultado.Rows[i - 1].Cells[2].Value = p1;
                dgvResultado.Rows[i - 1].Cells[3].Value = p2;
                dgvResultado.Rows[i - 1].Cells[4].Value = p;
                dgvResultado.Rows[i - 1].Cells[5].Value = ErrorAct;

                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado" + p.ToString(),
                        "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                i++;
                p0 = p;

            }
            MessageBox.Show("No se pudo obtener la raiz con el error deseado", "AVISO",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        public bool MetodoAitkenBiseccion(float a, float b, DataGridView dgvResultado)
        {
            float p0, p1, p2, p, a1 = 0, b1 = 0, a2 = 0, b2 = 0, ErrorAct;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("valor_p0", "p0");
            dgvResultado.Columns.Add("F_a", "F(a)");
            dgvResultado.Columns.Add("F_b", "F(b)");
            dgvResultado.Columns.Add("F_p0", "F(p0)");

            dgvResultado.Columns.Add("valor_a1", "a1");
            dgvResultado.Columns.Add("valor_b1", "b1");
            dgvResultado.Columns.Add("valor_p1", "p1");
            dgvResultado.Columns.Add("F_a1", "F(a1)");
            dgvResultado.Columns.Add("F_b1", "F(b1)");
            dgvResultado.Columns.Add("F_p1", "F(p1)");

            dgvResultado.Columns.Add("valor_a2", "a2");
            dgvResultado.Columns.Add("valor_b2", "b2");
            dgvResultado.Columns.Add("valor_p2", "p2");
            dgvResultado.Columns.Add("F_a2", "F(a2)");
            dgvResultado.Columns.Add("F_b2", "F(b2)");
            dgvResultado.Columns.Add("F_p2", "F(p2)");

            dgvResultado.Columns.Add("valor_p", "p");
            dgvResultado.Columns.Add("F_p", "F(p)");

            dgvResultado.Columns.Add("Error", "error");

            if (FuncA(a) * FuncA(b) > 0)
            {
                MessageBox.Show("No se puede aplicar el metodo de biseccion", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            i = 1;
            while (i <= NumIter)
            {
                p0 = (a + b) / 2;
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = b;
                dgvResultado.Rows[i - 1].Cells[3].Value = p0;
                dgvResultado.Rows[i - 1].Cells[4].Value = FuncA(a);
                dgvResultado.Rows[i - 1].Cells[5].Value = FuncA(b);
                dgvResultado.Rows[i - 1].Cells[6].Value = FuncA(p0);


                if (FuncA(a) * FuncA(p0) < 0)
                {
                    b1 = p0;
                    a1 = a;
                }
                else
                {
                    a1 = p0;
                    b1 = b;
                }

                p1 = (a1 + b1) / 2;


                dgvResultado.Rows[i - 1].Cells[7].Value = a1;
                dgvResultado.Rows[i - 1].Cells[8].Value = b1;
                dgvResultado.Rows[i - 1].Cells[9].Value = p1;
                dgvResultado.Rows[i - 1].Cells[10].Value = FuncA(a1);
                dgvResultado.Rows[i - 1].Cells[11].Value = FuncA(b1);
                dgvResultado.Rows[i - 1].Cells[12].Value = FuncA(p1);

                if (FuncA(a1) * FuncA(p1) < 0)
                {
                    b2 = p1;
                    a2 = a1;
                }
                else
                {
                    a2 = p1;
                    b2 = b1;
                }

                p2 = (a2 + b2) / 2;


                dgvResultado.Rows[i - 1].Cells[13].Value = a2;
                dgvResultado.Rows[i - 1].Cells[14].Value = b2;
                dgvResultado.Rows[i - 1].Cells[15].Value = p2;
                dgvResultado.Rows[i - 1].Cells[16].Value = FuncA(a2);
                dgvResultado.Rows[i - 1].Cells[17].Value = FuncA(b2);
                dgvResultado.Rows[i - 1].Cells[18].Value = FuncA(p2);

                p = p0 - (float)Math.Pow(p1 - p0, 2) / (p2 - 2 * p1 + p0);
                ErrorAct = Math.Abs(p - p2);

                if (FuncA(a) * FuncA(p2) < 0)
                {
                    b = p2;
                    a = p;
                }
                else
                {
                    a = p2;
                    b = p;
                }

                dgvResultado.Rows[i - 1].Cells[19].Value = p;
                dgvResultado.Rows[i - 1].Cells[20].Value = FuncA(p);
                dgvResultado.Rows[i - 1].Cells[21].Value = ErrorAct;

                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado" + p.ToString(),
                        "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }


                i++;
            }

            MessageBox.Show("No se pudo obtener la raiz con el error deseado", "AVISO",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }


        public bool MetodoAitkenSecante(float p0, float p1, DataGridView dgvResultado)
        {
            float p2, p, ErrorAct;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_p0", "p0");
            dgvResultado.Columns.Add("valor_p1", "p1");
            dgvResultado.Columns.Add("valor_p2", "p2");
            dgvResultado.Columns.Add("valor_p", "p");
            dgvResultado.Columns.Add("F_p0", "F(p0)");
            dgvResultado.Columns.Add("F_p1", "F(p1)");
            dgvResultado.Columns.Add("F_p2", "F(p2)");
            dgvResultado.Columns.Add("F_p", "F(p)");
            dgvResultado.Columns.Add("Error", "error");

            i = 1;
            while (i <= NumIter)
            {
                p2 = p0 - FuncA(p0) * ((p1 - p0) / (FuncA(p1) - FuncA(p0)));

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = p0;
                dgvResultado.Rows[i - 1].Cells[2].Value = p1;
                dgvResultado.Rows[i - 1].Cells[3].Value = p2;
                dgvResultado.Rows[i - 1].Cells[4].Value = FuncA(p0);
                dgvResultado.Rows[i - 1].Cells[5].Value = FuncA(p1);
                dgvResultado.Rows[i - 1].Cells[6].Value = FuncA(p2);

                p = p0 - (float)Math.Pow(p1 - p0, 2) / (p2 - 2 * p1 + p0);
                ErrorAct = Math.Abs(p - p2);

                dgvResultado.Rows[i - 1].Cells[3].Value = p;
                dgvResultado.Rows[i - 1].Cells[6].Value = FuncA(p);
                dgvResultado.Rows[i - 1].Cells[7].Value = ErrorAct;

                if (ErrorAct <= errorMax)
                {
                    MessageBox.Show("Se obtuvo la raiz con el error deseado. Raiz=" + p.ToString(), "AVISO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                p0 = p;
                p1 = p2;
                i++;

            }
            MessageBox.Show("No se pudo obtener la raiz con el error deseado", "AVISO",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }


        public bool MetodoHorner(int grado, float[] coeficientes, Complex p0, Complex p1, Complex p2, DataGridView dgvResultado)
        {
            Complex[] hornerCoeficientes = new Complex[coeficientes.Length];

            for (int i = 0; i < coeficientes.Length; i++)
            {
                hornerCoeficientes[i] = new Complex(coeficientes[i], 0);
            }

            Complex[] raices = new Complex[grado];

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("indice", "Índice");
            dgvResultado.Columns.Add("raizReal", "Raíz Real");
            dgvResultado.Columns.Add("raizImaginaria", "Raíz Imaginaria");

            raices[0] = MetodoMulleReal(p0, p1, p2, grado, hornerCoeficientes);
            dgvResultado.Rows.Add(0, raices[0].Real, raices[0].Imaginary);

            for (int i = 1; i < grado; i++)
            {
                hornerCoeficientes = HornerCoeficientes(hornerCoeficientes, raices[i - 1]);

                if (grado - i > 2)
                {
                    p0 = raices[i - 1];
                    p1 = p0 + new Complex(1, 0); // Ajuste inicial para Müller
                    p2 = p1 + new Complex(1, 0);

                    raices[i] = MetodoMulleReal(p0, p1, p2, grado - i, hornerCoeficientes);
                    dgvResultado.Rows.Add(i, raices[i].Real, raices[i].Imaginary);
                }
                else
                {
                    // Resolver el caso de un polinomio cuadrático (grado 2)
                    Complex a = hornerCoeficientes[0];
                    Complex b = hornerCoeficientes[1];
                    Complex c = hornerCoeficientes[2];

                    Complex discriminante = Complex.Pow(b, 2) - (4 * a * c);

                    if (discriminante.Real >= 0)
                    {
                        raices[grado - 2] = (-b + Complex.Sqrt(discriminante)) / (2 * a);
                        raices[grado - 1] = (-b - Complex.Sqrt(discriminante)) / (2 * a);
                    }
                    else
                    {
                        raices[grado - 2] = (-b + Complex.Sqrt(discriminante)) / (2 * a);
                        raices[grado - 1] = (-b - Complex.Sqrt(discriminante)) / (2 * a);
                    }

                    dgvResultado.Rows.Add(grado - 2, raices[grado - 2].Real, raices[grado - 2].Imaginary);
                    dgvResultado.Rows.Add(grado - 1, raices[grado - 1].Real, raices[grado - 1].Imaginary);

                    return true;
                }
            }

            return true;
        }

        public Complex MetodoMulleReal(Complex p0, Complex p1, Complex p2, int grado, Complex[] coeficientes)
        {
            float ErrorAct;
            Complex p = new Complex(), a = new Complex(), b = new Complex(), c = new Complex();
            Complex Fp1MFp2 = new Complex();
            Complex Fp0MFp2 = new Complex();
            Complex p0Mp2 = new Complex();
            Complex p0Mp1 = new Complex();
            Complex p1Mp2 = new Complex();
            Complex Divisor = new Complex();
            Complex D = new Complex();
            Complex E = new Complex();

            int i = 1;

            while (i <= NumIter)
            {
                p0Mp2 = Complex.Subtract(p0, p2);
                p0Mp1 = Complex.Subtract(p0, p1);
                p1Mp2 = Complex.Subtract(p1, p2);
                Fp1MFp2 = Complex.Subtract(FuncPol(grado, coeficientes, p0), FuncPol(grado, coeficientes, p2));
                Fp0MFp2 = Complex.Subtract(FuncPol(grado, coeficientes, p0), FuncPol(grado, coeficientes, p2));

                Divisor = Complex.Multiply(p0Mp2, p1Mp2);
                Divisor = Complex.Multiply(Divisor, p0Mp1);

                c = FuncPol(grado, coeficientes, p2);

                b = Complex.Pow(p0Mp2, 2) * Fp1MFp2 - Complex.Pow(p1Mp2, 2) * Fp0MFp2;
                b = Complex.Divide(b, Divisor);

                a = p1Mp2 * Fp0MFp2 - p0Mp2 * Fp1MFp2;
                a = Complex.Divide(a, Divisor);

                D = Complex.Sqrt(Complex.Subtract(Complex.Pow(b, 2), Complex.Multiply(new Complex(4, 0), Complex.Multiply(a, c))));

                E = Complex.Abs(Complex.Subtract(b, D)) < Complex.Abs(Complex.Add(b, D)) ? Complex.Add(b, D) : Complex.Subtract(b, D);

                p = Complex.Subtract(p2, Complex.Divide(Complex.Multiply(new Complex(2, 0), c), E));

                ErrorAct = (float)Complex.Abs(Complex.Divide(Complex.Multiply(new Complex(2, 0), c), E));

                if (ErrorAct <= errorMax)
                {
                    return p;
                }

                p0 = p1;
                p1 = p2;
                p2 = p;
                i++;
            }

            throw new Exception("No se pudo obtener la aproximación con el error deseado.");
        }

        private Complex FuncPol(int grado, Complex[] coeficientes, Complex x)
        {
            Complex resultado = 0;
            for (int i = 0; i <= grado; i++)
            {
                int exponente = grado - i;
                Complex coeficiente = coeficientes[i];

                resultado += coeficiente * ((Complex)Complex.Pow(x, (double)exponente));
            }

            return resultado;
        }


      

        private Complex[] HornerCoeficientes(Complex[] coeficientes, Complex x)
        {
            Complex[] nuevosCoeficientes = new Complex[coeficientes.Length - 1];

            nuevosCoeficientes[0] = coeficientes[0];

            for (int i = 1; i < coeficientes.Length - 1; i++)
            {
                nuevosCoeficientes[i] = coeficientes[i] + nuevosCoeficientes[i - 1] * x;

            }

            return nuevosCoeficientes;
        }

        // Funcion polinomio
       

        // Funcion Polinomio derivado
        private float FuncPolDer(int grado, float[] coeficientes, float x)
        {
            float resultado = 0;

            for (int i = 0; i < grado; i++)
            {
                int exponente = grado - i - 1;
                float coeficiente = coeficientes[i] * (grado - i);

                resultado += coeficiente * ((float)Math.Pow((double)x, (double)exponente));
            }

            return resultado;
        }


        private Complex FunCompleja(Complex x)
        {
            Complex r = new Complex();
            r = Complex.Pow(x, 2) - new Complex(3, 0);
            return r;
        }
        private float Func(float x)
        {
            float r;
            r = (float)(Math.Pow((double)x, (double)2.0) - 3.0);
            return r;
        }
        private float FuncD(float x)
        {
            float r;
            r = 2 * x;
            return r;
        }
        private float FuncG(float x)
        {
            float r;
            r = ((((x)) - (((float)(Math.Pow((double)x, (double)3.0))) + (4 * (float)(Math.Pow((double)x, (double)2.0)) -(10)))/
                ((3 * (float)(Math.Pow((double)x, (double)2.0))) + (8*x))));
            return r;
        }
        private float FuncS(float x) {
            float r;
            r = (float)Math.Sqrt(10 / (x+4));
            return r;
        }

        private float FuncA(float x)
        {
            float r;
            r = (((float)(Math.Pow((double)x, (double)3.0))) + (4 * (float)(Math.Pow((double)x, (double)2.0)) - (10)));
            return r;
        }
    }
}
