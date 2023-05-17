using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(); //klas�rdeki controlleri ekleyebilmek i�in

builder.Configuration.AddJsonFile("ocelot.json").AddEnvironmentVariables();
builder.Services.AddOcelot(builder.Configuration);
var app = builder.Build(); 


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.MapControllers(); // controlleri map edebilsin diye

app.Run();

