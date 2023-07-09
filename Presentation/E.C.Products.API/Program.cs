using E.C.Products.API;
using E.C.Products.Application.Interfaces.Persistence;
using E.C.Products.Persistence.Repositories;
using E.C.Products.Persistence.Shared;
using Microsoft.EntityFrameworkCore;
using GrapghQL = Microsoft.AspNetCore.Builder.GraphQLEndpointConventionBuilder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// Add Application Db Context options
builder.Services.AddDbContext<ECProductsDbContext>(
    options => {  
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL(path: "/graphql");

app.Run();
