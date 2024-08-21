using Microsoft.EntityFrameworkCore;
using Atm.Api.DataAccess;
using Atm.Api.Core.Repository.Concrete;
using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Service.Abstract;
using Atm.Api.Service.Concrete;
using Atm.Api.Data;
using Atm.Api.Data.Validations;
using FluentValidation.AspNetCore;
using FluentValidation;


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
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<IAtmService,AtmService>();
builder.Services.AddTransient<ICityRepository, CityRepository>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<IDistrictRepository, DistrictRepository>();
builder.Services.AddTransient<IDistrictService, DistrictService>();
builder.Services.AddAutoMapper(typeof(MyMapper));
builder.Services.AddValidatorsFromAssemblyContaining<CreateAtmMachineDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateAtmMachineDtoValidator>();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://localhost:5173") 
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowOrigin");

app.MapControllers();

app.Run();
