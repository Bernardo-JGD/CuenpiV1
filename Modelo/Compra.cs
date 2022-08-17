using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenPiDesk_V1.Modelo
{
    class Compra
    {

        private int idCompra;
        private int idProducto;
        //En vez del id pongo el modelo para registrar
        private string modelo;
        private int idDeudor;
        private byte cantidad;
        private string detalle;
        private Int16 totalCompra;
        private DateTime fechaCompra;
        //Este es para consultar la cantidad de producto de una compra
        private byte cantidadUnaCompra; 

        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int IdDeudor
        {
            get { return idDeudor; }
            set { idDeudor = value; }
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

        public Int16 TotalCompra
        {
            get { return totalCompra; }
            set { totalCompra = value; }
        }

        public DateTime FechaCompra
        {
            get { return fechaCompra; }
            set { fechaCompra = value;}
        }

        public byte CantidadUnaCompra
        {
            get { return cantidadUnaCompra; }
            set { cantidadUnaCompra = value; }
        }
        public Compra()
        {

        }

        public Compra(int idCompra, string modelo, byte cantidad, string detalle, Int16 totalCompra, DateTime fechaCompra)
        {
            this.idCompra = idCompra;
            this.modelo = modelo;
            this.cantidad = cantidad;
            this.detalle = detalle;
            this.totalCompra = totalCompra;
            this.fechaCompra = fechaCompra;
        }

        public Compra(string modelo, byte cantidad, string detalle, Int16 precioGanancia, byte cantidadUnaCompra )
        {
            this.modelo = modelo;
            this.cantidad = cantidad;
            this.detalle = detalle;
            this.totalCompra = precioGanancia;
            this.cantidadUnaCompra = cantidadUnaCompra;
        }

        public Compra(string modelo, int idDeudor, byte cantidad, string detalle, Int16 totalCompra, DateTime fechaCompra)
        {
            this.modelo = modelo;
            this.idDeudor = idDeudor;
            this.cantidad = cantidad;
            this.detalle = detalle;
            this.totalCompra = totalCompra;
            this.fechaCompra = fechaCompra;
        }

        static public Int16 calcularPrecioCompra(Int16 cantidadCompra, Int16 txtCantidad, Int16 txtPrecioV)
        {
            Int16 precioFinal = 1;
            if (cantidadCompra >= 1 && cantidadCompra <= txtCantidad)
            {
                precioFinal = Convert.ToInt16(cantidadCompra * txtPrecioV);
                return precioFinal;
            }
            else
            {
                return precioFinal;
            }
        }

        public static bool validarFechasFiltro(DateTime fecha1, DateTime Fecha2)
        {
            int resultado = DateTime.Compare(fecha1.Date, Fecha2.Date);
            if (resultado < 0)
            {
                //lbResultado.Text = "Fecha 1 es menor que fecha 2";
                return true;
            }
            else
            {

                if (resultado == 0)
                {
                    //lbResultado.Text = "Ambas fechas son iguales";
                    return true;
                }
                else
                {
                    //lbResultado.Text = "La fecha 1 es mayor que la fecha 2";
                    return false;
                }

            }
        }

    }
}
