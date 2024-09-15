using System.ComponentModel.DataAnnotations;

namespace Precificacao.Models;
public class Ingrediente
{
    [Display(Name = "Código")]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    public string? Nome { get; set; }

    [Display(Name = "Unidade de medida")]
    public string? UnidadeMedida { get; set; }
}
