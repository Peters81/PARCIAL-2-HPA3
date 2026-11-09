using Entidades;
using Datos;
namespace Negocio;
/// <summary>Valida credenciales y estado antes de conceder acceso.</summary>
public class N_Usuario
{
    private readonly D_Usuario datos;
    private readonly IVerificarHashService verificador;
    public N_Usuario(D_Usuario datos, IVerificarHashService verificador)
    { this.datos=datos; this.verificador=verificador; }
    public static N_Usuario Crear()=>new(new D_Usuario(),new PasswordService());
    public E_Usuario? Login(string nombre,string password)
    {
        var usuario=datos.Buscar(nombre);
        return usuario is not null && usuario.dsEstado=='1' &&
            verificador.Verificar(password,usuario.PasswordHash) ? usuario : null;
    }
}
