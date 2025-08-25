
using FluentValidation;
using Mediator.Exception;
using Mediator.Interfaces;
using Mediator.PiplineBehavior;
using Mediator.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddMediatR(option=>option.RegisterServicesFromAssembly(typeof(Program).Assembly));
            builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);
            builder.Services.AddScoped<IUsersServices , UserServices>();
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>) ,typeof(RequestPipline<,>));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if ( app.Environment.IsDevelopment() )
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.HandelException();
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
