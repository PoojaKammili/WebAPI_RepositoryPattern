using Microsoft.EntityFrameworkCore;
using System;
using WebAPI_RepositoryPattern.dbContext;
using WebAPI_RepositoryPattern.Repository;
using WebAPI_RepositoryPattern.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Configuration.SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json", optional: false, reloadOnChange : true).Build();

builder.Services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register DI for services and repositories
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<ProductService>();

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
