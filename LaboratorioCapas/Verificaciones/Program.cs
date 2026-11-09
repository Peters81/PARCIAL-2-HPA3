using Entidades;
using Negocio;
using Presentacion;
using System.Text.RegularExpressions;
int checks=0;
void Exigir(bool ok,string caso) { if(!ok) throw new Exception(caso); checks++; }
IHashService generador=new PasswordService();
IVerificarHashService verificador=new PasswordService();
string hash=generador.GenerarHash("Clave123!");
Exigir(verificador.Verificar("Clave123!",hash),"Clave correcta");
Exigir(!verificador.Verificar("otra",hash),"Clave incorrecta");
Exigir(hash!=generador.GenerarHash("Clave123!"),"Sal aleatoria");
foreach(var malo in new[]{"invalido","PBKDF2-SHA256$1$AA==$AA==","PBKDF2-SHA256$600000$!!$!!","PBKDF2-SHA256$999999999$AA==$AA=="})
 Exigir(!verificador.Verificar("clave",malo),"Hash malformado");
string sql=File.ReadAllText(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory,"../../../../sql/01_instalar.sql")));
foreach(var (nombre,clave) in new[]{("admin","Admin123!"),("luis","Luis123!"),("cristell","Cristell123!"),("carlos","Carlos123!")}) {
 var match=Regex.Match(sql,"'"+nombre+"','([^']+)'");
 Exigir(match.Success && verificador.Verificar(clave,match.Groups[1].Value),"Hash SQL de "+nombre);
}
var datos=new Catalogos(
 new[]{new Cliente(1,"Ana Torres","DEMO-1","000-1","ana@example.com"),new Cliente(2,"José Ríos","DEMO-2","000-2","jose@example.com")},
 new[]{new Empleado(1,"Laura Gómez","Ventas","000-3","laura@example.com")},
 new[]{new Producto(1,"P01","Agua","Bebidas",0.85m,10),new Producto(2,"P02","Jugo","Jugos",1.75m,5)});
var servicio=new FakeService(datos); var vista=new FakeView();
var presenter=new CatalogoPresenter(vista,servicio);
await vista.Recargar();
Exigir(vista.Resumen==(2,1,2),"Resumen de catálogos");
Exigir(vista.Total==2,"Clientes iniciales");
vista.Busqueda="ANA"; vista.Filtrar(); Exigir(vista.Total==1,"Filtro ignora mayúsculas");
vista.Busqueda="DEMO-2"; vista.Filtrar(); Exigir(vista.Total==1,"Filtro documento");
vista.Busqueda="no existe"; vista.Filtrar(); Exigir(vista.Total==0,"Sin resultados");
vista.Busqueda=""; vista.Filtrar(); Exigir(vista.Total==2,"Limpiar búsqueda");
vista.ModuloActual=Modulo.Empleados; vista.Busqueda="Ventas"; vista.Filtrar(); Exigir(vista.Total==1,"Filtro cargo");
vista.ModuloActual=Modulo.Productos; vista.Busqueda="P02"; vista.Filtrar(); Exigir(vista.Total==1,"Filtro código");
vista.Busqueda="bebidas"; vista.Filtrar(); Exigir(vista.Total==1,"Filtro categoría");
vista.Busqueda="  "; vista.Filtrar(); Exigir(vista.Total==2,"Búsqueda vacía con espacios");
servicio.Falla=true; await vista.Recargar(); Exigir(vista.Error!="" && !vista.Cargando,"Error de datos libera estado de carga");
servicio.Falla=false; await vista.Recargar(); Exigir(vista.Total==2 && !vista.Cargando,"Reintento después del error");
Console.WriteLine($"Correctas: {checks} comprobaciones de contratos, hashes, semillas SQL y presentador de catálogos.");
sealed class FakeService(Catalogos datos) : ICatalogoService {
 public bool Falla;
 public Catalogos Obtener()=>Falla ? throw new InvalidOperationException("Fallo simulado") : datos;
}
sealed class FakeView : ICatalogoView {
 private TaskCompletionSource? fin;
 public bool Cerrada=>false;
 public Modulo ModuloActual {get;set;}
 public string Busqueda {get;set;}="";
 public int Total; public (int,int,int) Resumen; public string Error=""; public bool Cargando;
 public event EventHandler? Actualizar;
 public event EventHandler? FiltroCambiado;
 public void MostrarResumen(int c,int e,int p)=>Resumen=(c,e,p);
 public void MostrarFilas(object filas,int cantidad)=>Total=cantidad;
 public void MostrarError(string mensaje)=>Error=mensaje;
 public void SetCargando(bool cargando) { Cargando=cargando; if(!cargando) fin?.TrySetResult(); }
 public async Task Recargar() {
  fin=new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
  Actualizar?.Invoke(this,EventArgs.Empty); await fin.Task.WaitAsync(TimeSpan.FromSeconds(10));
 }
 public void Filtrar()=>FiltroCambiado?.Invoke(this,EventArgs.Empty);
}
