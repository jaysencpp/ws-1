using Fagdag.Application;
using Fagdag.Infrastructure;
using Fagdag.Presentation;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

//TODO: Run this project and also stop it after you ran it
//TODO: Use global search to find the file where "a1" is
//TODO: Go to TodoController
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
