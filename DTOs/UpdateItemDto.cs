using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
  public record updateItemDto
  {
    [Required]
    public string Name { get; init; }

    [Required]
    [Range(1, 1000)]
    public decimal Price { get; init; }
  }
}