using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CuenPiDesk_V1.Vista
{
    public class PlaceHold
    {
        //Método estático para llamarlo sin crear un objeto
        //Pedimos 2 parámetros el string para comparar y el TextBox que se aplica
        //Método cuando pierde el foco el TextBox
        public static void Leave(string pHolder, TextBox pText)
        {
            //Comparamos el Text del TextBox, si está vacio se pondrá el string
            //que recibe y cambia el color para dar la apariencia del placeholder.
            //Si se escribe algo no se hace cambios
            if (pText.Text == string.Empty)
            {
                pText.Text = pHolder;
                pText.ForeColor = Color.DimGray;
            }
        }
        //Método cuando está activo el TextBox
        public static void Enter(string pHolder, TextBox pText)
        {
            //Si tiene el string, lo cambia a vacio y cambia el color a negro
            //para que de apariencia que pierde el placeholder
            if(pText.Text == pHolder)
            {
                pText.Text = string.Empty;
                pText.ForeColor = Color.Black;
            }
        }
    }
}
