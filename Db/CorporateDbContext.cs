using TestWebApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace TestWebApplication.Db;

public class CorporateDbContext(DbContextOptions<CorporateDbContext> options) : DbContext(options)
{
    public DbSet<Corporate> corporates => Set<Corporate>();
} 
