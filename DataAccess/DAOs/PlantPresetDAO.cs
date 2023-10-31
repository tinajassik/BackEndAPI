using DataAccess.DAOInterfaces;
using Domain.DTOs;
using Domain.Model;

namespace DataAccess.DAOs;

public class PlantPresetDAO : IPlantPresetDAO
{
    public async Task<PlantPreset> CreateAsync(PlantPresetCreationDTO plant)
    {
        throw new NotImplementedException();
    }

    public async Task<PlantPreset> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
}