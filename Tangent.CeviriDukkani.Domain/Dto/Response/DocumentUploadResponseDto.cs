namespace Tangent.CeviriDukkani.Domain.Dto.Response
{
    public class DocumentUploadResponseDto
    {
        public string FilePath { get; set; }
        public int CharCount { get; set; }
        public int CharCountWithSpaces { get; set; }
        public int PageCount { get; set; }
    }
}
