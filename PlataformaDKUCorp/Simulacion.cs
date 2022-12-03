using PlataformaDKUCorp.Interfaz_Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp
{
    internal class Simulacion
    {

        private double presupuestoRondaInit; //X
        private double  _precioProd; // X
        private int numrondas; // X
        public int rndActual; //contador de ronda actual manejado por for loop de IniciarSimulacion()
        private DateTime inicio, fin;
        public int[] maquinaria = new int[2] {
            //Valor en lps
            0,
            //Años de Vida util
            3,
        };

        //public ?? demandaInit;
        //public ?? demandaContinua;
        protected internal string[] localidades =  new string [6] { "La Ceiba", "Tegucigalpa", "San Pedro Sula",
            "Choluteca", "Juticalpa", "Comayagua" };
        protected internal string[] productos = new string[2];

        public double PresupuestoRondaInit { get => presupuestoRondaInit; set => presupuestoRondaInit = value; }
        public double PrecioProd { get => _precioProd; set => _precioProd = value; }
        public DateTime Inicio { get => inicio;
            set {
                if (value != null) {
                    inicio = value;
                    this.Fin= value.AddHours(1);
                }
            }
        }
        public DateTime Fin { get => fin; set => fin = value; }
        public int Numrondas { get => numrondas; set => numrondas = value; }

        /*
         *
         * INICIO CONSTRUCTOR
         *
         */

        public Simulacion(double presRndIni, double precioProd, int rondas, double maqValor) {
            PresupuestoRondaInit= presRndIni;
            PrecioProd = precioProd;
            Numrondas= rondas;
            this.maquinaria[0] = (int)maqValor;
        }

        /*
         *
         * FIN CONSTRUCTOR
         *
         */

        public bool VerificarTiempo(DateTime tiempoactual) {
            if (tiempoactual.TimeOfDay > this.Fin.TimeOfDay)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void DespreciarMaquinaria() { 
            
        }

        public void IniciarSimulacion()
        {
            //Estudiante entra a simulcion por click de boton
            //se invoca IniciarSimulacion() y se entra a este codigo de bloquee
            DateTime tmpActualEst = DateTime.Now;
  
            for (this.rndActual = 1; this.rndActual <= Numrondas;this.rndActual++)
            {
                if (VerificarTiempo(tmpActualEst))
                {
                    MessageBox.Show("Termino el tiempo de la simulación, gracias por participar");
                }
                else
                {
                    //salga frm de Est-Simulacion
                    var frmSim = new Est_Simulacion();
                    //hacer lo demas

                }
            }
        }
    }
}
