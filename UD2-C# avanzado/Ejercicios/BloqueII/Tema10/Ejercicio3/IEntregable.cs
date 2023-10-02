using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    interface IEntregable
    {
        public void entregar();
        public void devolver();
        public bool isEntregado();
        public int compareTo(Object a);
    }
}
