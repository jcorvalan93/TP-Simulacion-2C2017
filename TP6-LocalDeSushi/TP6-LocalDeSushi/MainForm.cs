﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP6_LocalDeSushi.src;

namespace TP6_LocalDeSushi
{
    public partial class MainForm : Form
    {
        #region "Variables"
        int cm;
        double t;
        double tpll; //tiempo proximo de llegada
        double ia; //intervalo entre arrivos
        double ta; //tiempo de atencion
        double ct; //cantidad total
        double[] tc; //tiempo comprometido de cada moto
        double[] sto; //sumatoria de tiempo oscioso de cada moto
        double ste; //
        int ca;  //cantidad de arrepentidos
        double tf;  //tiempo final
        double pec; //promedio de espera en cola
        double[] pto; //porcentaje de tiempo oscioso
        double pa; //porcentaje de arrepentidos
        #endregion
        Commons aux;

        public MainForm()
        {
            InitializeComponent();
            aux = new Commons();
        }

        private void inicializar_variables()
        {
            t = 0;
            tpll = 0;
            ia = 0;
            ta = 0;
            ct = 0;
            ste = 0;
            ca = 0;
            tf = Convert.ToDouble(tfNUD.Value);
            pec = 0;
            pa = 0;

            tc = new double[cm];
            sto = new double[cm];
            //pto = new double[cm]; //lo creo al final dentro del metodo "calcular_PTO"

            for (int i = 0; i < cm; i++)
            {
                tc[i] = 0;
                sto[i] = 0;
                //pto[i] = 0;
            }
        }

        public void borrar_todo()
        {
            cmNUD.Value = 0;
            tfNUD.Value = 0;
            paTB.Text = "";
            pecTB.Text = "";
            ptoLB.Items.Clear();
        }

        private void simularBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cm = Convert.ToInt32(cmNUD.Value);

                inicializar_variables();
                ejecutar_sumilacion();
                procesar_resultados();
                imprimir_resultados();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicacion.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ejecutar_sumilacion()
        {
            Start: 
                t = tpll;
                ia = aux.generar_IA(); //IA
                tpll += ia;
                ta = aux.generar_TA(); //TA

                if (ta == 0)
                {
                    //VUELVO AL COMIENZO
                    //goto Start;
                }
                else
                {
                    ct++;
                    var i_min = aux.get_menor_TC_i_(tc, cm);
                    var tc_min = tc[i_min]; //MENOR TC(i)

                    if (t >= tc_min)
                    {
                        sto[i_min] += (t - tc[i_min]);
                        tc[i_min] = t + ta;
                    }
                    else
                    {
                        if (aux.arrepentimiento(tc_min, t))
                        {
                            ca++;
                            //goto Start;
                        }
                        else
                        {
                            //NO HUBO ARREPENTIMIENTO
                            ste += (tc[i_min] - t);
                            tc[i_min] += ta;
                        }
                    }
                }

                if (t <= tf)
                {
                    goto Start;
                }
                else
                {
                    return;
                }
        }

        private void procesar_resultados()
        {
            if ((ct - ca) != 0)
                pec = ste / (ct - ca);
            else
                pec = 0;

            pto = aux.calcular_PTO(cm, t, sto);

            if (ct != 0)
                pa = (ca * 100) / ct;
            else
                pa = 0;
        }

        private void imprimir_resultados()
        {
            var cm_val = cmNUD.Value;
            var tf_val = tfNUD.Value;
            borrar_todo();

            cmNUD.Value = cm_val;
            tfNUD.Value = tf_val;

            paTB.Text = pa.ToString("#.##");
            pecTB.Text = pec.ToString("#.##");
            pptoTB.Text = (pto.Sum() / cm).ToString("#.##");

            for (int i = 0; i < cm; i++)
            {
                string moto_i = String.Format("Moto {0}  --  PTO = {1}", i.ToString(), pto[i].ToString("#.##"));

                ptoLB.Items.Add(moto_i);
            }
        }
    }
}
