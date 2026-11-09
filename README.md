# Sistema comercial · MVP y capas

Laboratorio de Herramientas de la Programación Aplicada III (.NET), UTP, grupo 1IL133.

- Autor(es): **PENDIENTE: completar nombres y cédulas.**
- Fecha: 8 de noviembre de 2026.
- Tema: consulta de clientes, empleados y productos con acceso autenticado.
- Las personas, contactos y perfiles incluidos son datos ficticios de demostración.

## Instalación paso a paso

Consultar **[LEEME_PRIMERO.md](LEEME_PRIMERO.md)**. Ejecutar los dos scripts actuales incluso si ya tenías la primera versión. La actualización es aditiva y conserva hashes, contraseñas y registros existentes. La variable `LAB_CAPAS_CONNECTION` previamente configurada se mantiene.

```powershell
dotnet restore LaboratorioCapas.slnx
dotnet build LaboratorioCapas.slnx
dotnet run --project Presentacion
```

Usuario de demostración: `admin` / `Admin123!`. Otras cuentas: `luis` / `Luis123!`, `cristell` / `Cristell123!`; `carlos` / `Carlos123!` está inactiva para probar rechazo de acceso. La cuenta MySQL `lab_capas_app` utiliza `peters` en esta práctica local; no confundir con la contraseña de acceso a la aplicación.

## Diseño y funciones

- Menú rojo claro con botón ☰ en la esquina superior izquierda para plegarlo/desplegarlo.
- Navegación Clientes, Empleados y Productos; tarjetas de resumen con cantidades obtenidas de MySQL.
- Tabla de consulta con búsqueda por nombre y otros campos según el módulo; botón para actualizar datos.
- Reloj grande en la mitad derecha del contenido, con fecha debajo, siguiendo la referencia recibida.
- Perfil al final del menú: nombre, usuario, rol y correo. La barra inferior conserva esos datos incluso con el menú plegado.
- Cerrar sesión limpia la contraseña y permite entrar con otra cuenta.
- Listas de lectura. Para editar/agregar registros de la práctica, usar Workbench como administrador y pulsar Actualizar listas.

## Arquitectura MVP

| Capa | Responsabilidad |
|---|---|
| Entidades | Identidad de usuario y registros Cliente, Empleado, Producto y Catalogos |
| Datos | Conexión por entorno, consulta parametrizada de usuario y lectura de catálogos |
| Negocio | Autenticación, contratos de hash y servicio de catálogos |
| Presentación | Vistas ILoginView / ICatalogoView, LoginPresenter / CatalogoPresenter, contenedor MDI y formularios |

`Form1` notifica el intento de acceso a `LoginPresenter`. El presentador llama a Negocio y comunica el resultado. `DashboardForm` delega carga y filtrado en `CatalogoPresenter`; este usa `ICatalogoService`. Las vistas no ejecutan SQL ni algoritmos de hash. `MainForm` se encarga de navegación y estructura visual.

## Dos contratos obligatorios

En **Negocio**, separados:

```csharp
public interface IHashService { string GenerarHash(string password); }
public interface IVerificarHashService { bool Verificar(string password, string hash); }
```

`PasswordService` implementa ambos. Generación: PBKDF2-SHA256, 600000 iteraciones, sal aleatoria de 16 bytes y derivado de 32 bytes. Verificación: recuperación de parámetros del hash y comparación de tiempo constante. La generación está disponible desde el servicio; la aplicación no incluye registro de usuarios porque no se solicitó esa pantalla. Los hashes de instalación son compatibles con el servicio y se verifican automáticamente.

## Base de datos y permisos

`01_instalar.sql` crea/actualiza `db_sistema_login_mvp`, agrega campos del perfil si faltan, y crea las tablas clientes, empleados y productos. Inserta 8 clientes, 5 empleados y 8 productos de ejemplo sin duplicar registros en ejecuciones posteriores.

`02_permisos.sql` crea la cuenta si no existe y concede solo SELECT sobre columnas de usuario necesarias y las tres tablas de consulta. La aplicación no utiliza root. Se debe ejecutar como administrador; no desde la cuenta limitada. La cuenta existente conserva su contraseña. No se utiliza el SQL de pruebas ni se elimina la base antigua.

## Controles utilizados

