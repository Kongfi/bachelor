using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using API.Domain.Exceptions;
using API.Models;

namespace API.Infrastructure.Middleware
{
    // ExceptionMiddleware fanger exceptions der bliver kastet i progreammet, og formaterer en respons til klient med fejlkoder + besked
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var httpStatusCode = HttpStatusCode.InternalServerError;
            var errorCode = ErrorCodes.INTERNAL.Code;
            var errorMessage = ErrorCodes.INTERNAL.Message;

            if (exception is BusinessRuleException brEx)
            {
                httpStatusCode = HttpStatusCode.UnprocessableEntity;
                errorCode = brEx.ErrorCode;
                errorMessage = brEx.ErrorMessage;
            }
            else if (exception is NotFoundException nfEx)
            {
                httpStatusCode = HttpStatusCode.NotFound;
                errorCode = nfEx.ErrorCode;
                errorMessage = nfEx.ErrorMessage;
            }
            else if (exception is ConflictException cEx)
            {
                httpStatusCode = HttpStatusCode.Conflict;
                errorCode = cEx.ErrorCode;
                errorMessage = cEx.ErrorMessage;
            }

            var errorResponse = new ApiErrorResponse(errorCode, errorMessage);
            var serializedResponse = JsonSerializer.Serialize(errorResponse, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)httpStatusCode;
            return context.Response.WriteAsync(serializedResponse, context.RequestAborted);
        }
    }
}
