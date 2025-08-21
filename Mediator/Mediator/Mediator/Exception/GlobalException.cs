using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mediator.Exception
{
    public static class GlobalException
    {
        public static void HandelException(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseExceptionHandler(
                e => e.Run(async Context =>
                {
                    var errvali = Context.Features.Get<IExceptionHandlerFeature>();
                    var exception = errvali?.Error;

                    if ( !(exception is ValidationException validationException) )
                    {
                        throw exception;
                    }
                    var erros = validationException.Errors.Select
                    (
                        item => new
                        {
                            Property = item.PropertyName ,
                            message = item.ErrorMessage
                        });

                    var jsonContent = JsonSerializer.Serialize(erros);
                    Context.Response.StatusCode = (int) HttpStatusCode.InternalServerError  ;
                    Context.Response.ContentType = "application/json" ;
                    await Context.Response.WriteAsync(jsonContent,System.Text.Encoding.UTF8);
                })
                );
        }
    }
}

