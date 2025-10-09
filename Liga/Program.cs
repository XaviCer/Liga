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
            //Creamos un jugador de prueba

            Jugador j1 = new Jugador();
            j1.Alta();

            Console.WriteLine();
            Console.WriteLine("Datos del Jugador creado");

            j1.Muestra();

            Console.ReadKey();

        }
    }
}
