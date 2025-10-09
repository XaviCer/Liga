using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    internal class Program
    {
        static Equipo Equipo1 = new Equipo();
        static Jugador Jugador = new Jugador();

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
                Console.WriteLine("1. Dar de alta un club");
                Console.WriteLine("2. Dar de alta un equipo");
                Console.WriteLine("3. Dar de alta un jugador");
                Console.WriteLine("4. Meter el jugador en un equipo");

                Console.Write("Elige una opción: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        AltaClub();
                        break;
                    case 2:
                        AltaEquipo();
                        break;
                    case 3:
                        AltaJugador();
                        break;
                    case 4:
                        MeterJugador();
                        break;
                    default:
                        salir = true;
                        break;
                }
            } while (!salir);
            // Pause fin
            Console.ReadKey();
        }

        static void AltaClub()
        {

        }

        static void AltaEquipo()
        {
            Equipo1.NombreEquipo = "Manolo";
        }

        static void AltaJugador()
        {
            Jugador.Alta();
            Jugador.Muestra();
        }

        static void MeterJugador()
        {
            Equipo1.AñadirJugador(Equipo1, Jugador);
            for (int i = 0; i < Equipo1.ListaJugadores.Count; i++)
            {
                Equipo1.ListaJugadores[i].Muestra();
            }
        }
    }
}
