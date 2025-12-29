namespace Furni101.Models
{
    public class BLog
    {
        public int Id { get; set; }
       

        public string Title { get; set; }

        public string Text { get; set; }


        public string ImageUrl { get; set; }

        public int EmployeeId { get; set; }
        public string ImageName     { get; set; }
        public DateTime PostedDate { get; set; }

        public Employee? Employee { get; set; }

    }
}
