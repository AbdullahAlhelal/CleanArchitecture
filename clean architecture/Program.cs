using clean_architecture.infastrcured;
using clean_architecture.infastrcured.persistnace.Data;
using clean_architecture.Services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.AddinfastrcuredRegisration();
builder.AddservicRegisration();
builder.Services.AddDbContext<ApplicationDbContext>(optionsAction => optionsAction.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings").Value)); ;
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
