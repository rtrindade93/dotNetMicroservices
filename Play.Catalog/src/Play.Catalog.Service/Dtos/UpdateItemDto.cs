namespace Play.Catalog.Service.Dtos
{
    public record UpdateItemDto(
        string Name,
        string Description,
        decimal Price);
}