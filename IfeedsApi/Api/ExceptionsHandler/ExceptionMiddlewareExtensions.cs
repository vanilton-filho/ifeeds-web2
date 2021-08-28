using System;
using System.Net;
using IfeedsApi.Domain.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace IfeedsApi.Api.ExceptionsHandler
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(builder =>
        {
            builder.Run(async context =>
            {
                var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (exceptionHandlerFeature != null)
                {
                    if (exceptionHandlerFeature.Error.GetBaseException() is EntidadeEmUsoException)
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.Conflict;
                        context.Response.ContentType = "application/json";

                        var json = new ErrorModel
                        {
                            Title = "Conflict",
                            Status = context.Response.StatusCode,
                            UserMessage = "O objeto não pode ser deletado",
                            Detail = exceptionHandlerFeature.Error.Message,
                            Timestamp = DateTime.UtcNow,
                        };

                        await context.Response.WriteAsync(JsonConvert.SerializeObject(json));
                    }

                }
            });
        });
        }

    }
}