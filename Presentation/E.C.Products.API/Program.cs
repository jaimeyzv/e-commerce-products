using E.C.Products.Application.Interfaces.Persistence;
using E.C.Products.Persistence.Repositories;
using E.C.Products.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// Add Application Db Context options
builder.Services.AddDbContext<ECProductsDbContext>(
    options => {  
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
