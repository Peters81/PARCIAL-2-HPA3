using Entidades;
using MySql.Data.MySqlClient;
namespace Datos;
/// <summary>Recupera credenciales; no recibe ni compara contraseñas en texto plano.</summary>
public class D_Usuario : D_Conexion
{
    public E_Usuario? Buscar(string nombre)
    {
        using var conexion = new MySqlConnection(CadenaConexion);
        conexion.Open();
        using var cmd = new MySqlCommand(
            "SELECT id, dsId, dsUsuario, dsPassword, dsEstado, nombreCompleto, correo, rol FROM usuarios WHERE dsUsuario=@usuario LIMIT 1", conexion);
        cmd.Parameters.AddWithValue("@usuario", nombre);
        using var reader = cmd.ExecuteReader();
        if (!reader.Read()) return null;
        return new E_Usuario {
            id=reader.GetInt32("id"), dsId=reader.GetString("dsId"),
            dsUsuario=reader.GetString("dsUsuario"), PasswordHash=reader.GetString("dsPassword"),
            dsEstado=Convert.ToChar(reader["dsEstado"]),
            NombreCompleto=reader.GetString("nombreCompleto"),
            Correo=reader.GetString("correo"), Rol=reader.GetString("rol")
        };
    }
}
