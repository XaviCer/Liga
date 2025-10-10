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
        public Jugador QuitarJugador(int numero)
        {
            Jugador jugadorEliminado = ListaJugadores[numero];
            ListaJugadores.RemoveAt(numero);
            return jugadorEliminado;
        }

        public void AñadirJugador(Jugador jugador)
        {
            ListaJugadores.Add(jugador);
        }

        public void ListarNombreJugadores()
        {
            for (int i = 0; i<ListaJugadores.Count; i++)
                Console.WriteLine((i+1).ToString("00")+". Nombre: " + ListaJugadores[i].Nombre);
        }
    }
}