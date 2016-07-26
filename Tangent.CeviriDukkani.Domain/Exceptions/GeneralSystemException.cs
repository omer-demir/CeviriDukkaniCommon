using System;

namespace Tangent.CeviriDukkani.Domain.Exceptions
{
    public class GeneralSystemException : Exception
    {
        public string ExceptionCode { get; set; }

        public override string Message => $"{ExceptionCode} - {base.Message}";

        public GeneralSystemException(string exceptionCode)
        {
            ExceptionCode = exceptionCode;
        }
    }
}
