using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    internal class Club
    {
        // Atributos
        string nombre;
        int añoFundacion;
        List<Equipo> equipos = new List<Equipo>();

        // Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int AñoFundacion { get { return añoFundacion; } set { añoFundacion = value; } }

        //Constructores
        public Club() { }

        // Métodos
        public void Add(Equipo equipo)
        {
            equipos.Add(equipo);
        }
    }
}
