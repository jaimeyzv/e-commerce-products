using AutoMapper;
using E.C.Products.API.Resolvers;
using E.C.Products.Application.Interfaces.Persistence;
using E.C.Products.Application.UseCase.Categories.Commands;
using E.C.Products.Application.UseCase.Categories.Queries;
using E.C.Products.Infrastructure.Mapper;
using E.C.Products.Persistence.Repositories;
using E.C.Products.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IGetAllCategories, GetAllCategories>();
builder.Services.AddScoped<ICreateCategory, CreateCategory>();

// Add Application Db Context options
builder.Services.AddDbContext<ECProductsDbContext>(
    options => {  
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

builder.Services.AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<CategoryQueryResolver>()
    .AddMutationType(m => m.Name("Mutation"))
    .AddType<CategoryMutationResolver>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());
});

var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL(path: "/graphql");

app.Run();
