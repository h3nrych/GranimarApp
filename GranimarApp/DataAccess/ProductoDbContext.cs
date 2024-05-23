
using MauiAppCrud.Modelos;
using MauiAppCrud.Utilidades;
using Microsoft.EntityFrameworkCore;

namespace MauiAppCrud.DataAccess
{
    public class EmpleadoDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDB = $"Filename={ConexionDB.DevolverRuta("empleados.db")}";
            optionsBuilder.UseSqlite(conexionDB);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(col => col.IdEmpleado);
                entity.Property(col => col.IdEmpleado).IsRequired().ValueGeneratedOnAdd();
            });
        }

    }
}
