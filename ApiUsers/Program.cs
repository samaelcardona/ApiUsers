using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApiUsers.Data;
using System.Globalization;
var builder = WebApplication.CreateBuilder(args);
var cultureInfo = new CultureInfo("en-US"); // Crear una instancia de CultureInfo con la cultura deseada
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

builder.Services.AddDbContext<ApiUsersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApiUsersContext") ?? throw new InvalidOperationException("Connection string 'ApiUsersContext' not found.")));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
