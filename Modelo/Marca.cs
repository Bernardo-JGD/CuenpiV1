using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenPiDesk_V1.Modelo
{
    class Marca
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Marca()
        {

        }

        public Marca(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
