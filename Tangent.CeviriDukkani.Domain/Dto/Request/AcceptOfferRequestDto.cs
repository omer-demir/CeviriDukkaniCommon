namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class AcceptOfferRequestDto {
        public int BidderId { get; set; }
        public int TranslationOperationId { get; set; }
        public decimal Price { get; set; }
    }
}