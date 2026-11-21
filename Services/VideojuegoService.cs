using System.Collections.Generic;

using GestorVideojuegos.Data;
using GestorVideojuegos.Models;

namespace GestorVideojuegos.Services;

public class VideojuegoService
{
    private readonly VideojuegoDAO dao =
        new();

    public void Guardar(Videojuego videojuego)
    {
        dao.Agregar(videojuego);
    }

    public List<Videojuego> ObtenerTodos()
    {
        return dao.ObtenerTodos();
    }

    public void Eliminar(int id)
    {
        dao.Eliminar(id);
    }
}