using Microsoft.AspNetCore.Identity;
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
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Création des rôles
        var roles = new List<IdentityRole>
        {
            new() { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new() { Id = "2", Name = "Teacher", NormalizedName = "TEACHER" },
            new() { Id = "3", Name = "Student", NormalizedName = "STUDENT" }
        };
        
        modelBuilder.Entity<IdentityRole>().HasData(roles);

        // Création d'un Teacher
        var hasher = new PasswordHasher<User>();
        var teacher = new Teacher
        {
            Id = "11111111-1111-1111-1111-111111111111",
            UserName = "teacher@example.com",
            NormalizedUserName = "TEACHER@EXAMPLE.COM",
            Email = "teacher@example.com",
            NormalizedEmail = "TEACHER@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Teacher123!"),
            SecurityStamp = string.Empty,
            Firstname = "John",
            Lastname = "Doe",
            Subject = "Computer Science",
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddYears(-30))
        };

        // Création d'un Student
        var student = new Student
        {
            Id = "22222222-2222-2222-2222-222222222222",
            UserName = "student@example.com",
            NormalizedUserName = "STUDENT@EXAMPLE.COM",
            Email = "student@example.com",
            NormalizedEmail = "STUDENT@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Student123!"),
            SecurityStamp = string.Empty,
            Firstname = "Jane",
            Lastname = "Smith",
            Major = "Computer Science",
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddYears(-20))
        };

        modelBuilder.Entity<Teacher>().HasData(teacher);
        modelBuilder.Entity<Student>().HasData(student);

        // Attribution des rôles aux utilisateurs
        var userRoles = new List<IdentityUserRole<string>>
        {
            new() { UserId = teacher.Id, RoleId = roles.First(r => r.Name == "Teacher").Id },
            new() { UserId = student.Id, RoleId = roles.First(r => r.Name == "Student").Id }
        };

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
    }
}