namespace Cadeteria.ViewModels;

public class CadeteViewModel
{
    private int id;
    private string? nombre;
    private string? domicilio;
    private string? telefono;

    public int Id { get => id; set => id = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Domicilio { get => domicilio; set => domicilio = value; }
    public string? Telefono { get => telefono; set => telefono = value; }
}