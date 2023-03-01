using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MinimalAPI.Contracts;
using MinimalAPI.Database;
using MinimalAPI.Models;
using MinimalAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(
    builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Enables cors 
app.UseCors(options => options.WithOrigins("http://localhost:5173")
.AllowAnyMethod().AllowAnyHeader());

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

// Endpoints for items

app.MapGet("api/items", async (IItemRepository repo, IMapper mapper) =>
{
    var items = await repo.GetAllAsync();
    return Results.Ok(mapper.Map<IEnumerable<ItemReadDto>>(items));
});

app.MapGet("api/items/{id}", async (IItemRepository repo, IMapper mapper, int id) =>
{
    var item = await repo.GetAsync(id);
    if (item != null) return Results.Ok(mapper.Map<ItemReadDto>(item));
    return Results.NotFound();
});

app.MapPost("api/items", async (IItemRepository repo, IMapper mapper, ItemCreateDto itemCreate) => 
{
    var itemModel = mapper.Map<Item>(itemCreate);
    await repo.CreateAsync(itemModel);

    //Could return the object instead of a bool.
    return Results.Ok();

});

app.MapPatch("api/items/{id}", async (IItemRepository repo, IMapper mapper, int id, ItemUpdateDto updateDto) =>
{
    var item = await repo.GetAsync(id);
    if (item != null)
    {
        mapper.Map(updateDto, item);
        await repo.UpdateAsync(item);
        return Results.NoContent();
    }
    return Results.NotFound();
});

app.MapDelete("api/items/{id}", async (IItemRepository repo, IMapper mapper, int id) => 
{
    var item = await repo.GetAsync(id);
    if (item != null)
    {
        await repo.DeleteAsync(item.Id);
        return Results.NoContent();
    }
    return Results.NotFound();
});

app.Run();
