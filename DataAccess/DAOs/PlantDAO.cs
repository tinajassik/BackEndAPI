using DataAccess.DAOInterfaces;
using Domain.DTOs;
using Domain.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccess.DAOs;

public class PlantDAO : IPlantDAO
{
    private readonly DbContext DbContext;

    public PlantDAO(DbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<Plant> CreateAsync(PlantCreationDTO plantCreationDto)
    {
        try
        {
            var plant = new Plant()
            {
                Location = plantCreationDto.Location,
                Type = plantCreationDto.Type,
                // PlantPreset = plantCreationDto.PlantPreset, 
                Name = plantCreationDto.Name
            };
            EntityEntry<Plant> newPlant = await DbContext.Plants.AddAsync(plant);
            await DbContext.SaveChangesAsync();
            return newPlant.Entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Task<Plant> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
}