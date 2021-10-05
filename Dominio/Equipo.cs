using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Equipo
    {
        private string nombreEquipo, directorTecnico;
        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public string DirectorTecnico { get => directorTecnico; set => directorTecnico = value; }

        //ACA DIGO, QUE UN EQUIPO SE FORMA DE UNO O VARIOS JUGADORES
        //POR ESO CREO UNA LISTA DE JUGADORES.

        public List<Jugador> Jugadores { get; }

        public Equipo(string nombE, string DT)
        {
            NombreEquipo = nombE;
            DirectorTecnico = DT;
            Jugadores = new List<Jugador>();

        }

        
        public Equipo()
        {
            nombreEquipo = directorTecnico = "";
        }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }
    }
}
