namespace Datos;
/// <summary>Obtiene la conexión desde el entorno, sin credenciales en el código.</summary>
public class D_Conexion
{
    protected static string CadenaConexion =>
        Environment.GetEnvironmentVariable("LAB_CAPAS_CONNECTION")
        ?? throw new InvalidOperationException("Configure LAB_CAPAS_CONNECTION y reinicie Visual Studio.");
}
