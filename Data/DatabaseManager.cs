using Microsoft.Data.Sqlite;

namespace GestorVideojuegos.Data;

public static class DatabaseManager
{
    private const string ConnectionString =
        "Data Source=videojuegos.db";

    public static string GetConnectionString()
    {
        return ConnectionString;
    }

    public static void Inicializar()
    {
        using var conexion =
            new SqliteConnection(ConnectionString);

        conexion.Open();

        string sql = @"
        CREATE TABLE IF NOT EXISTS Videojuegos
        (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nombre TEXT NOT NULL,
            Genero TEXT NOT NULL,
            Plataforma TEXT NOT NULL,
            Calificacion REAL NOT NULL
        );";

        using var comando =
            new SqliteCommand(sql, conexion);

        comando.ExecuteNonQuery();
    }
}