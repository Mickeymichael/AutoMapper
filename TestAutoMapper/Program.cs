using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestAutoMapper;
using TestAutoMapper.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContextPool<CLSDBContext>(op => op.UseSqlServer("data source=.;database=ErenyMapperDB;integrated security=true;"));

//1
var mappinConfig = new MapperConfiguration(m =>
{
    m.AddProfile(new MappingProfile());// the name of your profile Class
});

//2
builder.Services.AddSingleton(mappinConfig.CreateMapper());//




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

app.UseAuthorization();

app.MapControllers();

app.Run();
