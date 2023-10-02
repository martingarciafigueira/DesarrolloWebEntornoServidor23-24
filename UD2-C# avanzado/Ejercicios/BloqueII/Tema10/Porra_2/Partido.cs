using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porra_2
{
    class Partido
    {
        private DateTime fecha;
        private Tuple<Equipo, Equipo> equipos;
        private (Tuple<Equipo, int> golesEquipo1, Tuple<Equipo, int> golesEquipo2) resultado;
        private int jornada;
    }
}
