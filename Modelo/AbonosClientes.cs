using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenPiDesk_V1.Modelo
{
    class AbonosClientes
    {
        private int idAbono;
        private int idDeudor;
        private Int16 cantidad;
        private DateTime fechaAbono;

        public int IdAbono
        {
            get { return idAbono; }
            set { idAbono = value; }
        }

        public int IdDeudor
        {
            get { return idDeudor; }
            set { idDeudor = value; }
        }

        public Int16 Cantidad { 
            get { return cantidad; } 
            set { cantidad = value; }
        }

        public DateTime FechaAbono
        {
            get { return fechaAbono; }
            set { fechaAbono = value; }
        }

        public AbonosClientes()
        {

        }

        public AbonosClientes(int idDeudor, Int16 cantidad, DateTime fechaAbono)
        {
            this.idDeudor = idDeudor;
            this.cantidad = cantidad;
            this.fechaAbono = fechaAbono;
        }

    }
}
