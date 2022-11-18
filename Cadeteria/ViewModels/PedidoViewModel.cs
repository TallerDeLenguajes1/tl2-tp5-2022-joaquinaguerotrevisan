namespace Cadeteria.ViewModels;
using System.ComponentModel.DataAnnotations;

public class PedidoViewModel
{
    private int id;
    private string? observaciones;
    private float precio;
    private bool estado;

    public int Id { get => id; set => id = value; }

    [Display(Name = "Observasiones")]
    [Required]
    public string? Observaciones { get => observaciones; set => observaciones = value; }

    [Display(Name = "Precio")]
    [Required]
    public float Precio { get => precio; set => precio = value; }

    [Required]
    public bool Estado { get => estado; set => estado = value; }
}