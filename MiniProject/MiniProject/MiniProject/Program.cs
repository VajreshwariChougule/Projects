﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MiniProject.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MiniProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MiniProjectContext") ?? throw new InvalidOperationException("Connection string 'MiniProjectContext' not found.")));

// Add services to the container.

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
app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
             .AllowAnyHeader());

app.MapControllers();

app.Run();
