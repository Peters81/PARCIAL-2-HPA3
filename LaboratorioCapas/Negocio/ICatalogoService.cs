using Entidades;
namespace Negocio;
/// <summary>Contrato de lectura para desacoplar el presentador del acceso a MySQL.</summary>
public interface ICatalogoService { Catalogos Obtener(); }
