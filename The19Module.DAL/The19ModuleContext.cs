using _19Module.Domain.Person;
using _19Module.Domain.PersonClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace The19Module.DAL;
/// <summary>
/// Основной класс доступа к бд
/// </summary>
public partial class The19ModuleContext : DbContext
{
    public The19ModuleContext()
    {
    }

    public The19ModuleContext(DbContextOptions<The19ModuleContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }

    public virtual DbSet<Person> People { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;DataBase=The19Module;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity
                .ToTable("Person");

            entity.Property(e => e.Adress).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SecondName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
