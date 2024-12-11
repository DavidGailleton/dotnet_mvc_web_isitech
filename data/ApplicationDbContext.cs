using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.data;

// Class de contexte de base de données, elle permet de définire les tables de la base de données
public class ApplicationDbContext : IdentityDbContext<Teacher>
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Event> Events { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}