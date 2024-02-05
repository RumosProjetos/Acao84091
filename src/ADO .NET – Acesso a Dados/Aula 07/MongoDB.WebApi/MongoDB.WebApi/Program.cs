using Microsoft.Extensions.DependencyInjection;
using MongoDB.WebApi.Models;
using MongoDB.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<LivrariaDatabaseSettings>(builder.Configuration.GetSection("LivrariaDatabase"));

builder.Services.AddSingleton<LivrariaDatabaseSettings>();

builder.Services.AddSingleton<LivroService>();



builder.Services.AddControllers()
      .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
