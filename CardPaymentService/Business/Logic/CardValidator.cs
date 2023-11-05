using CardPaymentService.Business.Contracts;
using CardPaymentService.Data.Contracts;
using CardPaymentService.Models;

namespace CardPaymentService.Business.Logic
{
    public class CardValidator : ICardValidator
    {
        private ICardData _cardData;
        public CardValidator(ICardData cardData) {
            _cardData = cardData;
        }
        
        public bool ValidateCardDetails(CardDetails cardDetails)
        {
            var cardHashKey = $"{cardDetails.CardNumber}-{cardDetails.Expiry}-{cardDetails.Cvv}";
            if (_cardData.GetAllCardsDetails().ContainsKey(cardHashKey))
            {
                return true;
            }
            else
                return false;

        }
    }
}
