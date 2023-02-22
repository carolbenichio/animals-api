using Animals.Api.Services;
using Animals.Api.ValueObjects;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AnimalService>();

var app = builder.Build();

app.MapGet("/animals", (AnimalService animalService) => animalService.GetAllAnimals());

app.MapGet("/animals/{id}", (AnimalService animalService, Guid id) => animalService.GetAnimalById(id));

app.MapPost("/animals", (AnimalService animalService, AnimalCreationPayloadVO payload)
    => animalService.CreateAnimals(payload.Types, payload.Quantity));

app.Run();
