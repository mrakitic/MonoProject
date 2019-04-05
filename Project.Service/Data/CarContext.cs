using Microsoft.EntityFrameworkCore;
using Project.Service.Models;



namespace Project.Service.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }
        public DbSet<VehicleMake> VehicleMakes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleMake>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Index).HasColumnName("Index");

                entity.Property(e => e.DateCreated);
                entity.Property(e => e.DateUpdated);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Abrv)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });




            modelBuilder.Entity<VehicleModel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Index).HasColumnName("Index");

                entity.Property(e => e.DateCreated);
                entity.Property(e => e.DateUpdated);

                entity.HasOne(d => d.VehicleMake)
                    .WithMany()
                    .HasForeignKey(d => d.MakeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Model_Make");
            });







            



        }
    }
}
