namespace Cadeteria.ViewModels;

public class PedidoViewModel
{
    private int id;
    private string? observaciones;
    private float precio;
    private bool estado;

    public int Id { get => id; set => id = value; }
    public string? Observaciones { get => observaciones; set => observaciones = value; }
    public float Precio { get => precio; set => precio = value; }
    public bool Estado { get => estado; set => estado = value; }
}