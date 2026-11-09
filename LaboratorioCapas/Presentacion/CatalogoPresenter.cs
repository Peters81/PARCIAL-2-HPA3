using Entidades;
using Negocio;
namespace Presentacion;
/// <summary>Carga los catálogos fuera del hilo de interfaz y filtra por el módulo seleccionado.</summary>
public sealed class CatalogoPresenter
{
    private readonly ICatalogoView vista;
    private readonly ICatalogoService servicio;
    private Catalogos? datos;
    private bool cargando;
    public CatalogoPresenter(ICatalogoView vista,ICatalogoService servicio)
    { this.vista=vista; this.servicio=servicio; vista.Actualizar+=Cargar; vista.FiltroCambiado+=(_,_)=>Filtrar(); }
    private async void Cargar(object? sender,EventArgs e)
    {
        if(cargando) return;
        cargando=true; vista.SetCargando(true);
        try {
            datos=await Task.Run(servicio.Obtener);
            if(vista.Cerrada) return;
            vista.MostrarResumen(datos.Clientes.Count,datos.Empleados.Count,datos.Productos.Count);
            Filtrar();
        } catch(Exception ex) {
            System.Diagnostics.Trace.TraceError(ex.ToString());
            if(!vista.Cerrada) vista.MostrarError("No se pudieron cargar las listas. Revise MySQL y ejecute los scripts 01 y 02 de esta versión.");
        } finally { cargando=false; if(!vista.Cerrada) vista.SetCargando(false); }
    }
    private void Filtrar()
    {
        if(datos is null) return;
        string q=vista.Busqueda.Trim();
        bool Contiene(string valor)=>valor.Contains(q,StringComparison.OrdinalIgnoreCase);
        switch(vista.ModuloActual) {
            case Modulo.Clientes:
                var c=datos.Clientes.Where(x=>Contiene(x.Nombre)||Contiene(x.Documento)||Contiene(x.Correo)||Contiene(x.Telefono)).ToList();
                vista.MostrarFilas(c,c.Count); break;
            case Modulo.Empleados:
                var e=datos.Empleados.Where(x=>Contiene(x.Nombre)||Contiene(x.Cargo)||Contiene(x.Correo)||Contiene(x.Telefono)).ToList();
                vista.MostrarFilas(e,e.Count); break;
            case Modulo.Productos:
                var productos=datos.Productos.Where(x=>Contiene(x.Nombre)||Contiene(x.Codigo)||Contiene(x.Categoria)).ToList();
                vista.MostrarFilas(productos,productos.Count); break;
        }
    }
}
