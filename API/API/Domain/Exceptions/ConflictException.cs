using System;

namespace API.Domain.Exceptions
{
    /// <summary>
    /// To be thrown when business logic fails due to a conflict.
    /// This exception type is caught by the global filter and formatted before sending responses to the client.
    /// </summary>
    public class ConflictException : Exception
    {
        public ConflictException(ErrorCode errorCode)
        {
            ErrorCode = errorCode.Code;
            ErrorMessage = errorCode.Message;
        }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}