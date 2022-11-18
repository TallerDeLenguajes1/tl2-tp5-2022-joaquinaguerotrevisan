namespace Cadeteria.ViewModels;
using System.ComponentModel.DataAnnotations;

public class CadeteViewModel
{
    private int id;
    private string? nombre;
    private string? domicilio;
    private string? telefono;

    public int Id { get => id; set => id = value; }

    [Display(Name = "Nombre del cadete")]
    [Required]    
    public string? Nombre { get => nombre; set => nombre = value; }

    [Display(Name = "Domicilio del cadete")]
    [Required]    
    public string? Domicilio { get => domicilio; set => domicilio = value; }
   
    [Display(Name = "Teléfono del cadete")]
    [Required] [Phone]   
    public string? Telefono { get => telefono; set => telefono = value; }
}