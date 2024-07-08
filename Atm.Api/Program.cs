using Microsoft.EntityFrameworkCore;
using Atm.Api.DataAccess;
using Atm.Api.Core.Repository.Concrete;
using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Service.Abstract;
using Atm.Api.Service.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AtmDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddTransient<IAtmMachineRepository,AtmRepository>();
builder.Services.AddTransient<IAtmService,AtmService>();
builder.Services.AddTransient<ICityRepository, CityRepository>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<IDistrictRepository, DistrictRepository>();
builder.Services.AddTransient<IDistrictService, DistrictService>();


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
