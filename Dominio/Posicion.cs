using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Posicion
    {
        private string nombre;
        private int numPosicion;//aca la idea es que el numero es igual al ID.

        public string Nombre { get => nombre; set => nombre = value; }
        public int NumPosicion { get => numPosicion; set => numPosicion = value; }
    }
}
