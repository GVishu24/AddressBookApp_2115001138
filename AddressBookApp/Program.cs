using BusinessLayer.Interface;
using BusinessLayer.Services;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Mapping;
using ModelLayer.Validators;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using RepositoryLayer.Services;

var builder = WebApplication.CreateBuilder(args);


// Registering(injecting) AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

//Fluent Validation
builder.Services.AddValidatorsFromAssemblyContaining<AddressBookValidator>();


// Add DbContext

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<AddressBookDbContext>(options =>
    options.UseSqlServer(connectionString));

// Register Repository & Business Layer Services
builder.Services.AddScoped<IAddressBookRL, AddressBookRL>();
builder.Services.AddScoped<IAddressBookBL, AddressBookBL>();


// Add services to the container.

builder.Services.AddControllers();

// Adding Swagger
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
