using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionFutbol();
        }

        static void GestionFutbol()
        {
            int opcion;
            bool salir = false;
            do
            {
                Console.WriteLine("Ejercicio Gestión club de fútbol");
                Console.WriteLine("================================");
                Console.WriteLine("1. Cargar datos iniciales");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");

                Console.Write("Elige una opción: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        CargaDatosIniciales();
                        break;
                    default:
                        salir = true;
                        break;
                }
            } while (!salir);
            // Pause fin
            Console.ReadKey();
        }

        static void CargaDatosIniciales()
        {
            Club club1 = new Club("F.C.Barcelona", 1890);
            Equipo equipo1 = new Equipo(Equipo.Categoria.masculino1,"Primer equipo");
            Jugador jugador1 = new Jugador("Lamine", "bbbbb", "ccccc", 'h', 30, 1000);
            Jugador jugador2 = new Jugador("Xavi", "bbbbb", "ccccc", 'h', 30, 1000);
            Jugador jugador3 = new Jugador("Jordi", "bbbbb", "ccccc", 'h', 30, 1000);
            Jugador jugador4 = new Jugador("Iban", "bbbbb", "ccccc", 'h', 30, 1000);
            Jugador jugador5 = new Jugador("Julian", "bbbbb", "ccccc", 'h', 30, 1000);

            equipo1.AñadirJugador(jugador1);
            equipo1.AñadirJugador(jugador2);
            equipo1.AñadirJugador(jugador3);
            equipo1.AñadirJugador(jugador4);
            equipo1.AñadirJugador(jugador5);

            Console.WriteLine("Club: " + club1.Nombre);
            Console.WriteLine("Equipo: " + equipo1.NombreEquipo);
            for (int i = 0; i < equipo1.ListaJugadores.Count; i++)
            {
                equipo1.ListaJugadores[i].Muestra();
            }
        }
    }
}
