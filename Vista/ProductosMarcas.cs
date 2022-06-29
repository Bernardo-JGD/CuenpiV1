using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuenPiDesk_V1.Controlador;
using CuenPiDesk_V1.Modelo;

//Conversiones
//https://www.convertdatatypes.com/Convert-int-to-string-in-CSharp.html
namespace CuenPiDesk_V1.Vista
{
    public partial class ProductosMarcas : Form
    {
        private bool hayLetras = false;
        private Int16 id;
        public ProductosMarcas()
        {
            InitializeComponent();
        }

        private void rellenarTablaProductos()
        {
            DataTable dt = new DataTable();
            DatosProductos producto = new DatosProductos();
            dt = producto.mostrarProductos();
            dgProductos.DataSource = dt;
            acomodarTablaProductos();
        }

        private void acomodarTablaProductos()
        {
            dgProductos.Columns[0].Width = 75;
            dgProductos.Columns[1].Width = 120;
            dgProductos.Columns[2].Width = 75;
            dgProductos.Columns[3].Width = 120;
            dgProductos.Columns[4].Width = 75;
            dgProductos.Columns[5].Width = 120;
            dgProductos.Columns[6].Width = 85;

            dgProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            if (validarCamposProductos())
            {
                insertarProducto();
                rellenarTablaProductos();
            }
        }

        private bool validarCamposProductos()
        {
            bool comprobar = false;
            if (txtModelo.Text != "" && txtModelo.Text != "Modelo")
            {
                if (txtPrecioO.Text != "" && txtPrecioO.Text != "Precio O" && txtPrecioO.Text != "0")
                {
                    if (numPorcentaje.Value >= 0 && numPorcentaje.Value <= 100)
                    {
                        if (txtPrecioV.Text != "" && txtPrecioV.Text != "Precio V" && txtPrecioV.Text != "1" && txtPrecioV.Text != "0")
                        {
                            if (numCantidad.Value >= 1)
                            {
                                if (listaMarcas.Text != "")
                                {
                                    comprobar = true;
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione una marca", "Marca necesaria");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese otra cantidad", "Cantidad no valida");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Precio de venta no valido", "Error Precio Venta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese otro Porcentaje", "Porcentaje incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el precio original", "Teléfono necesario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese código", "Modelo necesario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return comprobar;
        }

        private void insertarProducto()
        {
            Productos p = new Productos();
            DatosProductos dp = new DatosProductos();
            p.Modelo = txtModelo.Text;
            p.PrecioOriginal = Int16.Parse(txtPrecioO.Text);
            p.NombreMarca = listaMarcas.Text;
            p.Cantidad = (byte)numCantidad.Value;
            p.Detalle = txtDetalle.Text;
            p.FechaCarga = fechaLlegada.Value;
            p.PrecioGanancia = Int16.Parse(txtPrecioV.Text);

            if (dp.insertarProductos(p))
            {
                MessageBox.Show("Producto Registrado", "Registro Correcto");
            }

        }

        private void modificarProductos()
        {

        }

        private void txtPrecioO_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioO.Text != "" && txtPrecioO.Text != "Precio O" && checkManual.Checked == false)
            {
                txtPrecioV.Text = calcularPrecioGanancia().ToString();
                txtPrecioV.ForeColor = Color.Black;
            }
            
        }
        private void numPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            if (txtPrecioO.Text != "" && txtPrecioO.Text != "Precio O")
            {
                txtPrecioV.Text = calcularPrecioGanancia().ToString();
                txtPrecioV.ForeColor = Color.Black;
            }
        }
        private Int16 calcularPrecioGanancia()
        {
            Int16 precioFinal = 1;
            if ((numPorcentaje.Value >=30 && numPorcentaje.Value<=100) && (txtPrecioO.Text != "" && hayLetras) )
            {   //precioOriginal * (1 + (porcentaje * 0.01))
                precioFinal = Convert.ToInt16( ( Convert.ToDouble( Int16.Parse(txtPrecioO.Text) ) * (1 + ( Convert.ToDouble(numPorcentaje.Value)  * 0.01 )) ) );
                return precioFinal;
            }
            else
            {
                return precioFinal;
            }
        }

        private void checkManual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkManual.Checked == true)
            {
                txtPrecioV.Enabled = true;
                txtPrecioV.Text = "";
                numPorcentaje.Value = 0;
                numPorcentaje.Enabled = false;
            }
            else
            {
                txtPrecioV.Enabled = false;
                txtPrecioV.Text = "Precio V";
                txtPrecioV.ForeColor = Color.DimGray;
                numPorcentaje.Value = 30;
                numPorcentaje.Enabled = true;
            }
        }

