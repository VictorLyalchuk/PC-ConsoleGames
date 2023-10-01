using Microsoft.EntityFrameworkCore;
using PC_ConsoleGames.Infrastructure;
using PC_ConsoleGames.Core;
using PC_ConsoleGames.WebApi;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("SommeConnection") ?? throw new InvalidOperationException("Connection string 'SommeConnection' not found.");

builder.Services.AddDbContext(connection); 

builder.Services.AddControllersWithCustomSchema();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGenWithCustomSchema();

builder.Services.AddIdentity();

builder.Services.AddRepository();

builder.Services.AddValidators();

builder.Services.AddAutoMapper();

builder.Services.AddCustomServices();

builder.Services.AddAuthenticationWithOptions(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
