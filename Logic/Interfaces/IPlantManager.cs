using Domain.DTOs;
using Domain.Model;

namespace Logic.Interfaces;

public interface IPlantManager
{

    Task<Plant> CreateAsync(PlantCreationDTO plantCreationDto); 

}