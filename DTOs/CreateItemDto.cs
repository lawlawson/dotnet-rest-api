namespace Catalog.Dtos
{
  public record createItemDto
  {
    public string Name { get; init; }

    public decimal Price { get; init; }
  }
}