        private void ProductosMarcas_Load(object sender, EventArgs e)
        {
            rellenarTablaProductos();
            rellenarListaMarcas();
        }

        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            if(txtMarca.Text != "")
            {
                registrarMarca();
            }
        }
        
        private void registrarMarca()
        {
            Marca m = new Marca();
            DatosMarca dm = new DatosMarca();
            m.Nombre = txtMarca.Text;
            if (dm.insertarMarcas(m))
            {
                MessageBox.Show("Marca Registrada", "Registro Correcto");
                rellenarListaMarcas();
            }

        }

        private void rellenarListaMarcas()
        {
            DatosMarca dm = new DatosMarca();
            listaMarcas.DataSource = dm.mostrarMarcas();
            listaMarcas.DisplayMember = "nombre";
        }
        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            limpiarCamposProducto();
        }

        private void limpiarCamposProducto()
        {
            txtModelo.Text = "Modelo";
            txtPrecioO.Text = "Precio O";
            numPorcentaje.Value = 30;
            txtPrecioV.Text = "Precio V";
            numCantidad.Value = 1;
            txtDetalle.Text = "Detalles";
            checkManual.Checked = false;
            fechaLlegada.Value = DateTime.Now;

            txtModelo.ForeColor = Color.DimGray;
            txtPrecioO.ForeColor = Color.DimGray;
            txtPrecioV.ForeColor = Color.DimGray;
            txtDetalle.ForeColor = Color.DimGray;

        }

        private void txtPrecioO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar < 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                txtPrecioO.Text = "";
                hayLetras = false;
            }
            else
            {
                hayLetras = true;
            }
        }

        private void dgProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //vaciar datos en campos
            if (e.RowIndex >= -1)
            {
                id = Convert.ToInt16(dgProductos.Rows[e.RowIndex].Cells[0].Value);
                string po = dgProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                string pv = dgProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtModelo.Text = (string)dgProductos.Rows[e.RowIndex].Cells[1].Value;
                txtPrecioO.Text = po;
                txtPrecioV.Text = pv;
                listaMarcas.Text = dgProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                numCantidad.Value = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells[4].Value);
                fechaLlegada.Value = Convert.ToDateTime(dgProductos.Rows[e.RowIndex].Cells[5].Value);
                Console.WriteLine(porcentajeInverso(pv, po));
                Console.ReadLine();
                numPorcentaje.Value = porcentajeInverso(pv, po);

            }
        }
        
        private Int32 porcentajeInverso(string precioV, string precioO)
        {
            return Convert.ToInt32(((Convert.ToDouble(precioV) / Convert.ToDouble(precioO)) - 1) * 100);
        }

        private void txtModelo_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Modelo", txtModelo);
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Modelo", txtModelo);
        }

        private void txtPrecioO_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Precio O", txtPrecioO);
        }

        private void txtPrecioO_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Precio O", txtPrecioO);
        }

        private void txtPrecioV_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Precio V", txtPrecioV);
        }

        private void txtPrecioV_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Precio V", txtPrecioV);
        }

        private void txtDetalle_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Detalles", txtDetalle);
        }

        private void txtDetalle_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Detalles", txtDetalle);
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Nombre Marca", txtMarca);
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Nombre Marca", txtMarca);
        }
    }
}
