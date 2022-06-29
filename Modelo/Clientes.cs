using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenPiDesk_V1.Modelo
{
    class Clientes
    {
        private int id;
        private string nombre;
        private string apodo;
        private string direccion;
        private string telefono;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apodo
        {
            get { return apodo; }
            set { apodo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Clientes()
        {

        }

        public Clientes(string nombre, string apodo, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.apodo = apodo;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Clientes(int id, string nombre, string apodo, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apodo = apodo;
            this.direccion = direccion;
            this.telefono = telefono;
        }

    }
}
