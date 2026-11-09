using System.ComponentModel;
using System.Globalization;
using Entidades;
using Negocio;
namespace Presentacion;

/// <summary>Vista del resumen. Su distribución visual está en DashboardForm.Designer.cs.</summary>
public partial class DashboardForm : Form, ICatalogoView
{
    private CatalogoPresenter? presenter;
    private bool iniciado;
    public bool Cerrada => IsDisposed || Disposing;
    public Modulo ModuloActual { get; private set; }
    public string Busqueda => buscar.Text;
    public event EventHandler? Actualizar;
    public event EventHandler? FiltroCambiado;

    // No se consulta MySQL ni se inicia el reloj al abrir el diseñador de Visual Studio.
    public DashboardForm()
    {
        InitializeComponent();
    }

    private void DashboardForm_Shown(object? sender, EventArgs e)
    {
        if (iniciado || DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        iniciado = true;
        presenter = new CatalogoPresenter(this, new CatalogoService());
        Seleccionar(ModuloActual);
        ActualizarHora();
        reloj.Start();
        Actualizar?.Invoke(this, EventArgs.Empty);
    }

    private void Buscar_TextChanged(object? sender, EventArgs e) => FiltroCambiado?.Invoke(this, EventArgs.Empty);
    private void Actualizar_Click(object? sender, EventArgs e) => Actualizar?.Invoke(this, EventArgs.Empty);
    private void Clientes_Click(object? sender, EventArgs e) => Seleccionar(Modulo.Clientes);
    private void Empleados_Click(object? sender, EventArgs e) => Seleccionar(Modulo.Empleados);
    private void Productos_Click(object? sender, EventArgs e) => Seleccionar(Modulo.Productos);
    private void Reloj_Tick(object? sender, EventArgs e) => ActualizarHora();

    private void ActualizarHora()
    {
        hora.Text = DateTime.Now.ToString("HH:mm:ss");
        fecha.Text = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy", CultureInfo.GetCultureInfo("es-PA"));
    }

    public void Seleccionar(Modulo modulo)
    {
        bool cambia = ModuloActual != modulo;
        ModuloActual = modulo;
        titulo.Text = modulo.ToString();
        tabla.DataSource = null;
        // Todas las columnas existen en el diseñador. Solo cambia cuáles se muestran.
        colDocumento.Visible = modulo == Modulo.Clientes;
        colCargo.Visible = modulo == Modulo.Empleados;
        colTelefono.Visible = modulo != Modulo.Productos;
        colCorreo.Visible = modulo != Modulo.Productos;
        colCodigo.Visible = modulo == Modulo.Productos;
        colCategoria.Visible = modulo == Modulo.Productos;
        colPrecio.Visible = modulo == Modulo.Productos;
        colStock.Visible = modulo == Modulo.Productos;
        if (cambia) buscar.Clear();
        FiltroCambiado?.Invoke(this, EventArgs.Empty);
    }

    public void MostrarResumen(int clientes, int empleados, int productos)
    {
        tarjetaClientes.Text = $"Clientes\n{clientes} registros";
        tarjetaEmpleados.Text = $"Empleados\n{empleados} registros";
        tarjetaProductos.Text = $"Productos\n{productos} registros";
    }

    public void MostrarFilas(object filas, int total)
    {
        tabla.DataSource = filas;
        cantidad.Text = $"{total} registros encontrados";
    }

    public void MostrarError(string mensaje)
    {
        cantidad.Text = "No se pudieron actualizar los datos.";
        MessageBox.Show(this, mensaje, "Listas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public void SetCargando(bool valor)
    {
        actualizar.Enabled = !valor;
        if (valor) cantidad.Text = "Cargando desde MySQL…";
    }
}
