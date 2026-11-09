using Entidades;
namespace Presentacion;
public interface ICatalogoView
{
    bool Cerrada { get; }
    Modulo ModuloActual { get; }
    string Busqueda { get; }
    event EventHandler? Actualizar;
    event EventHandler? FiltroCambiado;
    void MostrarResumen(int clientes,int empleados,int productos);
    void MostrarFilas(object filas,int cantidad);
    void MostrarError(string mensaje);
    void SetCargando(bool cargando);
}
