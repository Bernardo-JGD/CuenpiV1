namespace CuenPiDesk_V1.Vista
{
    partial class ProductosMarcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkManual = new System.Windows.Forms.CheckBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnLimpiarP = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.listaMarcas = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.txtPrecioO = new System.Windows.Forms.TextBox();
            this.numPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnLimpiarM = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnRegistrarMarca = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkManual);
            this.panel1.Controls.Add(this.btnEliminarProducto);
            this.panel1.Controls.Add(this.btnLimpiarP);
            this.panel1.Controls.Add(this.btnEditarProducto);
            this.panel1.Controls.Add(this.btnRegistrarProducto);
            this.panel1.Controls.Add(this.fechaLlegada);
            this.panel1.Controls.Add(this.listaMarcas);
            this.panel1.Controls.Add(this.txtDetalle);
            this.panel1.Controls.Add(this.numCantidad);
            this.panel1.Controls.Add(this.txtPrecioV);
            this.panel1.Controls.Add(this.txtPrecioO);
            this.panel1.Controls.Add(this.numPorcentaje);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Location = new System.Drawing.Point(10, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 155);
            this.panel1.TabIndex = 0;
            // 
            // checkManual
            // 
            this.checkManual.AutoSize = true;
            this.checkManual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkManual.Location = new System.Drawing.Point(286, 42);
            this.checkManual.Name = "checkManual";
            this.checkManual.Size = new System.Drawing.Size(98, 29);
            this.checkManual.TabIndex = 12;
            this.checkManual.Text = "Manual";
            this.checkManual.UseVisualStyleBackColor = true;
            this.checkManual.CheckedChanged += new System.EventHandler(this.checkManual_CheckedChanged);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(443, 119);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(115, 33);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarP
            // 
            this.btnLimpiarP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarP.Location = new System.Drawing.Point(443, 81);
            this.btnLimpiarP.Name = "btnLimpiarP";
            this.btnLimpiarP.Size = new System.Drawing.Size(115, 33);
            this.btnLimpiarP.TabIndex = 10;
            this.btnLimpiarP.Text = "Limpiar";
            this.btnLimpiarP.UseVisualStyleBackColor = true;
            this.btnLimpiarP.Click += new System.EventHandler(this.btnLimpiarP_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.Location = new System.Drawing.Point(443, 42);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(115, 33);
            this.btnEditarProducto.TabIndex = 9;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProducto.Location = new System.Drawing.Point(443, 3);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(115, 33);
            this.btnRegistrarProducto.TabIndex = 8;
            this.btnRegistrarProducto.Text = "Registrar";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaLlegada.Location = new System.Drawing.Point(286, 117);
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.Size = new System.Drawing.Size(151, 33);
            this.fechaLlegada.TabIndex = 7;
            // 
            // listaMarcas
            // 
            this.listaMarcas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaMarcas.FormattingEnabled = true;
            this.listaMarcas.Location = new System.Drawing.Point(286, 81);
            this.listaMarcas.Name = "listaMarcas";
            this.listaMarcas.Size = new System.Drawing.Size(151, 33);
            this.listaMarcas.TabIndex = 6;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.Color.DimGray;
            this.txtDetalle.Location = new System.Drawing.Point(3, 42);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(277, 110);
            this.txtDetalle.TabIndex = 5;
            this.txtDetalle.Text = "Detalles";
            this.txtDetalle.Enter += new System.EventHandler(this.txtDetalle_Enter);
            this.txtDetalle.Leave += new System.EventHandler(this.txtDetalle_Leave);
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(392, 3);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(45, 33);
            this.numCantidad.TabIndex = 4;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.Enabled = false;
            this.txtPrecioV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioV.Location = new System.Drawing.Point(286, 3);
            this.txtPrecioV.MaxLength = 5;
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(100, 33);
            this.txtPrecioV.TabIndex = 3;
            this.txtPrecioV.Text = "Precio V";
            this.txtPrecioV.Enter += new System.EventHandler(this.txtPrecioV_Enter);
            this.txtPrecioV.Leave += new System.EventHandler(this.txtPrecioV_Leave);
            // 
            // txtPrecioO
            // 
            this.txtPrecioO.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioO.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioO.Location = new System.Drawing.Point(129, 3);
            this.txtPrecioO.MaxLength = 5;
            this.txtPrecioO.Name = "txtPrecioO";
            this.txtPrecioO.Size = new System.Drawing.Size(100, 33);
            this.txtPrecioO.TabIndex = 2;
            this.txtPrecioO.Text = "Precio O";
            this.txtPrecioO.TextChanged += new System.EventHandler(this.txtPrecioO_TextChanged);
            this.txtPrecioO.Enter += new System.EventHandler(this.txtPrecioO_Enter);
            this.txtPrecioO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioO_KeyPress);
            this.txtPrecioO.Leave += new System.EventHandler(this.txtPrecioO_Leave);
            // 
            // numPorcentaje
            // 
            this.numPorcentaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPorcentaje.Location = new System.Drawing.Point(235, 3);
            this.numPorcentaje.Name = "numPorcentaje";
            this.numPorcentaje.Size = new System.Drawing.Size(45, 33);
            this.numPorcentaje.TabIndex = 1;
            this.numPorcentaje.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPorcentaje.ValueChanged += new System.EventHandler(this.numPorcentaje_ValueChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.DimGray;
            this.txtModelo.Location = new System.Drawing.Point(3, 3);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(120, 33);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.Text = "Modelo";
            this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminarMarca);
            this.panel2.Controls.Add(this.btnLimpiarM);
            this.panel2.Controls.Add(this.btnEditarMarca);
            this.panel2.Controls.Add(this.btnRegistrarMarca);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Location = new System.Drawing.Point(580, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 155);
            this.panel2.TabIndex = 2;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Location = new System.Drawing.Point(127, 81);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(115, 33);
            this.btnEliminarMarca.TabIndex = 13;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarM
            // 
            this.btnLimpiarM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarM.Location = new System.Drawing.Point(3, 81);
            this.btnLimpiarM.Name = "btnLimpiarM";
            this.btnLimpiarM.Size = new System.Drawing.Size(115, 33);
            this.btnLimpiarM.TabIndex = 12;
            this.btnLimpiarM.Text = "Limpiar";
            this.btnLimpiarM.UseVisualStyleBackColor = true;
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMarca.Location = new System.Drawing.Point(127, 43);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(115, 33);
            this.btnEditarMarca.TabIndex = 12;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMarca
            // 
            this.btnRegistrarMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMarca.Location = new System.Drawing.Point(3, 43);
            this.btnRegistrarMarca.Name = "btnRegistrarMarca";
            this.btnRegistrarMarca.Size = new System.Drawing.Size(115, 33);
            this.btnRegistrarMarca.TabIndex = 12;
            this.btnRegistrarMarca.Text = "Registrar";
            this.btnRegistrarMarca.UseVisualStyleBackColor = true;
            this.btnRegistrarMarca.Click += new System.EventHandler(this.btnRegistrarMarca_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.DimGray;
            this.txtMarca.Location = new System.Drawing.Point(3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(239, 33);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Text = "Nombre Marca";
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgProductos.Location = new System.Drawing.Point(13, 68);
            this.dgProductos.Name = "dgProductos";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.ShowCellErrors = false;
            this.dgProductos.Size = new System.Drawing.Size(816, 256);
            this.dgProductos.TabIndex = 3;
            this.dgProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProductos_CellMouseClick);
            // 
            // ProductosMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuenPiDesk_V1.Properties.Resources.FondoCuenpi;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ProductosMarcas";
            this.Text = "ProductosMarcas";
            this.Load += new System.EventHandler(this.ProductosMarcas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown numPorcentaje;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.TextBox txtPrecioO;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.DateTimePicker fechaLlegada;
        private System.Windows.Forms.ComboBox listaMarcas;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnLimpiarP;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnLimpiarM;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnRegistrarMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.CheckBox checkManual;
    }
}