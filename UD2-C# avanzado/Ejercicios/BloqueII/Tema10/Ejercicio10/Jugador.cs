using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    class Jugador
    {
        //Atributos
        private int id;
        private String nombre;
        private bool vivo;

        //Contructor
        public Jugador(int id)
        {
            this.id = id;
            this.nombre = "Jugador " + id;
            this.vivo = true;
        }

        //Propiedades

        /**
         * El jugador dispara el revolver
         * @param r 
         */
        public void disparar(Revolver r)
        {

            MessageBox.Show("El " + nombre + " se apunta con la pistola");

            //El jugador se pone el revolver y...
            if (r.disparar())
            {
                this.vivo = false; //muere
                MessageBox.Show("El " + nombre + " ha muerto...");
            }
            else
            {
                MessageBox.Show("El " + nombre + " se ha librado..."); //No muere
            }

        }

        public bool isVivo()
        {
            return vivo;
        }
    }
}
