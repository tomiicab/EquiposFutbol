using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Jugador : Persona
    {
        private int numCamiseta;
        public int NumCamiseta { get => numCamiseta; set => numCamiseta = value; }
        public Posicion Posicion { get; set; }

        public Jugador(string nom, string dni, DateTime fecha, int camiseta) : base(nom,dni,fecha)
        {
            Posicion = new Posicion();
            Dni = dni;
            NombreCompleto = nom;
            FechaNac = fecha;
            NumCamiseta = camiseta;
        }

        public Jugador()
        {
            numCamiseta = 0;
        }

    }
}
