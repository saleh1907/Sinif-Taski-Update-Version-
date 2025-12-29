using Furni101.Models;

namespace Furni101.ViewModels;

public class BlogCreateVM
{
    public string  Tittle {  get; set; }
    public string Text { get; set; }
    public List<int>SelectedTagIds { get; set; }
    public List<Tag> Tags { get; set; }
}
