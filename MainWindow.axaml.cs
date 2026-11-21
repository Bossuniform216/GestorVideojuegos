using Avalonia.Controls;
using Avalonia.Interactivity;

using GestorVideojuegos.Models;
using GestorVideojuegos.Services;
using GestorVideojuegos.Data;

namespace GestorVideojuegos;

public partial class MainWindow : Window
{
    private readonly VideojuegoService servicio =
        new();

    public MainWindow()
    {
        InitializeComponent();

        DatabaseManager.Inicializar();

        CargarLista();
    }

    private void Guardar_Click(
        object? sender,
        RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(
            txtNombre.Text))
        {
            return;
        }

        double calificacion = 0;

        double.TryParse(
            txtCalificacion.Text,
            out calificacion);

        Videojuego videojuego =
            new Videojuego(
                txtNombre.Text ?? "",
                txtGenero.Text ?? "",
                txtPlataforma.Text ?? "",
                calificacion
            );

        servicio.Guardar(videojuego);

        Limpiar();

        CargarLista();
    }

    private void Cargar_Click(
        object? sender,
        RoutedEventArgs e)
    {
        CargarLista();
    }

    private void Eliminar_Click(
        object? sender,
        RoutedEventArgs e)
    {
        if (int.TryParse(
            txtIdEliminar.Text,
            out int id))
        {
            servicio.Eliminar(id);

            CargarLista();
        }
    }

    private void CargarLista()
    {
        listaVideojuegos.Items.Clear();

        foreach (var v in servicio.ObtenerTodos())
        {
            listaVideojuegos.Items.Add(
                $"{v.Id} - {v.Nombre} - {v.Genero} - {v.Plataforma} - {v.Calificacion}"
            );
        }
    }

    private void Limpiar()
    {
        txtNombre.Text = "";
        txtGenero.Text = "";
        txtPlataforma.Text = "";
        txtCalificacion.Text = "";
    }
}
