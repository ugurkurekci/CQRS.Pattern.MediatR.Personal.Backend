using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.ProjectDBContexts;

public class ProjectDbContext : DbContext
{
    public DbSet<About> Abouts { get; set; }

    public DbSet<Photo> Photos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=PersonalDB;Trusted_Connection=true");
        }
    }
}
