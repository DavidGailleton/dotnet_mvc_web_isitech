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

    var hasher = new PasswordHasher<User>();

    // Création de plusieurs Teachers
    var teachers = new List<Teacher>
    {
        new() {
            Id = "11111111-1111-1111-1111-111111111111",
            UserName = "martin.dupont@teacher.com",
            NormalizedUserName = "MARTIN.DUPONT@TEACHER.COM",
            Email = "martin.dupont@teacher.com",
            NormalizedEmail = "MARTIN.DUPONT@TEACHER.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Teacher123!"),
            SecurityStamp = string.Empty,
            Firstname = "Martin",
            Lastname = "Dupont",
            Subject = "Mathematics",
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddYears(-35))
        },
        new() {
            Id = "22222222-2222-2222-2222-222222222222",
            UserName = "sophie.martin@teacher.com",
            NormalizedUserName = "SOPHIE.MARTIN@TEACHER.COM",
            Email = "sophie.martin@teacher.com",
            NormalizedEmail = "SOPHIE.MARTIN@TEACHER.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Teacher123!"),
            SecurityStamp = string.Empty,
            Firstname = "Sophie",
            Lastname = "Martin",
            Subject = "Computer Science",
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddYears(-30))
        },
        new() {
            Id = "33333333-3333-3333-3333-333333333333",
            UserName = "pierre.durand@teacher.com",
            NormalizedUserName = "PIERRE.DURAND@TEACHER.COM",
            Email = "pierre.durand@teacher.com",
            NormalizedEmail = "PIERRE.DURAND@TEACHER.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Teacher123!"),
            SecurityStamp = string.Empty,
            Firstname = "Pierre",
            Lastname = "Durand",
            Subject = "Physics",
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddYears(-40))
        }
    };

    // Création de plusieurs Students
    var students = new List<Student>
    {
        new() {
            Id = "44444444-4444-4444-4444-444444444444",
            UserName = "lucas.petit@student.com",
            NormalizedUserName = "LUCAS.PETIT@STUDENT.COM",
            Email = "lucas.petit@student.com",
            NormalizedEmail = "LUCAS.PETIT@STUDENT.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Student123!"),
            SecurityStamp = string.Empty,
            Firstname = "Lucas",
            Lastname = "Petit",
            Major = "Computer Science",
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddYears(-20))
        },
        new() {
            Id = "55555555-5555-5555-5555-555555555555",
            UserName = "emma.moreau@student.com",
            NormalizedUserName = "EMMA.MOREAU@STUDENT.COM",
            Email = "emma.moreau@student.com",
            NormalizedEmail = "EMMA.MOREAU@STUDENT.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Student123!"),
            SecurityStamp = string.Empty,
            Firstname = "Emma",
            Lastname = "Moreau",
            Major = "Mathematics",
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now.AddYears(-22))
        }
    };

    // Attribution des rôles
    var userRoles = new List<IdentityUserRole<string>>();
    
    foreach (var teacher in teachers)
    {
        userRoles.Add(new IdentityUserRole<string> 
        { 
            UserId = teacher.Id, 
            RoleId = roles.First(r => r.Name == "Teacher").Id 
        });
    }
    
    foreach (var student in students)
    {
        userRoles.Add(new IdentityUserRole<string> 
        { 
            UserId = student.Id, 
            RoleId = roles.First(r => r.Name == "Student").Id 
        });
    }

    // Création d'événements variés
    var events = new List<Event>
    {
        new() {
            Id = 1,
            Title = "Introduction à l'Intelligence Artificielle",
            Description = "Découvrez les fondamentaux de l'IA et ses applications dans le monde moderne",
            EventDate = DateTime.Now.AddDays(7),
            MaxParticipants = 100,
            Location = "Amphithéâtre A",
            CreatedAt = DateTime.Now.AddDays(-5)
        },
        new() {
            Id = 2,
            Title = "Workshop DevOps",
            Description = "Pratiques et outils essentiels pour le DevOps moderne",
            EventDate = DateTime.Now.AddDays(14),
            MaxParticipants = 50,
            Location = "Salle Informatique 2",
            CreatedAt = DateTime.Now.AddDays(-3)
        },
        new() {
            Id = 3,
            Title = "Conférence Cybersécurité",
            Description = "Les dernières tendances en matière de sécurité informatique",
            EventDate = DateTime.Now.AddDays(21),
            MaxParticipants = 150,
            Location = "Amphithéâtre B",
            CreatedAt = DateTime.Now.AddDays(-7)
        },
        new() {
            Id = 4,
            Title = "Hackathon Innovation",
            Description = "48h pour développer des solutions innovantes",
            EventDate = DateTime.Now.AddDays(30),
            MaxParticipants = 80,
            Location = "Campus Innovation Hub",
            CreatedAt = DateTime.Now.AddDays(-10)
        },
        new() {
            Id = 5,
            Title = "Web 3.0 et Blockchain",
            Description = "Explorer l'avenir du web décentralisé",
            EventDate = DateTime.Now.AddDays(-2),
            MaxParticipants = 120,
            Location = "Salle de Conférence C",
            CreatedAt = DateTime.Now.AddDays(-15)
        }
    };

    modelBuilder.Entity<Teacher>().HasData(teachers);
    modelBuilder.Entity<Student>().HasData(students);
    modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
    modelBuilder.Entity<Event>().HasData(events);
}   
}