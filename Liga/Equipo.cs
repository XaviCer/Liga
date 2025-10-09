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
         
        public Categoria categoriaEquipo { get; set; }

        public string nombreEquipo { get; set; }
        public Equipo()
        {
        }

        public Equipo(Categoria categoriaequipo, string nombre)
        {
            categoriaEquipo = categoriaequipo;  
            nombreEquipo = nombre;
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

        public Equipo AñadirJugador(Equipo equipo, Jugador jugador)
        {

            equipo.ListaJugadores.Add(jugador);
            return equipo;
        }



    }

    
}