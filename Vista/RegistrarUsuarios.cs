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

namespace CuenPiDesk_V1.Vista
{
    public partial class RegistrarUsuarios : Form
    {
        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        int idUsuario;
        int idAbonoSeleccionado;
        int idCompraSeleccionada;

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (validacionCampos())
            {
                insertaCliente();
                rellenarTablaClientes();
            }

            
        }
        private void insertaCliente()
        {
            Clientes cliente = new Clientes();
            DatosClientes dc = new DatosClientes();
            cliente.Nombre = txtNombre.Text;
            cliente.Apodo = txtApodo.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;

            if (dc.insertarClientes(cliente))
            {
                MessageBox.Show("Cliente registrado", "Registro correcto");
            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validacionCampos())
            {
                modificarClientes();
                rellenarTablaClientes();
            }
        }

        private void modificarClientes()
        {
            Clientes cliente = new Clientes();
            DatosClientes dc = new DatosClientes();
            cliente.ID = idUsuario;
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apodo = txtApodo.Text.Trim();
            cliente.Direccion = txtDireccion.Text.Trim();
            cliente.Telefono = txtTelefono.Text.Trim();

            if (dc.modificarClientes(cliente))
            {
                MessageBox.Show("Datos modificados", "Modificación correcta");
            }

        }
        private bool validacionCampos()
        {
            bool comprobar = false;
            if (txtNombre.Text != "" && txtNombre.Text != "Nombre Cliente"  )
            {
                if (txtTelefono.Text != "" && txtTelefono.Text != "Teléfono"  )
                {
                    comprobar = true;
                }
                else
                {
                    MessageBox.Show("Ingrese un teléfono", "Teléfono necesario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de usuario 1", "Nombre necesario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return comprobar;
        }

        private void rellenarTablaClientes()
        {
            DataTable dt;
            DatosClientes cliente = new DatosClientes();
            dt = cliente.mostrarClientes();
            dgClientes.DataSource = dt;
            acomodarTabla();
        }

        private void rellenarTablaAbonos()
        {
            DataTable dt;
            DatosClientesAbonos dca = new DatosClientesAbonos();
            dt = dca.mostrarAbonos(idUsuario);
            dgAbonos.DataSource = dt;
        }

        private void rellenarTablaCompras()
        {
            DataTable dt;
            DatosClientesCompras dcc = new DatosClientesCompras();
            dt = dcc.mostrarCompras(idUsuario);
            dgCompras.DataSource = dt;
        }

        private void RegistrarUsuarios_Load(object sender, EventArgs e)
        {
            rellenarTablaClientes();
        }

        private void acomodarTabla()
        {
            dgClientes.Columns[0].Width = 75;
            dgClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dgClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgClientes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

        }

        private void dgClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >-1)
            {
                idUsuario = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells[0].Value) ;
                txtNombre.Text = (string)dgClientes.Rows[e.RowIndex].Cells[1].Value;
                txtApodo.Text = (string)dgClientes.Rows[e.RowIndex].Cells[2].Value;
                txtDireccion.Text = (string)dgClientes.Rows[e.RowIndex].Cells[3].Value;
                txtTelefono.Text = (string)dgClientes.Rows[e.RowIndex].Cells[4].Value;
                txtNombre.ForeColor = Color.Black;
                txtApodo.ForeColor = Color.Black;
                txtDireccion.ForeColor = Color.Black;
                txtTelefono.ForeColor = Color.Black;
                rellenarTablaAbonos();
                rellenarTablaCompras();
                DatosClientesAbonos dca = new DatosClientesAbonos();
                DatosClientesCompras dcc = new DatosClientesCompras();
                totalAbonos.Text = Convert.ToString(dca.consultarTotalAbonos(idUsuario));
                totalCompras.Text = Convert.ToString(dcc.consultarTotalCompras(idUsuario));

                if (Convert.ToInt32(totalAbonos.Text) == 0 && Convert.ToInt32(totalCompras.Text) == 0)
                {
                    totalResta.Text = "0";
                }
                else
                {
                    totalResta.Text = Convert.ToString(Convert.ToInt32(totalCompras.Text) - Convert.ToInt32(totalAbonos.Text));
                }

            }
        }
        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            limpiarCamposClientes();
        }
        private void limpiarCamposClientes()
        {
            txtNombre.Text = "Nombre Cliente";
            txtDireccion.Text = "Dirección";
            txtApodo.Text = "Alias";
            txtTelefono.Text = "Teléfono";

            txtNombre.ForeColor = Color.DimGray;
            txtDireccion.ForeColor = Color.DimGray;
            txtApodo.ForeColor = Color.DimGray;
            txtTelefono.ForeColor = Color.DimGray;
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            registrarAbonos();
            rellenarTablaAbonos();
        }

        private void registrarAbonos()
        {
            AbonosClientes ac = new AbonosClientes();
            DatosClientesAbonos dca = new DatosClientesAbonos();
            ac.IdDeudor = idUsuario;
            ac.Cantidad = Int16.Parse(txtMontoAbono.Text);
            ac.FechaAbono = selecFechaAbono.Value;

            if (dca.insertarAbonos(ac))
            {
                MessageBox.Show("Abono registrado", "Registro correcto");
            }


        }

        private void dgAbonos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idAbonoSeleccionado = Convert.ToInt32(dgAbonos.Rows[e.RowIndex].Cells[0].Value);
                idAbono.Text = Convert.ToString(dgAbonos.Rows[e.RowIndex].Cells[0].Value);
                selecFechaAbono.Value = Convert.ToDateTime(dgAbonos.Rows[e.RowIndex].Cells[1].Value);
                txtMontoAbono.Text = Convert.ToString(dgAbonos.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void btnEditarAbono_Click(object sender, EventArgs e)
        {
            modificarAbonos();
            rellenarTablaAbonos();
        }

        private void modificarAbonos()
        {
            AbonosClientes ac = new AbonosClientes();
            DatosClientesAbonos dca = new DatosClientesAbonos();
            ac.IdAbono = idAbonoSeleccionado;
            ac.Cantidad = Int16.Parse(txtMontoAbono.Text);
            ac.FechaAbono = selecFechaAbono.Value;

            if (dca.modificarAbonos(ac))
            {
                MessageBox.Show("Abono modificado", "Modificación correcta");
            }

        }


        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            consultarProducto();
        }

        private void consultarProducto()
        {
            Productos pro = new Productos();
            DatosProductos dp = new DatosProductos();
            pro = dp.mostrarUnProducto(txtModelo.Text);
            txtCantidad.Text = Convert.ToString(pro.Cantidad);
            txtPrecioV.Text = Convert.ToString(pro.PrecioGanancia);
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtPrecioV.Text != "")
            {
                lbTotal.Text = Convert.ToString(calcularPrecioCompra());
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            registrarCompra();
            rellenarTablaCompras();
        }

        private void dgCompras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Compra datosCompra = new Compra();
            DatosClientesCompras dcc = new DatosClientesCompras();
            if (e.RowIndex > -1)
            {//id, fecha, total
                idCompraSeleccionada = Convert.ToInt32(dgCompras.Rows[e.RowIndex].Cells[0].Value);
                datosCompra = dcc.consultarUnaCompra(idCompraSeleccionada);
                txtModelo.Text = datosCompra.Modelo;
                txtCantidad.Text = Convert.ToString(datosCompra.Cantidad);
                txtPrecioV.Text = Convert.ToString(datosCompra.TotalCompra);
                cantidadCompra.Value = Convert.ToInt32(datosCompra.CantidadUnaCompra);
                txtDetalleCompra.Text = datosCompra.Detalle;
                selecFechaCompra.Value = Convert.ToDateTime(dgCompras.Rows[e.RowIndex].Cells[1].Value);
                lbTotal.Text = Convert.ToString(dgCompras.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            editarCompra();
            rellenarTablaCompras();
        }

        private void registrarCompra()
        {
            Compra compra = new Compra();
            DatosClientesCompras dcc = new DatosClientesCompras();
            compra.Modelo = txtModelo.Text;
            compra.IdDeudor = idUsuario;
            compra.Cantidad = (byte)cantidadCompra.Value;
            compra.Detalle = txtDetalleCompra.Text;
            compra.TotalCompra = Convert.ToInt16(lbTotal.Text);
            compra.FechaCompra = selecFechaCompra.Value;

            if (dcc.insertarCompra(compra))
            {
                MessageBox.Show("Compra realizada con éxito", "Producto comprado");
            }
        }

        private void editarCompra()
        {
            Compra editCompra = new Compra();
            DatosClientesCompras dcc = new DatosClientesCompras();
            editCompra.IdCompra = idCompraSeleccionada;
            editCompra.Modelo = txtModelo.Text;
            editCompra.Cantidad = Convert.ToByte(cantidadCompra.Value);
            editCompra.TotalCompra = Convert.ToInt16(lbTotal.Text);
            editCompra.Detalle = txtDetalleCompra.Text;
            editCompra.FechaCompra = Convert.ToDateTime(selecFechaCompra.Value);

            if (dcc.modificarCompras(editCompra))
            {
                MessageBox.Show("Compra modificado", "Modificación correcta");
            }
        }

        private Int16 calcularPrecioCompra()
        {
            Int16 precioFinal = 1;
            if (cantidadCompra.Value>=1 && cantidadCompra.Value<= Convert.ToInt16(txtCantidad.Text))
            {
                precioFinal = Convert.ToInt16(cantidadCompra.Value * Convert.ToInt16(txtPrecioV.Text)) ;
                return precioFinal;
            }
            else
            {
                return precioFinal;
            }
        }



        //Evento cuando el Text está activo
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            //Llamamos la clase con su método estatico y pasamos los parámetros
            PlaceHold.Enter("Nombre Cliente", txtNombre);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Nombre Cliente", txtNombre);
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Dirección", txtDireccion);
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Dirección", txtDireccion);
        }

        private void txtApodo_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Alias", txtApodo);
        }

        private void txtApodo_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Alias", txtApodo);
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Teléfono", txtTelefono);
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Teléfono", txtTelefono);
        }

        private void btnIProductos_Click(object sender, EventArgs e)
        {
            ProductosMarcas abrir = new ProductosMarcas();
            abrir.Show();
        }
    }
}
