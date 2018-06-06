using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_de_Procesos
{
    class Proceso
    {
        public int ciclo { get; set; }
        public Proceso siguiente { get; set; }

        Random aleatorio = new Random();

        public Proceso()
        {
            ciclo = aleatorio.Next(4, 15);
        }

        public override string ToString()
        {
            return "Ciclos" + ciclo;
        }
    }
}
