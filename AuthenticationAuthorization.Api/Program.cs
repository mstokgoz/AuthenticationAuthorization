using System.Text;
using AuthenticationAuthorization.Api.OptionsSetup;
using AuthenticationAuthorization.Application;
using AuthenticationAuthorization.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.ConfigureOptions<SwaggerGenOptionsSetup>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();

builder.Services.ConfigureOptions<JwtOptionsSetup>();

builder.Services.ConfigureOptions<JwtBearerOptionsSetup>();

builder.Services.AddApplicationServiceRegistrations();

builder.Services.AddInfrastructureServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
// app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.Run();