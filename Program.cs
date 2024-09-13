using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmallDelivery;
using SmallDelivery.Auth;
using SmallDelivery.Models;
using SmallDelivery.Models.Mapping;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<AuthService>();

builder.Services.AddAutoMapper(config =>
            {
                config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
                // config.AddProfile(new AssemblyMappingProfile(typeof(ICityDbContext).Assembly));
            });

builder.Services.AddDbContext<SmallDeliveryDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SmallDeliveryDb")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
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
// app.MapPost("/authenticate", (User user, AuthService authService)
//     => authService.GenerateToken(user));
app.MapControllers();

app.Run();

