namespace Tangent.CeviriDukkani.Domain.Exceptions
{
    public class BusinessException : GeneralSystemException
    {
        public BusinessException(string exceptionCode) : base(exceptionCode) { }
    }
}
