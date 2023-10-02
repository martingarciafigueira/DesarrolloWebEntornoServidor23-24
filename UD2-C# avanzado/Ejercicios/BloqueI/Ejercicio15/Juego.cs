using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Juego
    {
        int puntuacion;

        public Juego(int puntuacion)
        {
            this.Puntuacion = puntuacion;
        }

        public void inicializar()
        {
            this.puntuacion = 0;
        }

        public void incrementar()
        {
            this.puntuacion++;
        }
        public void reducir()
        {
            this.puntuacion--;
        }

        public int Puntuacion { get => puntuacion; set => puntuacion = value; }
    }
}
