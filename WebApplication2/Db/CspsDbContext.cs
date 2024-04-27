using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities;

namespace WebApplication2.Db
{
    public class CspsDbContext(DbContextOptions<CspsDbContext> options) : DbContext(options)
    {
        public DbSet<Corporate> Corporates => Set<Corporate>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Corporate>(x => {
                x.ToTable("CORPORATE", "CSPS");
                x.Property<int>("Id").HasColumnName("ID");
                x.Property<int>("Code").HasColumnName("CODE");
                x.Property<string?>("Name").HasColumnName("NAME");
                x.Property<string?>("NationalIdentity").HasColumnName("NATIONAL_IDENTITY");
                x.Property<DateTime>("Timestamp").HasColumnName("TS");
                x.Property<string?>("ModifiedBy").HasColumnName("MODIFIED_BY");
                x.Property<int>("RowVersion").HasColumnName("ROW_VERSION");
                }
            );
        }
    }
}
