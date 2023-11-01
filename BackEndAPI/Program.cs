using DataAccess;
using DataAccess.DAOInterfaces;
using DataAccess.DAOs;
using Logic.Implementations;
using Logic.Interfaces;
using AppContext = DataAccess.AppContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//3000
// builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddDbContext<AppContext>();
builder.Services.AddScoped<IPlantManager, PlantManagerImpl>();
builder.Services.AddScoped<IPlantPresetManager, PlantPresetManagerImpl>();
builder.Services.AddScoped<IPlantDAO, PlantDAO>();
builder.Services.AddScoped<IPlantPresetDAO, PlantPresetDAO>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();