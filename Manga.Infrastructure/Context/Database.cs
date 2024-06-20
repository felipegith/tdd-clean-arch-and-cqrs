using Microsoft.EntityFrameworkCore;

namespace Manga.Infrastructure.Context;

public class Database : DbContext
{
    public Database(DbContextOptions<Database> options) : base(options){}
    
    public DbSet<Domain.Entities.Manga> Mangas { get; set; }
}