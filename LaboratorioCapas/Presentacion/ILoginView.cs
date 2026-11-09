using Entidades;
namespace Presentacion;
public interface ILoginView
{
    string Usuario { get; }
    string Password { get; }
    event EventHandler? IniciarSesion;
    void MostrarMensaje(string mensaje);
    void AbrirSesion(E_Usuario usuario);
    void SetOcupado(bool ocupado);
}
