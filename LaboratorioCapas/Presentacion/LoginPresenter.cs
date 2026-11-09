using Negocio;
namespace Presentacion;
/// <summary>Coordina la vista de acceso con el servicio de negocio.</summary>
public sealed class LoginPresenter
{
    private readonly ILoginView vista;
    private readonly N_Usuario negocio;
    public LoginPresenter(ILoginView vista,N_Usuario negocio)
    { this.vista=vista; this.negocio=negocio; vista.IniciarSesion+=Ingresar; }
    private async void Ingresar(object? sender,EventArgs e)
    {
        string nombre=vista.Usuario.Trim(), password=vista.Password;
        if(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrEmpty(password)) {
            vista.MostrarMensaje("Ingrese usuario y contraseña."); return;
        }
        if(nombre.Length>50 || password.Length>128) {
            vista.MostrarMensaje("Usuario: máximo 50 caracteres. Contraseña: máximo 128."); return;
        }
        vista.SetOcupado(true);
        try {
            var usuario=await Task.Run(()=>negocio.Login(nombre,password));
            if(usuario is null) vista.MostrarMensaje("Usuario o contraseña incorrectos, o cuenta inactiva.");
            else vista.AbrirSesion(usuario);
        } catch(Exception ex) {
            System.Diagnostics.Trace.TraceError(ex.ToString());
            vista.MostrarMensaje("No se pudo iniciar sesión. Revise la configuración y la conexión a MySQL.");
        } finally { vista.SetOcupado(false); }
    }
}
