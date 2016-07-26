namespace Tangent.CeviriDukkani.Domain.Exceptions
{
    public class DbOperationException : GeneralSystemException
    {
        public DbOperationException(string exceptionCode) : base(exceptionCode) { }
    }
}
