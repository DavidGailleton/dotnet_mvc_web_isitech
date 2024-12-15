using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Event> Events { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
            /*
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole()
                {
                    Id = "2",
                    Name = "Teacher",
                    NormalizedName = "TEACHER"
                },
                new IdentityRole()
                {
                    Id = "0",
                    Name = "Student",
                    NormalizedName = "STUDENT"
                }
            );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher()
                {
                    Id = "0",
                    Firstname = "Jane",
                    Lastname = "Doe",
                    Email = "jane.doe@tpespnet.fr",
                    DateOfBirth = DateOnly.Parse("1980-01-01"),
                    Subject = "Mathematics"
                },
                new User()
                {
                    Id = "1",
                    Firstname = "admin",
                    Lastname = "admin",
                    Email = "admin@tpespnet.fr",
                    DateOfBirth = DateOnly.Parse("1980-01-01"),
                }
            );
        }
        */

}