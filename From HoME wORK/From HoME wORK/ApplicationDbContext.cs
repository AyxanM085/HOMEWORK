
using System.Reflection;
using System.Reflection.Emit;
using From_HoME_wORK;
using static From_HoME_wORK.brand;

public class ApplicationDbContext : DbContext
{
    private object options;
    private DbSet<System.Drawing.Color> colors;

    public ApplicationDbContext(object options)
    {
        this.options = options;
    }

    public DbSet<Brand> Brands { get; set; }
    public DbSet<Module> Models { get; set; }
    public DbSet<System.Drawing.Color> Colors { get => colors; set => colors = value; }
    public DbSet<From_HoME_wORK.Car> Cars { get; set; }
    public DbSet<Car_Color> CarColors { get; set; }

    protected override void OnModelCreating(ModuleBuilder modelBuilder)
    {
        modelBuilder.Entity<Car_Color>()
            .HasKey(cc => new { cc.CarId, cc.ColorId });

        modelBuilder.Entity<Car_Color>()
            .HasOne(cc => cc.Car)
            .WithMany(c => c.CarColors)
            .HasForeignKey(cc => cc.CarId);

        modelBuilder.Entity<Car_Color>()
            .HasOne(cc => cc.Color)
            .WithMany(c => c.CarColors)
            .HasForeignKey(cc => cc.ColorId);

        modelBuilder.Entity<Module>()
            .HasOne(m => m.Brand)
            .WithMany(b => b.Models)
            .HasForeignKey(m => m.BrandId);

        modelBuilder.Entity<Car>()
            .HasOne(c => c.Model)
            .WithMany(m => m.Cars)
            .HasForeignKey(c => c.ModelId);
    }

    internal object Entry(Brand brand)
    {
        throw new NotImplementedException();
    }

    internal Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}

public class DbContext
{
}