using Furni101.Contexts;

namespace Furni101.Models;

public class Tag
{
    public int Id { get; set; }
    public int tagName { get; set; }
    public ICollection<BlogTag>BlogTags { get; set; }

}
