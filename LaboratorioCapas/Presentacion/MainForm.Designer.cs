// Controles y propiedades serializables por el diseñador de Windows Forms.
#nullable disable
namespace Presentacion
{
    partial class MainForm
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
            menu = new Panel();
            perfil = new Panel();
            encabezado = new Panel();
            lista = new FlowLayoutPanel();
            plegar = new Button();
            btnClientes = new Button();
            btnEmpleados = new Button();
            btnProductos = new Button();
            btnSalir = new Button();
            tituloAplicacion = new Label();
            pie = new Label();
            marca = new Label();
            identidad = new Label();
            ayudas = new ToolTip(components);
            menu.SuspendLayout();
            perfil.SuspendLayout();
            encabezado.SuspendLayout();
            lista.SuspendLayout();
            SuspendLayout();
            // menu
            menu.Name = "menu";
            menu.Dock = DockStyle.Left;
            menu.Width = 240;
            menu.BackColor = Color.FromArgb(224, 105, 112);
            // perfil
            perfil.Name = "perfil";
            perfil.Dock = DockStyle.Bottom;
            perfil.Height = 154;
            perfil.Padding = new Padding(16);
            perfil.BackColor = Color.FromArgb(178, 61, 70);
            // encabezado
            encabezado.Name = "encabezado";
            encabezado.Dock = DockStyle.Top;
            encabezado.Height = 64;
            encabezado.BackColor = Color.White;
            // lista
            lista.Name = "lista";
            lista.Dock = DockStyle.Fill;
            lista.FlowDirection = FlowDirection.TopDown;
            lista.WrapContents = false;
            lista.Padding = new Padding(8, 10, 8, 0);
            lista.AutoScroll = true;
            // plegar
            plegar.BackColor = Color.FromArgb(224, 105, 112);
            plegar.ForeColor = Color.White;
            plegar.FlatStyle = FlatStyle.Flat;
            plegar.Font = new Font("Segoe UI", 11F);
            plegar.Cursor = Cursors.Hand;
            plegar.Text = "☰";
            plegar.UseVisualStyleBackColor = false;
            plegar.Name = "plegar";
            plegar.Height = 64;
            plegar.Dock = DockStyle.Left;
            plegar.Width = 64;
            plegar.FlatAppearance.BorderSize = 0;
            plegar.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // plegar
            plegar.AccessibleName = "Abrir o cerrar menú lateral";
            plegar.TabIndex = 0;
            plegar.Click += Plegar_Click;
            // btnClientes
            btnClientes.BackColor = Color.FromArgb(224, 105, 112);
            btnClientes.ForeColor = Color.White;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 11F);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Text = "C   Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Name = "btnClientes";
            btnClientes.Height = 52;
            btnClientes.Width = 218;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // btnClientes
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.Padding = new Padding(14, 0, 0, 0);
            btnClientes.AccessibleName = "Clientes";
            btnClientes.TabIndex = 0;
            btnClientes.Click += Clientes_Click;
            lista.Controls.Add(btnClientes);
            ayudas.SetToolTip(btnClientes, "Clientes");
            // btnEmpleados
            btnEmpleados.BackColor = Color.FromArgb(224, 105, 112);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 11F);
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.Text = "E   Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Height = 52;
            btnEmpleados.Width = 218;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // btnEmpleados
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Padding = new Padding(14, 0, 0, 0);
            btnEmpleados.AccessibleName = "Empleados";
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Click += Empleados_Click;
            lista.Controls.Add(btnEmpleados);
            ayudas.SetToolTip(btnEmpleados, "Empleados");
            // btnProductos
            btnProductos.BackColor = Color.FromArgb(224, 105, 112);
            btnProductos.ForeColor = Color.White;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 11F);
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Text = "P   Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Name = "btnProductos";
            btnProductos.Height = 52;
            btnProductos.Width = 218;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // btnProductos
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.Padding = new Padding(14, 0, 0, 0);
            btnProductos.AccessibleName = "Productos";
            btnProductos.TabIndex = 2;
            btnProductos.Click += Productos_Click;
            lista.Controls.Add(btnProductos);
            ayudas.SetToolTip(btnProductos, "Productos");
            // btnSalir
            btnSalir.BackColor = Color.FromArgb(224, 105, 112);
            btnSalir.ForeColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Text = "Cerrar sesión";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Name = "btnSalir";
            btnSalir.Height = 38;
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 61, 70);
            // btnSalir
            btnSalir.BackColor = Color.FromArgb(178, 61, 70);
            btnSalir.AccessibleName = "Cerrar sesión";
            btnSalir.Click += Salir_Click;
            // tituloAplicacion
            tituloAplicacion.Name = "tituloAplicacion";
            tituloAplicacion.Text = "SISTEMA COMERCIAL";
            tituloAplicacion.ForeColor = Color.FromArgb(56, 45, 49);
            tituloAplicacion.Dock = DockStyle.Fill;
            tituloAplicacion.TextAlign = ContentAlignment.MiddleLeft;
            tituloAplicacion.Padding = new Padding(20, 0, 0, 0);
            tituloAplicacion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            // pie
            pie.Name = "pie";
            pie.Text = "Sesión: usuario  |  Nombre completo  |  Rol  |  correo@example.com";
            pie.ForeColor = Color.FromArgb(56, 45, 49);
            pie.Dock = DockStyle.Bottom;
            pie.Height = 38;
            pie.Padding = new Padding(16, 0, 12, 0);
            pie.BackColor = Color.White;
            pie.TextAlign = ContentAlignment.MiddleLeft;
            pie.AutoEllipsis = true;
            // marca
            marca.Name = "marca";
            marca.Text = "COCA-COLA\nPanel de consultas";
            marca.ForeColor = Color.FromArgb(56, 45, 49);
            marca.Dock = DockStyle.Top;
            marca.Height = 105;
            marca.Padding = new Padding(16, 20, 0, 0);
            marca.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            // marca
            marca.ForeColor = Color.White;
            // identidad
            identidad.Name = "identidad";
            identidad.Text = "Nombre del usuario\n@usuario · Rol\ncorreo@example.com";
            identidad.ForeColor = Color.FromArgb(56, 45, 49);
            identidad.Dock = DockStyle.Fill;
            identidad.AutoEllipsis = true;
            identidad.Font = new Font("Segoe UI", 10F);
            // identidad
            identidad.ForeColor = Color.White;
            ayudas.SetToolTip(plegar, "Abrir / cerrar menú");
            ayudas.SetToolTip(btnSalir, "Cerrar sesión");
            encabezado.Controls.Add(tituloAplicacion);
            encabezado.Controls.Add(plegar);
            perfil.Controls.Add(identidad);
            perfil.Controls.Add(btnSalir);
            menu.Controls.Add(lista);
            menu.Controls.Add(perfil);
            menu.Controls.Add(marca);
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(1244, 741);
            MinimumSize = new Size(1050, 680);
            IsMdiContainer = true;
            Controls.Add(menu);
            Controls.Add(pie);
            Controls.Add(encabezado);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema comercial | Inicio";
            Shown += MainForm_Shown;
            lista.ResumeLayout(false);
            encabezado.ResumeLayout(false);
            perfil.ResumeLayout(false);
            menu.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel menu;
        private Panel perfil;
        private Panel encabezado;
        private FlowLayoutPanel lista;
        private Button plegar;
        private Button btnClientes;
        private Button btnEmpleados;
        private Button btnProductos;
        private Button btnSalir;
        private Label tituloAplicacion;
        private Label pie;
        private Label marca;
        private Label identidad;
        private ToolTip ayudas;
    }
}
#nullable restore
