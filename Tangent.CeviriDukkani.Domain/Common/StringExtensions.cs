using System.Linq;

namespace Tangent.CeviriDukkani.Domain.Common
{
    public static class StringExtensions
    {
        public static string GetExtensionOfFile(this string filePath) {
            var splittedVal = filePath.Split('.');
            return splittedVal.LastOrDefault();
        }
    }
}
