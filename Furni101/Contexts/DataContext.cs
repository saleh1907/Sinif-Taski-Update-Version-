using Furni101.Models;
using Microsoft.EntityFrameworkCore;

namespace Furni101.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BLog> bLogs { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BlogTag>blogTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Price = 50,
                    ImageName = "product-1",
                    ImageUrl = "product-1.png",
                    CreateDate = new DateTime(2024, 1, 1),
                    UpdateDate = new DateTime(2024, 1, 1),
                    IsDeleted = false
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Price = 75,
                    ImageName = "product-2",
                    ImageUrl = "product-2.png",
                    CreateDate = new DateTime(2024, 1, 2),
                    UpdateDate = new DateTime(2024, 1, 2),
                    IsDeleted = false
                },
                new Product
                {
                    Id = 3,
                    Name = "Product 3",
                    Price = 120,
                    ImageName = "product-3",
                    ImageUrl = "product-3.png",
                    CreateDate = new DateTime(2024, 1, 3),
                    UpdateDate = new DateTime(2024, 1, 3),
                    IsDeleted = false
                },
                new Product
                {
                    Id = 4,
                    Name = "Product 4",
                    Price = 60,
                    ImageName = "product-1",
                    ImageUrl = "product-1.png",
                    CreateDate = new DateTime(2024, 1, 4),
                    UpdateDate = new DateTime(2024, 1, 4),
                    IsDeleted = false
                },
                new Product
                {
                    Id = 5,
                    Name = "Product 5",
                    Price = 90,
                    ImageName = "product-2",
                    ImageUrl = "product-2.png",
                    CreateDate = new DateTime(2024, 1, 5),
                    UpdateDate = new DateTime(2024, 1, 5),
                    IsDeleted = false
                },
                new Product
                {
                    Id = 6,
                    Name = "Product 6",
                    Price = 150,
                    ImageName = "product-3",
                    ImageUrl = "product-3.png",
                    CreateDate = new DateTime(2024, 1, 6),
                    UpdateDate = new DateTime(2024, 1, 6),
                    IsDeleted = false
                },
                new Product
                {
                    Id = 7,
                    Name = "Product 7",
                    Price = 110,
                    ImageName = "product-1",
                    ImageUrl = "product-1.png",
                    CreateDate = new DateTime(2024, 1, 7),
                    UpdateDate = new DateTime(2024, 1, 7),
                    IsDeleted = false
                },
                new Product
                {
                    Id = 8,
                    Name = "Product 8",
                    Price = 200,
                    ImageName = "product-2",
                    ImageUrl = "product-2.png",
                    CreateDate = new DateTime(2024, 1, 8),
                    UpdateDate = new DateTime(2024, 1, 8),
                    IsDeleted = false
                }
            );

            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Position = "Software Developer",
                Description = "Backend developer",
                ImageUrl = "person_1.jpg",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            },
            new Employee
            {
                Id = 2,
                FirstName = "Ayşe",
                LastName = "Kaya",
                Position = "UI/UX Designer",
                Description = "Frontend designer",
                ImageUrl = "person_2.jpg",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            },
            new Employee
            {
                Id = 3,
                FirstName = "Mehmet",
                LastName = "Demir",
                Position = "Project Manager",
                Description = "Team lead",
                ImageUrl = "person_3.jpg",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            },
            new Employee
            {
                Id = 4,
                FirstName = "Elif",
                LastName = "Çelik",
                Position = "QA Engineer",
                Description = "Testing specialist",
                ImageUrl = "person_4.jpg",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            }
            );

            modelBuilder.Entity<BLog>().HasData(
            new BLog
            {
                Id = 1,
                Title = "ASP.NET Core ",
                Text = "ASP.NET Core ",
                ImageUrl = "post-1.jpg",
                EmployeeId = 2,

            },
            new BLog
            {
                Id = 2,
                Title = "Entity Framework Core ",
                Text = "Entity Framework Core",
                ImageUrl = "post-2.jpg",
                EmployeeId = 3,

            },
            new BLog
            {
                Id = 3,
                Title = "Clean Code Yazmanın Önemi",
                Text = "Temiz kod, okunabilirliği artırır ve bakım maliyetlerini düşürür.",
                ImageUrl = "post-3.jpg",
                EmployeeId = 1,
            }
            );



        }


    }

    public class BlogTag
    {
    }
}