| Control | Uso |
|---|---|
| Form / MdiClient | Acceso, contenedor y vista hija MDI |
| Panel / FlowLayoutPanel / TableLayoutPanel | Menú, perfil, tarjetas y distribución adaptable |
| Button | Menú, módulos, actualización, acceso y cierre de sesión |
| Label | Identidad, cantidades, reloj y fecha |
| TextBox | Acceso y búsqueda |
| DataGridView | Listas de solo lectura |
| PictureBox | Logo del acceso |
| Timer | Reloj actualizado cada segundo |
| ToolTip | Ayuda del menú plegado y textos de identidad |
| MessageBox | Validaciones y errores |

## Tecnologías y versiones

| Tecnología | Versión |
|---|---|
| .NET | 10; net10.0 / net10.0-windows |
| C# | Predeterminada del SDK .NET 10 |
| Windows Forms | Incluido en .NET Desktop |
| MySql.Data | 26.7.0 (dependencia del proyecto original) |
| MySQL | Registrar versión instalada con SELECT VERSION(); diseño para MySQL 8 |
| Visual Studio | Completar versión instalada, compatible con .NET 10 |

## Evidencias para la entrega

Agregar capturas REALES dentro de `docs/capturas` y luego insertar estas imágenes en el README. No se incluyen capturas simuladas.

| Captura | Archivo |
|---|---|
| Menú expandido con reloj y perfil | docs/capturas/principal.png |
| Menú plegado | docs/capturas/menu_plegado.png |
| Lista de clientes | docs/capturas/clientes.png |
| Lista de empleados | docs/capturas/empleados.png |
| Lista de productos | docs/capturas/productos.png |
| Validación de campos vacíos o credenciales incorrectas | docs/capturas/validacion.png |

Una vez guardadas, usar por ejemplo `![Pantalla principal](docs/capturas/principal.png)`.

Craps se retiró porque corresponde a otro laboratorio, según aclaración del equipo. No se incluye ni se utiliza como evidencia de esta entrega.

## Pruebas antes de entregar

1. Acceso vacío, contraseña incorrecta y usuario inactivo deben rechazar entrada.
2. Acceso válido debe cargar 8 clientes, 5 empleados y 8 productos en una instalación nueva.
3. Abrir/cerrar menú con ☰ varias veces; botones y barra inferior deben permanecer accesibles.
4. Cambiar los tres módulos, buscar coincidencias y una búsqueda sin resultados; limpiar para restaurar.
5. Actualizar listas después de un cambio desde Workbench. El reloj debe continuar funcionando.
6. Probar cierre de sesión, acceso con otro usuario y nombre/correo/rol correspondiente.
7. Repetir scripts: no debe duplicar datos ni cambiar contraseñas. Revisar SHOW GRANTS de la cuenta limitada.
8. Cerrar la aplicación y confirmar que termina el proceso.

Las verificaciones automáticas se ejecutan con `dotnet run --project Verificaciones`. El resultado de las pruebas realizadas se registra en `VERIFICACION.md`; la interfaz Windows requiere comprobación en tu PC.

## Repositorio

Enlace: **PENDIENTE**. Subir fuentes, scripts y documentación. `.gitignore` excluye .vs, bin, obj y archivos locales. Completar autores, versiones y capturas antes de entregar.

## Diseñador visual de Windows Forms

Las tres pantallas usan la estructura estándar de formulario, archivo Designer y recursos:

| Pantalla | Archivo de lógica | Archivo visual | Recursos |
|---|---|---|---|
| Acceso | Form1.cs | Form1.Designer.cs | Form1.resx |
| Menú y sesión | MainForm.cs | MainForm.Designer.cs | MainForm.resx |
| Listas y reloj | DashboardForm.cs | DashboardForm.Designer.cs | DashboardForm.resx |

Abrir el archivo principal con clic derecho > Ver diseñador o Shift+F7. Las dos pantallas principales se editan por separado: el tablero se inserta como ventana hija MDI al ejecutar. Su constructor sin parámetros solo llama a InitializeComponent; la carga de MySQL y el reloj se activan en Shown, fuera del diseñador. Las columnas de la tabla se editan en la colección Columns; el código alterna su visibilidad por módulo sin recrearlas.

Más indicaciones en [COMO_EDITAR_PANTALLAS.md](COMO_EDITAR_PANTALLAS.md).
