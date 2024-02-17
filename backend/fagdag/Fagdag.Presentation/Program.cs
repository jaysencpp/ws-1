using Fagdag.Application;
using Fagdag.Infrastructure;
using Fagdag.Presentation;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();
builder.Services.AddPresentationServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
