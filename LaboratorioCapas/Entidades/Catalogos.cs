namespace Entidades;
public enum Modulo { Clientes, Empleados, Productos }
/// <summary>Datos ficticios de demostración almacenados en MySQL.</summary>
public sealed record Cliente(int Id, string Nombre, string Documento, string Telefono, string Correo);
public sealed record Empleado(int Id, string Nombre, string Cargo, string Telefono, string Correo);
public sealed record Producto(int Id, string Codigo, string Nombre, string Categoria, decimal Precio, int Stock);
public sealed record Catalogos(IReadOnlyList<Cliente> Clientes, IReadOnlyList<Empleado> Empleados, IReadOnlyList<Producto> Productos);
