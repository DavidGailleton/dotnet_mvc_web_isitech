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
        },
        new() {
   Id = 6,
   Title = "Game Jam - Création de Jeux Vidéo",
   Description = "Un weekend complet dédié à la création de jeux vidéo. Venez avec vos idées et repartez avec un prototype jouable !",
   EventDate = DateTime.Now.AddDays(45),
   MaxParticipants = 60,
   Location = "Espace Gaming",
   CreatedAt = DateTime.Now.AddDays(-2)
},
new() {
   Id = 7,
   Title = "Workshop Data Science",
   Description = "Initiation pratique à Python et aux bibliothèques de data science (Pandas, NumPy, Scikit-learn)",
   EventDate = DateTime.Now.AddDays(10),
   MaxParticipants = 30,
   Location = "Laboratoire Data",
   CreatedAt = DateTime.Now.AddDays(-8)
},
new() {
   Id = 8,
   Title = "Cloud Computing - AWS Basics",
   Description = "Découvrez les services fondamentaux d'Amazon Web Services et déployez votre première application",
   EventDate = DateTime.Now.AddDays(15),
   MaxParticipants = 40,
   Location = "Salle Cloud",
   CreatedAt = DateTime.Now.AddDays(-4)
},
new() {
   Id = 9,
   Title = "Design Thinking Workshop",
   Description = "Apprenez à résoudre des problèmes complexes avec la méthodologie du Design Thinking",
   EventDate = DateTime.Now.AddDays(5),
   MaxParticipants = 25,
   Location = "Studio Design",
   CreatedAt = DateTime.Now.AddDays(-6)
},
new() {
   Id = 10,
   Title = "Mobile App Development",
   Description = "Formation intensive sur le développement d'applications mobiles avec Flutter",
   EventDate = DateTime.Now.AddDays(60),
   MaxParticipants = 35,
   Location = "Lab Mobile",
   CreatedAt = DateTime.Now.AddDays(-1)
},
new() {
   Id = 11,
   Title = "Network Security Masterclass",
   Description = "Une journée dédiée à la sécurité des réseaux et aux bonnes pratiques",
   EventDate = DateTime.Now.AddDays(25),
   MaxParticipants = 45,
   Location = "Salle Sécurité",
   CreatedAt = DateTime.Now.AddDays(-3)
},
new() {
   Id = 12,
   Title = "UX/UI Design Fundamentals",
   Description = "Les principes essentiels du design d'interface et de l'expérience utilisateur",
   EventDate = DateTime.Now.AddDays(12),
   MaxParticipants = 30,
   Location = "Design Lab",
   CreatedAt = DateTime.Now.AddDays(-5)
},
new() {
   Id = 13,
   Title = "Agile Project Management",
   Description = "Formation aux méthodologies agiles et à la gestion de projet moderne",
   EventDate = DateTime.Now.AddDays(18),
   MaxParticipants = 50,
   Location = "Salle Agile",
   CreatedAt = DateTime.Now.AddDays(-7)
},
new() {
   Id = 14,
   Title = "Big Data Analytics",
   Description = "Explorez les outils et techniques d'analyse de données massives",
   EventDate = DateTime.Now.AddDays(35),
   MaxParticipants = 40,
   Location = "Data Center",
   CreatedAt = DateTime.Now.AddDays(-9)
},
new() {
   Id = 15,
   Title = "IoT Workshop",
   Description = "Création de projets connectés avec Arduino et Raspberry Pi",
   EventDate = DateTime.Now.AddDays(28),
   MaxParticipants = 20,
   Location = "Lab IoT",
   CreatedAt = DateTime.Now.AddDays(-4)
}
    };

    modelBuilder.Entity<Teacher>().HasData(teachers);
    modelBuilder.Entity<Student>().HasData(students);
    modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
    modelBuilder.Entity<Event>().HasData(events);
}   
}