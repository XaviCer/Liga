using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    internal class Jugador
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

        public int Edad { get; set; }
        public double Precio { get; set; }

        public Jugador()
        {
        }

        public Jugador(string nombre, string apellido1, string apellido2, int edad, double precio)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Edad = edad;
            Precio = precio;
        }
        public void Alta()
        {
            Console.Clear();
            Console.WriteLine("### Alta de un jugador ###");
            Console.WriteLine();

            Console.WriteLine("Nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Apellido1: ");
            Apellido1 = Console.ReadLine();
            Console.WriteLine("Apellido2: ");
            Apellido2 = Console.ReadLine();

            //Console.WriteLine("Edad: ");
            //Edad = Console.ReadLine();

            //Console.WriteLine("Sexo (H/M): ");
            //Apellido1 = Console.ReadLine();


        }

    }
}
