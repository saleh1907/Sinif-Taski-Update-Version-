namespace Furni101.ViewModels;

public class ProductCreateVM
{

    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public string? ImageName { get; set; }
    public string? ImageUrl { get; set; }

    public bool IsDeleted { get; set; }
    public IFormFile MainImage { get; set; }
    public IFormFile HoverImage { get; set; }
    public ICollection<IFormFile>? Images { get; set; }
}
