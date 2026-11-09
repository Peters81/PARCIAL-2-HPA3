using Datos;
using Entidades;
namespace Negocio;
/// <summary>Servicio de consulta de clientes, empleados y productos.</summary>
public sealed class CatalogoService : ICatalogoService
{
    private readonly D_Catalogos datos=new();
    public Catalogos Obtener()=>datos.Obtener();
}
