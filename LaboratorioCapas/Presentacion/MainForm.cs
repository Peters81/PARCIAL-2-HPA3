using System.ComponentModel;
using Entidades;
namespace Presentacion;

/// <summary>Comportamiento del contenedor MDI. Los controles se editan en MainForm.Designer.cs.</summary>
public partial class MainForm : Form
{
    private E_Usuario? usuario;
    private DashboardForm? tablero;
    private bool expandido = true;
    private int anchoMenu;
    private int altoPerfil;
    private Padding margenPerfil;
    private Padding margenLista;
    private string textoMarca = "";
    private Font? fuenteMarca;
    private (Button Boton, string Texto, int Ancho)[] navegacion = [];

    // El diseñador necesita un constructor sin parámetros que solo cree los controles.
    public MainForm()
    {
        InitializeComponent();
    }

    // La vista de acceso entrega la identidad real al abrir la sesión.
    public MainForm(E_Usuario usuario) : this()
    {
        this.usuario = usuario;
    }

    private void MainForm_Shown(object? sender, EventArgs e)
    {
        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        // Guardamos los tamaños/textos del diseñador para recuperarlos al desplegar el menú.
        anchoMenu = menu.Width;
        altoPerfil = perfil.Height;
        margenPerfil = perfil.Padding;
        margenLista = lista.Padding;
        textoMarca = marca.Text;
        fuenteMarca = marca.Font;
        navegacion = [(btnClientes, btnClientes.Text, btnClientes.Width),
                      (btnEmpleados, btnEmpleados.Text, btnEmpleados.Width),
                      (btnProductos, btnProductos.Text, btnProductos.Width)];
        if (usuario is not null)
        {
            identidad.Text = $"{usuario.NombreCompleto}\n@{usuario.dsUsuario} · {usuario.Rol}\n{usuario.Correo}";
            pie.Text = $"Sesión: {usuario.dsUsuario}  |  {usuario.NombreCompleto}  |  {usuario.Rol}  |  {usuario.Correo}";
            ayudas.SetToolTip(identidad, identidad.Text);
            ayudas.SetToolTip(pie, pie.Text);
        }
        Abrir(Modulo.Clientes);
    }

    private void Plegar_Click(object? sender, EventArgs e)
    {
        expandido = !expandido;
        menu.Width = expandido ? anchoMenu : 68;
        foreach (var (boton, texto, ancho) in navegacion)
        {
            boton.Width = expandido ? ancho : 52;
            boton.Text = expandido ? texto : boton.AccessibleName![..1];
        }
        lista.Padding = expandido ? margenLista : new Padding(4, 10, 4, 0);
        perfil.Padding = expandido ? margenPerfil : new Padding(5);
        perfil.Height = expandido ? altoPerfil : 70;
        identidad.Visible = expandido;
        btnSalir.Text = expandido ? "Cerrar sesión" : "Salir";
        marca.Text = expandido ? textoMarca : "CC";
        // La fuente original se conserva para respetar cambios hechos en el diseñador.
        if (fuenteMarca is not null) marca.Font = fuenteMarca;
    }

    private void Clientes_Click(object? sender, EventArgs e) => Abrir(Modulo.Clientes);
    private void Empleados_Click(object? sender, EventArgs e) => Abrir(Modulo.Empleados);
    private void Productos_Click(object? sender, EventArgs e) => Abrir(Modulo.Productos);
    private void Salir_Click(object? sender, EventArgs e) => Close();

    private void Abrir(Modulo modulo)
    {
        // Reutiliza una única ventana hija MDI en vez de duplicarla al cambiar de módulo.
        if (tablero is null || tablero.IsDisposed)
        {
            tablero = new DashboardForm { MdiParent = this, WindowState = FormWindowState.Maximized };
            tablero.Show();
        }
        tablero.Seleccionar(modulo);
        tablero.Activate();
    }
}
