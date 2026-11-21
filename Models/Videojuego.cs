namespace GestorVideojuegos.Models;

public class Videojuego
{
    public int Id { get; set; }

    public string Nombre { get; set; } = "";

    public string Genero { get; set; } = "";

    public string Plataforma { get; set; } = "";

    public double Calificacion { get; set; }

    public Videojuego()
    {
    }

    public Videojuego(
        string nombre,
        string genero,
        string plataforma,
        double calificacion)
    {
        Nombre = nombre;
        Genero = genero;
        Plataforma = plataforma;
        Calificacion = calificacion;
    }
}