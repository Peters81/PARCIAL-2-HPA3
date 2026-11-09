using Entidades;
using MySql.Data.MySqlClient;
namespace Datos;
/// <summary>Lectura de los tres catálogos; la aplicación no necesita permisos de escritura.</summary>
public sealed class D_Catalogos : D_Conexion
{
    public Catalogos Obtener()
    {
        using var conexion=new MySqlConnection(CadenaConexion); conexion.Open();
        var clientes=new List<Cliente>();
        using(var cmd=new MySqlCommand("SELECT id,nombre,documento,telefono,correo FROM clientes ORDER BY nombre",conexion))
        using(var r=cmd.ExecuteReader())
            while(r.Read()) clientes.Add(new(r.GetInt32(0),r.GetString(1),r.GetString(2),r.GetString(3),r.GetString(4)));
        var empleados=new List<Empleado>();
        using(var cmd=new MySqlCommand("SELECT id,nombre,cargo,telefono,correo FROM empleados ORDER BY nombre",conexion))
        using(var r=cmd.ExecuteReader())
            while(r.Read()) empleados.Add(new(r.GetInt32(0),r.GetString(1),r.GetString(2),r.GetString(3),r.GetString(4)));
        var productos=new List<Producto>();
        using(var cmd=new MySqlCommand("SELECT id,codigo,nombre,categoria,precio,stock FROM productos ORDER BY nombre",conexion))
        using(var r=cmd.ExecuteReader())
            while(r.Read()) productos.Add(new(r.GetInt32(0),r.GetString(1),r.GetString(2),r.GetString(3),r.GetDecimal(4),r.GetInt32(5)));
        return new(clientes,empleados,productos);
    }
}
