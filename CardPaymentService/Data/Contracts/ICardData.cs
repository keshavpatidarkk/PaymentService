using CardPaymentService.Models;

namespace CardPaymentService.Data.Contracts
{
    public interface ICardData
    {
        public Dictionary<string, AccountDetails>  GetAllCardsDetails();

        public Decimal GetCardBalance(CardDetails cardDetails);
        
    }
}
