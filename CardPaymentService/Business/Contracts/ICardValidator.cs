using CardPaymentService.Models;

namespace CardPaymentService.Business.Contracts
{
    public interface ICardValidator
    {
        public bool ValidateCardDetails(CardDetails cardDetails);
    }
}
