using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using PC_ConsoleGames.Infrastructure;
using PC_ConsoleGames.Core;

var builder = WebApplication.CreateBuilder(args);

//get connection string
string connection = builder.Configuration.GetConnectionString("SommeConnection") ?? throw new InvalidOperationException("Connection string 'ShopMVCConnection' not found.");

// builder.Services.AddDbContext(connection); 

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); ;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.MapType<TimeSpan>(() => new OpenApiSchema
    {
        Type = "string",
        Example = new OpenApiString("00:00:00")
    });
});


builder.Services.AddIdentity();
//added using extensions
builder.Services.AddRepository();
builder.Services.AddValidators();
builder.Services.AddAutoMapper();

// builder.Services.AddCustomServices();

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
