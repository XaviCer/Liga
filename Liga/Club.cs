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
        public List<Equipo> Equipos => equipos;


        //Constructores
        public Club(string nombre, int añoFundacion)
        {
            this.nombre = nombre;
            this.añoFundacion = añoFundacion;
        }

        // Métodos
        /// <summary>
        /// Método que se encarga de añadir un equipo a la lista de equipos
        /// </summary>
        /// <param name="equipo"></param>
        public void Add(Equipo[] equipo)
        {
            for (int i = 0; i < equipo.Length; i++)
                equipos.Add(equipo[i]);
        }
    }
}
