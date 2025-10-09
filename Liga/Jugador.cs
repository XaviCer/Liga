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

        public char Sexo { get; set; }

        public int Edad { get; set; }
        public int Precio { get; set; }

        public Jugador()
        {
        }

        public Jugador(string nombre, string apellido1, string apellido2, char sexo, int edad, int precio)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Sexo = sexo;
            Edad = edad;
            Precio = precio;
        }
        public void Alta()
        {
            // Pantalla para realizar la entrada de datos de un jugador
            Console.Clear();
            Console.WriteLine("### Introduce los datos de un jugador ###");
            Console.WriteLine();

            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Apellido1: ");
            Apellido1 = Console.ReadLine();
            Console.Write("Apellido2: ");
            Apellido2 = Console.ReadLine();

            Console.Write("Edad: ");
            int.TryParse(Console.ReadLine(),out int Edad);

            Console.Write("Sexo (H/M): ");
            Sexo = char.Parse(Console.ReadLine());

            Console.Write("Precio: ");
            Precio = int.Parse(Console.ReadLine());
        }
        public void Muestra()
        {
            //Mostramos en pantalla la ficha del jugador
            Console.WriteLine("### Datos del jugador ###");
            Console.WriteLine();

            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido 1: " + Apellido1);
            Console.WriteLine("Apellido 2: " + Apellido2);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Precio: " + Precio);

            Console.ReadKey();
        }
    }
}
