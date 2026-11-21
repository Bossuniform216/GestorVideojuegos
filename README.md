Gestor de Videojuegos
Información general
Nombre del proyecto
Gestor de Videojuegos

Estudiante
[Tu nombre]

Descripción
Aplicación de escritorio desarrollada con C# y .NET que permite registrar, consultar y eliminar videojuegos.

Problema que resuelve
Permite organizar una colección personal de videojuegos de forma sencilla, almacenando la información en una base de datos SQLite.

Objetivo
Aplicar Programación Orientada a Objetos, Avalonia UI y ADO.NET para la gestión de información persistente.

Funcionalidades
Registrar videojuegos.
Consultar videojuegos almacenados.
Eliminar videojuegos.
Persistencia de datos mediante SQLite.
Interfaz gráfica desarrollada con Avalonia UI.
Tecnologías utilizadas
.NET
C#
Avalonia UI
ADO.NET
SQLite
Microsoft.Data.Sqlite
Estructura del proyecto
GestorVideojuegos
│
├── Data
│   ├── DatabaseManager.cs
│   └── VideojuegoDAO.cs
│
├── Models
│   └── Videojuego.cs
│
├── Services
│   └── VideojuegoService.cs
│
├── evidencias
│
├── MainWindow.axaml
├── MainWindow.axaml.cs
├── App.axaml
├── Program.cs
Aplicación de POO
Clase Videojuego: entidad principal.
Clase VideojuegoDAO: acceso a datos.
Clase VideojuegoService: lógica del sistema.
MainWindow: interfaz gráfica.
Instalación
Clonar repositorio:

git clone URL_DEL_REPOSITORIO
Ingresar a la carpeta:

cd GestorVideojuegos
Restaurar dependencias:

dotnet restore
Ejecución
dotnet run
Base de datos
Se utiliza SQLite mediante Microsoft.Data.Sqlite.

Tabla principal:

Videojuegos
Id
Nombre
Genero
Plataforma
Calificacion
Las operaciones CRUD se realizan desde la clase VideojuegoDAO.

La base de datos se crea automáticamente al iniciar la aplicación.

Evidencias
Registro
Captura donde se muestra el registro exitoso de un videojuego.

Consulta
Captura de la lista de videojuegos almacenados.

Eliminación
Captura mostrando la eliminación de un registro.

Persistencia
Captura demostrando que los datos continúan después de reiniciar la aplicación.

Problemas encontrados
Uno de los principales problemas fue la configuración inicial de Avalonia UI y la integración con SQLite.

La solución consistió en instalar las plantillas de Avalonia mediante NuGet y agregar el paquete Microsoft.Data.Sqlite al proyecto mediante la CLI de .NET.