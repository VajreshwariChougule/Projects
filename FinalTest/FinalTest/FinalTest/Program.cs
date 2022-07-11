using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FinalTest.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FinalTestContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FinalTestContext") ?? throw new InvalidOperationException("Connection string 'FinalTestContext' not found.")));

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
