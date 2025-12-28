namespace Furni101.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }   

        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public bool IsDeleted { get; set; }


    }
}
