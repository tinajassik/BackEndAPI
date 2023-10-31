using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    
    
    public DbSet<Plant> Plants { get; set; }
    public DbSet<PlantPreset> Presets { get; set; }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ../DataAccess/PlantData.db");
    }
    
    // I am not sure if we need this 
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<PlantPreset>().HasKey(preset => preset.PresetId);
    //     modelBuilder.Entity<Plant>().HasKey(plant => plant.PlantId);
    // }
}