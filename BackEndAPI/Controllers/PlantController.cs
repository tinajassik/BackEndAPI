﻿using Domain.DTOs;
using Domain.Model;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PlantController : ControllerBase
{

    private IPlantManager plantManager;


    public PlantController(IPlantManager plantManager)
    {
        this.plantManager = plantManager;
    }
    
    
    [HttpPost]
    [Route("createPlant")]
    public async Task<ActionResult<Plant>> CreateAsync(PlantCreationDTO plant)
    {
        try
        {
            Plant newPlant = await plantManager.CreateAsync(plant);
            return Created($"/file/{newPlant.PlantId}", newPlant);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }


}