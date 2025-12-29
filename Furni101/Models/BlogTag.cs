namespace Furni101.Models;

public class BlogTag
{
    public int Id { get; set; }
    public int BlogId { get; set; }
    public BLog BLog { get; set; }
    public int TagId { get; set; }
    public Tag Tag { get; set; }
}
