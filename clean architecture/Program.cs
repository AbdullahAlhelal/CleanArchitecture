using clean_architecture.infastrcured;
using clean_architecture.infastrcured.persistnace.Data;
using clean_architecture.Services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.AddinfastrcuredRegisration();
//builder.AddservicRegisration();

var con = builder.Configuration.GetSection("ConnectionStrings:DefaultConnction").Value;
builder.Services.AddDbContext<ApplicationDbContext>(optionsAction => optionsAction.UseSqlServer(builder.Configuration.GetSection("DefaultConnction").Value)); ;
var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() )
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
