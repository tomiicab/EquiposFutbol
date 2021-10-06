using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {

        private string nombreCompleto, dni;
        private DateTime fechaNac;

        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Dni { get => dni; set => dni = value; }

        public Persona(string nombre, string dni, DateTime fecha)
        {
            NombreCompleto = nombre;
            Dni = dni;
            FechaNac = fecha;
        }

        public Persona()
        {

            nombreCompleto = dni = "";
            fechaNac = DateTime.Now;
        }




    }
}
