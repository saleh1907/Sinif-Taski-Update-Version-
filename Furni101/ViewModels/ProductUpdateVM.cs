using System.ComponentModel.DataAnnotations;

namespace Furni101.ViewModels;

public class ProductUpdateVM
{

    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public double Price { get; set; }
    public string? ImageName { get; set; }
    public string? ImageUrl { get; set; }
  
    public ICollection<IFormFile>?Images { get; set; }

    internal ProductUpdateVM ToListAsync()
    {
        throw new NotImplementedException();
    }
}
