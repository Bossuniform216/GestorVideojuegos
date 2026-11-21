using Microsoft.Data.Sqlite;
using GestorVideojuegos.Models;
using System.Collections.Generic;

namespace GestorVideojuegos.Data;

public class VideojuegoDAO
{
    private readonly string connectionString =
        DatabaseManager.GetConnectionString();

    public void Agregar(Videojuego videojuego)
    {
        using var conexion = new SqliteConnection(connectionString);

        conexion.Open();

        string sql = @"INSERT INTO Videojuegos
        (Nombre, Genero, Plataforma, Calificacion)
        VALUES
        (@nombre,@genero,@plataforma,@calificacion)";

        using var comando = new SqliteCommand(sql, conexion);

        comando.Parameters.AddWithValue("@nombre", videojuego.Nombre);
        comando.Parameters.AddWithValue("@genero", videojuego.Genero);
        comando.Parameters.AddWithValue("@plataforma", videojuego.Plataforma);
        comando.Parameters.AddWithValue("@calificacion", videojuego.Calificacion);

        comando.ExecuteNonQuery();
    }

    public List<Videojuego> ObtenerTodos()
    {
        List<Videojuego> lista = new();

        using var conexion = new SqliteConnection(connectionString);

        conexion.Open();

        string sql = "SELECT * FROM Videojuegos";

        using var comando = new SqliteCommand(sql, conexion);

        using var reader = comando.ExecuteReader();

        while (reader.Read())
        {
            lista.Add(new Videojuego
            {
                Id = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Genero = reader.GetString(2),
                Plataforma = reader.GetString(3),
                Calificacion = reader.GetDouble(4)
            });
        }

        return lista;
    }

    public void Eliminar(int id)
    {
        using var conexion = new SqliteConnection(connectionString);

        conexion.Open();

        string sql = "DELETE FROM Videojuegos WHERE Id=@id";

        using var comando = new SqliteCommand(sql, conexion);

        comando.Parameters.AddWithValue("@id", id);

        comando.ExecuteNonQuery();
    }
}