using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_LocalDeSushi.src
{
    public class Commons
    {
        static Random random = new Random();

        public double generar_IA()
        {
            return 0;
        }

        public double generar_TA()
        {
            double ta = 0;
            var r = random.NextDouble(); //me devuelve un random entre 0..1

            if (r <= 0.02)
            {
                ta = Datos.TIEMPO_ZONA_4;
            }
            else
            {
                if ((0.02 < r) && (r <= 0.12))
                {
                    ta = Datos.TIEMPO_ZONA_3;
                }
                else
                {
                    if ((0.12 < r) && (r <= 0.25))
                    {
                        ta = Datos.TIEMPO_ZONA_2;
                    }
                    else
                    {
                        if ((0.25 < r) && (r <= 0.35))
                        {
                            ta = Datos.TIEMPO_ZONA_1;
                        }
                        else
                        {
                            //PEDIDO MOSTRADOR -> NO HAY MOTO
                            ta = 0;
                            return ta;
                        }
                    }
                }
            }

            var r2 = random.NextDouble();

            if (r2 <= Datos.OCURRENCIA_MENU)
            {
                ta += Datos.TIEMPO_MENU_1;
            }
            else
            {
                ta += Datos.TIEMPO_MENU_2;
            }

            return ta;
        }

        public double[] calcular_PTO(int cm, double t, double[] sto) 
        {
            double[] pto = new double[cm];

            for (int i = 0; i < cm; i++)
            {
                pto[i] = (sto[i] * 100) / t;
            }

            return pto;
        }

        public int get_menor_TC_i_(double[] tc, int cm)
        {
            double tc_min = tc[0];
            int i_min = 0;

            for (int i = 1; i < (cm - 1); i++)
            {
                double tc_i = tc[i];

                if (tc_i < tc_min)
                {
                    tc_min = tc_i;
                    i_min = i;
                }
            }

            return i_min;
        }

        public bool arrepentimiento(double tc_i, double t)
        {
            return ((tc_i - t) >= 90);
        }

    }
}
