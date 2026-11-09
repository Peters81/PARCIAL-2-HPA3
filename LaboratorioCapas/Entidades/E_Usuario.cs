namespace Entidades;
/// <summary>Datos de identidad y credenciales persistidas del usuario.</summary>
public class E_Usuario
{
    public int id { get; set; }
    public string dsId { get; set; } = "";
    public string dsUsuario { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string NombreCompleto { get; set; } = "";
    public string Correo { get; set; } = "";
    public string Rol { get; set; } = "";
    public char dsEstado { get; set; }
}
