namespace Furni101.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<BLog>? Blogs { get; set; }
    }
}
