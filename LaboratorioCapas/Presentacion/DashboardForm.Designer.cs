// Controles y propiedades serializables por el diseñador de Windows Forms.
#nullable disable
namespace Presentacion
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cuerpo = new TableLayoutPanel();
            resumen = new TableLayoutPanel();
            contenido = new TableLayoutPanel();
            listado = new TableLayoutPanel();
            herramientas = new TableLayoutPanel();
            relojPanel = new TableLayoutPanel();
            encabezadoResumen = new Label();
            titulo = new Label();
            cantidad = new Label();
            hora = new Label();
            fecha = new Label();
            tarjetaClientes = new Button();
            tarjetaEmpleados = new Button();
            tarjetaProductos = new Button();
            actualizar = new Button();
            buscar = new TextBox();
            tabla = new DataGridView();
            reloj = new System.Windows.Forms.Timer(components);
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colCargo = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            cuerpo.SuspendLayout();
            resumen.SuspendLayout();
            contenido.SuspendLayout();
            listado.SuspendLayout();
            herramientas.SuspendLayout();
            relojPanel.SuspendLayout();
            SuspendLayout();
            // cuerpo
            cuerpo.Name = "cuerpo";
            cuerpo.Dock = DockStyle.Fill;
            cuerpo.ColumnCount = 1;
            cuerpo.RowCount = 3;
            cuerpo.Size = new Size(1004, 639);
            cuerpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cuerpo.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            cuerpo.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            cuerpo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            // cuerpo
            cuerpo.Padding = new Padding(24);
            // resumen
            resumen.Name = "resumen";
            resumen.Dock = DockStyle.Fill;
            resumen.ColumnCount = 3;
            resumen.RowCount = 1;
            resumen.Size = new Size(956, 106);
            resumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            resumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            resumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            resumen.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            // resumen
            resumen.Padding = new Padding(0, 8, 0, 12);
            // contenido
            contenido.Name = "contenido";
            contenido.Dock = DockStyle.Fill;
            contenido.ColumnCount = 2;
            contenido.RowCount = 1;
            contenido.Size = new Size(956, 431);
            contenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            contenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            contenido.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            // listado
            listado.Name = "listado";
            listado.Dock = DockStyle.Fill;
            listado.ColumnCount = 1;
            listado.RowCount = 4;
            listado.Size = new Size(568, 425);
            listado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            listado.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            listado.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            listado.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            listado.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            // listado
            listado.Padding = new Padding(0, 12, 12, 0);
            // herramientas
            herramientas.Name = "herramientas";
            herramientas.Dock = DockStyle.Fill;
            herramientas.ColumnCount = 2;
            herramientas.RowCount = 1;
            herramientas.Size = new Size(550, 38);
            herramientas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            herramientas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            herramientas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            // relojPanel
            relojPanel.Name = "relojPanel";
            relojPanel.Dock = DockStyle.Fill;
            relojPanel.ColumnCount = 1;
            relojPanel.RowCount = 4;
            relojPanel.Size = new Size(376, 425);
            relojPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            relojPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            relojPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            relojPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            relojPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            // relojPanel
            relojPanel.Padding = new Padding(6, 0, 0, 0);
            // encabezadoResumen
            encabezadoResumen.Name = "encabezadoResumen";
            encabezadoResumen.Text = "Resumen del sistema";
            encabezadoResumen.ForeColor = Color.FromArgb(56, 45, 49);
            encabezadoResumen.Dock = DockStyle.Fill;
            encabezadoResumen.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            // tarjetaClientes
            tarjetaClientes.BackColor = Color.FromArgb(224, 105, 112);
            tarjetaClientes.ForeColor = Color.White;
            tarjetaClientes.FlatStyle = FlatStyle.Flat;
            tarjetaClientes.Font = new Font("Segoe UI", 11F);
            tarjetaClientes.Cursor = Cursors.Hand;
            tarjetaClientes.Text = "Clientes\n— registros";
            tarjetaClientes.UseVisualStyleBackColor = false;
            tarjetaClientes.Name = "tarjetaClientes";
            tarjetaClientes.Height = 46;
            tarjetaClientes.Dock = DockStyle.Fill;
            tarjetaClientes.FlatAppearance.BorderSize = 0;
            tarjetaClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // tarjetaClientes
            tarjetaClientes.Margin = new Padding(0, 0, 0, 0);
            tarjetaClientes.Click += Clientes_Click;
            resumen.Controls.Add(tarjetaClientes, 0, 0);
            // tarjetaEmpleados
            tarjetaEmpleados.BackColor = Color.FromArgb(224, 105, 112);
            tarjetaEmpleados.ForeColor = Color.White;
            tarjetaEmpleados.FlatStyle = FlatStyle.Flat;
            tarjetaEmpleados.Font = new Font("Segoe UI", 11F);
            tarjetaEmpleados.Cursor = Cursors.Hand;
            tarjetaEmpleados.Text = "Empleados\n— registros";
            tarjetaEmpleados.UseVisualStyleBackColor = false;
            tarjetaEmpleados.Name = "tarjetaEmpleados";
            tarjetaEmpleados.Height = 46;
            tarjetaEmpleados.Dock = DockStyle.Fill;
            tarjetaEmpleados.FlatAppearance.BorderSize = 0;
            tarjetaEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // tarjetaEmpleados
            tarjetaEmpleados.Margin = new Padding(8, 0, 0, 0);
            tarjetaEmpleados.Click += Empleados_Click;
            resumen.Controls.Add(tarjetaEmpleados, 1, 0);
            // tarjetaProductos
            tarjetaProductos.BackColor = Color.FromArgb(224, 105, 112);
            tarjetaProductos.ForeColor = Color.White;
            tarjetaProductos.FlatStyle = FlatStyle.Flat;
            tarjetaProductos.Font = new Font("Segoe UI", 11F);
            tarjetaProductos.Cursor = Cursors.Hand;
            tarjetaProductos.Text = "Productos\n— registros";
            tarjetaProductos.UseVisualStyleBackColor = false;
            tarjetaProductos.Name = "tarjetaProductos";
            tarjetaProductos.Height = 46;
            tarjetaProductos.Dock = DockStyle.Fill;
            tarjetaProductos.FlatAppearance.BorderSize = 0;
            tarjetaProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // tarjetaProductos
            tarjetaProductos.Margin = new Padding(8, 0, 0, 0);
            tarjetaProductos.Click += Productos_Click;
            resumen.Controls.Add(tarjetaProductos, 2, 0);
            // titulo
            titulo.Name = "titulo";
            titulo.Text = "Clientes";
            titulo.ForeColor = Color.FromArgb(56, 45, 49);
            titulo.Dock = DockStyle.Fill;
            titulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            // cantidad
            cantidad.Name = "cantidad";
            cantidad.Text = "Registros de la lista";
            cantidad.ForeColor = Color.FromArgb(56, 45, 49);
            cantidad.Dock = DockStyle.Fill;
            cantidad.TextAlign = ContentAlignment.MiddleLeft;
            // hora
            hora.Name = "hora";
            hora.Text = "00:00:00";
            hora.ForeColor = Color.FromArgb(56, 45, 49);
            hora.Dock = DockStyle.Fill;
            hora.TextAlign = ContentAlignment.BottomCenter;
            hora.Font = new Font("Segoe UI Light", 48F);
            // fecha
            fecha.Name = "fecha";
            fecha.Text = "domingo, 8 de noviembre de 2026";
            fecha.ForeColor = Color.FromArgb(56, 45, 49);
            fecha.Dock = DockStyle.Fill;
            fecha.TextAlign = ContentAlignment.TopCenter;
            fecha.Font = new Font("Segoe UI", 12F);
            // fecha
            fecha.ForeColor = Color.FromArgb(178, 61, 70);
            // buscar
            buscar.Name = "buscar";
            buscar.Dock = DockStyle.Fill;
            buscar.PlaceholderText = "Buscar en la lista…";
            buscar.Margin = new Padding(0, 3, 12, 3);
            buscar.TabIndex = 0;
            buscar.TextChanged += Buscar_TextChanged;
            // actualizar
            actualizar.BackColor = Color.FromArgb(224, 105, 112);
            actualizar.ForeColor = Color.White;
            actualizar.FlatStyle = FlatStyle.Flat;
            actualizar.Font = new Font("Segoe UI", 11F);
            actualizar.Cursor = Cursors.Hand;
            actualizar.Text = "Actualizar listas";
            actualizar.UseVisualStyleBackColor = false;
            actualizar.Name = "actualizar";
            actualizar.Height = 46;
            actualizar.Dock = DockStyle.Fill;
            actualizar.FlatAppearance.BorderSize = 0;
            actualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // actualizar
            actualizar.Margin = new Padding(0, 0, 0, 8);
            actualizar.TabIndex = 1;
            actualizar.Click += Actualizar_Click;
            // tabla
            tabla.Name = "tabla";
            tabla.Dock = DockStyle.Fill;
            tabla.ReadOnly = true;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.AutoGenerateColumns = false;
            tabla.RowHeadersVisible = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.BackgroundColor = Color.White;
            tabla.BorderStyle = BorderStyle.None;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.EnableHeadersVisualStyles = false;
            tabla.TabIndex = 2;
            DataGridViewCellStyle estiloCabecera = new DataGridViewCellStyle();
            estiloCabecera.BackColor = Color.FromArgb(178, 61, 70);
            estiloCabecera.ForeColor = Color.White;
            estiloCabecera.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DataGridViewCellStyle estiloCelda = new DataGridViewCellStyle();
            estiloCelda.BackColor = Color.White;
            estiloCelda.ForeColor = Color.FromArgb(56, 45, 49);
            estiloCelda.SelectionBackColor = Color.FromArgb(250, 215, 218);
            estiloCelda.SelectionForeColor = Color.FromArgb(56, 45, 49);
            estiloCelda.Padding = new Padding(5);
            DataGridViewCellStyle estiloAlterno = new DataGridViewCellStyle();
            estiloAlterno.BackColor = Color.FromArgb(253, 243, 244);
            DataGridViewCellStyle estiloPrecio = new DataGridViewCellStyle();
            estiloPrecio.Format = "N2";
            tabla.ColumnHeadersDefaultCellStyle = estiloCabecera;
            tabla.DefaultCellStyle = estiloCelda;
            tabla.AlternatingRowsDefaultCellStyle = estiloAlterno;
            tabla.RowTemplate.Height = 34;
            // colId
            colId.Name = "colId";
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.FillWeight = 40F;
            colId.MinimumWidth = 70;
            colId.ReadOnly = true;
            // colNombre
            colNombre.Name = "colNombre";
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.FillWeight = 160F;
            colNombre.MinimumWidth = 70;
            colNombre.ReadOnly = true;
            // colDocumento
            colDocumento.Name = "colDocumento";
            colDocumento.DataPropertyName = "Documento";
            colDocumento.HeaderText = "Documento";
            colDocumento.FillWeight = 100F;
            colDocumento.MinimumWidth = 70;
            colDocumento.ReadOnly = true;
            // colCargo
            colCargo.Name = "colCargo";
            colCargo.DataPropertyName = "Cargo";
            colCargo.HeaderText = "Cargo";
            colCargo.FillWeight = 100F;
            colCargo.MinimumWidth = 70;
            colCargo.ReadOnly = true;
            // colCargo
            colCargo.Visible = false;
            // colTelefono
            colTelefono.Name = "colTelefono";
            colTelefono.DataPropertyName = "Telefono";
            colTelefono.HeaderText = "Teléfono";
            colTelefono.FillWeight = 100F;
            colTelefono.MinimumWidth = 70;
            colTelefono.ReadOnly = true;
            // colCorreo
            colCorreo.Name = "colCorreo";
            colCorreo.DataPropertyName = "Correo";
            colCorreo.HeaderText = "Correo";
            colCorreo.FillWeight = 150F;
            colCorreo.MinimumWidth = 70;
            colCorreo.ReadOnly = true;
            // colCodigo
            colCodigo.Name = "colCodigo";
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.HeaderText = "Código";
            colCodigo.FillWeight = 100F;
            colCodigo.MinimumWidth = 70;
            colCodigo.ReadOnly = true;
            // colCodigo
            colCodigo.Visible = false;
            // colCategoria
            colCategoria.Name = "colCategoria";
            colCategoria.DataPropertyName = "Categoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.FillWeight = 100F;
            colCategoria.MinimumWidth = 70;
            colCategoria.ReadOnly = true;
            // colCategoria
            colCategoria.Visible = false;
            // colPrecio
            colPrecio.Name = "colPrecio";
            colPrecio.DataPropertyName = "Precio";
            colPrecio.HeaderText = "Precio (B/.)";
            colPrecio.FillWeight = 100F;
            colPrecio.MinimumWidth = 70;
            colPrecio.ReadOnly = true;
            // colPrecio
            colPrecio.Visible = false;
            // colStock
            colStock.Name = "colStock";
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Existencias";
            colStock.FillWeight = 65F;
            colStock.MinimumWidth = 70;
            colStock.ReadOnly = true;
            // colStock
            colStock.Visible = false;
            colPrecio.DefaultCellStyle = estiloPrecio;
            tabla.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colDocumento, colCargo, colTelefono, colCorreo, colCodigo, colCategoria, colPrecio, colStock });
            herramientas.Controls.Add(buscar, 0, 0);
            herramientas.Controls.Add(actualizar, 1, 0);
            listado.Controls.Add(titulo, 0, 0);
            listado.Controls.Add(herramientas, 0, 1);
            listado.Controls.Add(tabla, 0, 2);
            listado.Controls.Add(cantidad, 0, 3);
            relojPanel.Controls.Add(hora, 0, 1);
            relojPanel.Controls.Add(fecha, 0, 2);
            contenido.Controls.Add(listado, 0, 0);
            contenido.Controls.Add(relojPanel, 1, 0);
            cuerpo.Controls.Add(encabezadoResumen, 0, 0);
            cuerpo.Controls.Add(resumen, 0, 1);
            cuerpo.Controls.Add(contenido, 0, 2);
            reloj.Interval = 1000;
            reloj.Tick += Reloj_Tick;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10F);
            BackColor = Color.FromArgb(249, 246, 246);
            ClientSize = new Size(1004, 639);
            Controls.Add(cuerpo);
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            Name = "DashboardForm";
            Text = "Resumen del sistema";
            Shown += DashboardForm_Shown;
            relojPanel.ResumeLayout(false);
            herramientas.ResumeLayout(false);
            listado.ResumeLayout(false);
            contenido.ResumeLayout(false);
            resumen.ResumeLayout(false);
            cuerpo.ResumeLayout(false);
            herramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel cuerpo;
        private TableLayoutPanel resumen;
        private TableLayoutPanel contenido;
        private TableLayoutPanel listado;
        private TableLayoutPanel herramientas;
        private TableLayoutPanel relojPanel;
        private Label encabezadoResumen;
        private Label titulo;
        private Label cantidad;
        private Label hora;
        private Label fecha;
        private Button tarjetaClientes;
        private Button tarjetaEmpleados;
        private Button tarjetaProductos;
        private Button actualizar;
        private TextBox buscar;
        private DataGridView tabla;
        private System.Windows.Forms.Timer reloj;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colCargo;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStock;
    }
}
#nullable restore
