using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenPiDesk_V1.Modelo
{
    //https://docs.microsoft.com/es-es/dotnet/framework/data/adonet/sql-server-data-type-mappings

    class Productos
    {
        private string modelo;
        private Int16 precioOriginal;
        private string nombreMarca;
        private byte cantidad;
        private string detalle;
        private DateTime fechaCarga;
        private Int16 precioGanancia;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Int16 PrecioOriginal
        {
            get { return precioOriginal; }
            set { precioOriginal = value; }
        }

        public string NombreMarca
        {
            get { return nombreMarca; }
            set { nombreMarca = value; }
        }

        public byte Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public DateTime FechaCarga
        {
            get { return fechaCarga; }
            set { fechaCarga = value; }
        }

        public Int16 PrecioGanancia
        {
            get { return precioGanancia; }
            set { precioGanancia = value; }
        }

        public Productos()
        {

        }

        public Productos(string modelo, Int16 precioOriginal, string nombreMarca, byte cantidad, string detalle, DateTime fechaCarga, Int16 precioGanancia)
        {
            this.modelo = modelo;
            this.precioOriginal = precioOriginal;
            this.nombreMarca = nombreMarca;
            this.cantidad = cantidad;
            this.detalle = detalle;
            this.fechaCarga = fechaCarga;
            this.precioGanancia = precioGanancia;
        }

        public Productos(Int16 precioGanancia, byte cantidad)
        {
            this.precioGanancia = precioGanancia;
            this.cantidad = cantidad; 
        }
    }
}
