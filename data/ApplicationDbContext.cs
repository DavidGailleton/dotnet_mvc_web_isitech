using Microsoft.EntityFrameworkCore;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.data;

// Class de contexte de base de données, elle permet de définire la=es tables de la base de données
public class ApplicationDbContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}