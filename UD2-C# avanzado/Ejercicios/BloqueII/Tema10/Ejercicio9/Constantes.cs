using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Constantes
    {
        public readonly int NUMERO_PARTIDOS = 2;

        public readonly int NUMERO_JORNADAS = 38;
        public readonly double DINERO_INICIAL = 35;

        public readonly int RESULTADO_MINIMO = 0;
        public readonly int RESULTADO_MAXIMO = 3;

        public readonly double DINERO_CADA_JORNADA = 1;

        public readonly Jugador[] JUGADORES ={
                                    new Jugador("Make"),
                                    new Jugador("JuanMa"),
                                    new Jugador("Fernando"),
                                    new Jugador("Alberto"),
                                    new Jugador("Lorente")
                                };
    }
}
