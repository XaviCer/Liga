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

            equipo1.AñadirJugador(new Jugador("Lamine", "bbbbb", "ccccc", 'h', 30, 1000));
            equipo1.AñadirJugador(new Jugador("Xavi", "bbbbb", "ccccc", 'h', 30, 1000));
            equipo1.AñadirJugador(new Jugador("Jordi", "bbbbb", "ccccc", 'h', 30, 1000));
            equipo1.AñadirJugador(new Jugador("Iban", "bbbbb", "ccccc", 'h', 30, 1000));
            equipo1.AñadirJugador(new Jugador("Julian", "bbbbb", "ccccc", 'h', 30, 1000));

            Console.WriteLine("Club: " + club1.Nombre);
            Console.WriteLine("Equipo: " + equipo1.NombreEquipo);
            for (int i = 0; i < equipo1.ListaJugadores.Count; i++)
            {
                equipo1.ListaJugadores[i].Muestra();
            }
        }
        static Equipo[] CargaInicEquipos()
        {
            Equipo[] eq = new Equipo[20]; 
            
            eq[0] = new Equipo(Equipo.Categoria.masculino1, "Barça");
            eq[1] = new Equipo(Equipo.Categoria.masculino1, "Real Madrid");
            eq[2] = new Equipo(Equipo.Categoria.masculino1, "Espanyol");
            eq[3] = new Equipo(Equipo.Categoria.masculino1, "Atlético Madrid");
            eq[4] = new Equipo(Equipo.Categoria.masculino1, "Betis");
            eq[5] = new Equipo(Equipo.Categoria.masculino1, "Sevilla");
            eq[6] = new Equipo(Equipo.Categoria.masculino1, "Valencia");
            eq[7] = new Equipo(Equipo.Categoria.masculino1, "Villarreal");
            eq[8] = new Equipo(Equipo.Categoria.masculino1, "Real Sociedad");
            eq[9] = new Equipo(Equipo.Categoria.masculino1, "Athletic Club");
            eq[10] = new Equipo(Equipo.Categoria.masculino1, "Celta de Vigo");
            eq[11] = new Equipo(Equipo.Categoria.masculino1, "Osasuna");
            eq[12] = new Equipo(Equipo.Categoria.masculino1, "Rayo Vallecano");
            eq[13] = new Equipo(Equipo.Categoria.masculino1, "Getafe");
            eq[14] = new Equipo(Equipo.Categoria.masculino1, "Granada");
            eq[15] = new Equipo(Equipo.Categoria.masculino1, "Mallorca");
            eq[16] = new Equipo(Equipo.Categoria.masculino1, "Alavés");
            eq[17] = new Equipo(Equipo.Categoria.masculino1, "Las Palmas");
            eq[18] = new Equipo(Equipo.Categoria.masculino1, "Girona");
            eq[19] = new Equipo(Equipo.Categoria.masculino1, "Cádiz");

            return eq;
        }

        static Jugador[] CargaInicJugadores()
        {
            Jugador[] jug = new Jugador[20];
            
            //public Jugador(string nombre, string apellido1, string apellido2, char sexo, int edad, int precio)
            
            jug[0] = new Jugador("Manuel", "López", "Carrasco", 'H', 18, 0);
            jug[1] = new Jugador("Antonio", "De la Cruz", "Vázquez", 'H', 21, 0);
            jug[2] = new Jugador("Carlos", "Martínez", "Gómez", 'H', 20, 0);
            jug[3] = new Jugador("José", "Fernández", "Ruiz", 'H', 23, 0);
            jug[4] = new Jugador("David", "Sánchez", "Morales", 'H', 22, 0);
            jug[5] = new Jugador("Alejandro", "Torres", "Jiménez", 'H', 19, 0);
            jug[6] = new Jugador("Javier", "Romero", "Pérez", 'H', 24, 0);
            jug[7] = new Jugador("Miguel", "Ortega", "Castro", 'H', 20, 0);
            jug[8] = new Jugador("Francisco", "Navarro", "Molina", 'H', 25, 0);
            jug[9] = new Jugador("Adrián", "Domínguez", "Herrera", 'H', 21, 0);
            jug[10] = new Jugador("Pablo", "Vega", "Marín", 'H', 19, 0);
            jug[11] = new Jugador("Raúl", "Ibáñez", "Santos", 'H', 22, 0);
            jug[12] = new Jugador("Rubén", "Núñez", "Delgado", 'H', 23, 0);
            jug[13] = new Jugador("Álvaro", "Gutiérrez", "León", 'H', 20, 0);
            jug[14] = new Jugador("Sergio", "Campos", "Ramírez", 'H', 21, 0);
            jug[15] = new Jugador("Iván", "Gallardo", "Suárez", 'H', 19, 0);
            jug[16] = new Jugador("Mario", "Vargas", "Cortés", 'H', 18, 0);
            jug[17] = new Jugador("Daniel", "Reyes", "Pascual", 'H', 22, 0);
            jug[18] = new Jugador("Óscar", "Lara", "Aguilar", 'H', 23, 0);
            jug[19] = new Jugador("Hugo", "Serrano", "Bravo", 'H', 20, 0);

            return jug;
        }

        static Jugador[] CargaInicJugadoras()
        {
            Jugador[] jug = new Jugador[20];

            // public Jugador(String nombre, String apellido1, String apellido2, char sexo, int edad, int precio)

            jug[0] = new Jugador("Laura", "Martínez", "Ruiz", 'M', 19, 0);
            jug[1] = new Jugador("Marta", "Fernández", "Santos", 'M', 22, 0);
            jug[2] = new Jugador("Sara", "Gómez", "López", 'M', 20, 0);
            jug[3] = new Jugador("Lucía", "Jiménez", "Morales", 'M', 23, 0);
            jug[4] = new Jugador("Paula", "Castro", "Navarro", 'M', 18, 0);
            jug[5] = new Jugador("Carmen", "Delgado", "Torres", 'M', 21, 0);
            jug[6] = new Jugador("Elena", "Vega", "Pascual", 'M', 24, 0);
            jug[7] = new Jugador("Andrea", "Domínguez", "Reyes", 'M', 19, 0);
            jug[8] = new Jugador("Clara", "Gallardo", "Herrera", 'M', 22, 0);
            jug[9] = new Jugador("Alba", "Campos", "Gutiérrez", 'M', 20, 0);
            jug[10] = new Jugador("Patricia", "Suárez", "Núñez", 'M', 25, 0);
            jug[11] = new Jugador("Natalia", "Lara", "Vargas", 'M', 21, 0);
            jug[12] = new Jugador("Irene", "Ortega", "Serrano", 'M', 19, 0);
            jug[13] = new Jugador("Noelia", "Romero", "Cortés", 'M', 23, 0);
            jug[14] = new Jugador("Alicia", "Marín", "León", 'M', 20, 0);
            jug[15] = new Jugador("Cristina", "Ibáñez", "Carrasco", 'M', 22, 0);
            jug[16] = new Jugador("Rocío", "Moreno", "Bravo", 'M', 18, 0);
            jug[17] = new Jugador("Beatriz", "Aguilar", "Sánchez", 'M', 24, 0);
            jug[18] = new Jugador("Julia", "Vázquez", "Molina", 'M', 19, 0);
            jug[19] = new Jugador("Silvia", "De la Cruz", "Ramírez", 'M', 21, 0);

            return jug;
        }


    }
}
