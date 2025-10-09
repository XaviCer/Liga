using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Liga.Equipo;

namespace Liga
{

    internal class Equipo
    {
        public List<Jugador> ListaJugadores = new List<Jugador>();
       
        public enum Categoria   
        {
            masculino1,
            masculino2,
            femenino1
        };
         
        public Categoria CategoriaEquipo { get; set; }

        public string NombreEquipo { get; set; }
        public Equipo()
        {
        }

        public Equipo(Categoria categoriaequipo, string nombre)
        {
            CategoriaEquipo = categoriaequipo;  
            NombreEquipo = nombre;
        }



        //Quitar y poner jugadores para fichajes
        public Equipo QuitarJugador(Equipo equipo, string nombre, string apellido1, string apellido2)
        {

            for (int i = 0; i < equipo.ListaJugadores.Count; i++ )
            {
                if (equipo.ListaJugadores[i].Nombre.ToUpper() == nombre.ToUpper() & equipo.ListaJugadores[i].Apellido1.ToUpper() == apellido1.ToUpper() & equipo.ListaJugadores[i].Apellido2.ToUpper() == apellido2.ToUpper())
                    equipo.ListaJugadores.RemoveAt(i);
            }
            return equipo;
        }

        public void AñadirJugador(Jugador jugador)
        {
            ListaJugadores.Add(jugador);
        }
    }
}