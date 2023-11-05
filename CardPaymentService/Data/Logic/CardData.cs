using CardPaymentService.Data.Contracts;
using CardPaymentService.Models;

namespace CardPaymentService.Data.Logic
{
    public class CardData : ICardData
    {
        private readonly Dictionary<string, AccountDetails> allCardsDetails;
        public CardData() {
            allCardsDetails = new Dictionary<string, AccountDetails>
        {
            { GenerateKey(1234567890123456, "12/25", 123), new AccountDetails { CardNumber = 1234567890123456, Expiry = "12/25", Cvv = 123, AvailableBalance=1000 } },
            { GenerateKey(9876543210987654, "05/24", 456), new AccountDetails { CardNumber = 9876543210987654, Expiry = "05/24", Cvv = 456, AvailableBalance=2000 } },
            { GenerateKey(1111222233334444, "08/23", 789), new AccountDetails { CardNumber = 1111222233334444, Expiry = "08/23", Cvv = 789, AvailableBalance=10000 } },
            { GenerateKey(5555666677778888, "02/26", 321), new AccountDetails { CardNumber = 5555666677778888, Expiry = "02/26", Cvv = 321, AvailableBalance=5000 } },
            { GenerateKey(9999000011112222, "10/27", 654), new AccountDetails { CardNumber = 9999000011112222, Expiry = "10/27", Cvv = 654, AvailableBalance=6000 } },
            { GenerateKey(4444333322221111, "04/24", 987), new AccountDetails { CardNumber = 4444333322221111, Expiry = "04/24", Cvv = 987, AvailableBalance=200 } },
            { GenerateKey(7777666655554444, "09/23", 234), new AccountDetails { CardNumber = 7777666655554444, Expiry = "09/23", Cvv = 234, AvailableBalance=400 } },
            { GenerateKey(2222111133338888, "07/25", 567), new AccountDetails { CardNumber = 2222111133338888, Expiry = "07/25", Cvv = 567, AvailableBalance=4000 } },
            { GenerateKey(6666555544442222, "03/26", 890), new AccountDetails { CardNumber = 6666555544442222, Expiry = "03/26", Cvv = 890, AvailableBalance= 100} },
            { GenerateKey(8888999911117777, "01/28", 432), new AccountDetails { CardNumber = 8888999911117777, Expiry = "01/28", Cvv = 432, AvailableBalance= 2222} },
        };
        }
        public Dictionary<string, AccountDetails> GetAllCardsDetails()
        {
            return allCardsDetails;
        }

        public Decimal GetCardBalance(CardDetails cardDetails)
        {
            return allCardsDetails[GenerateKey(cardDetails.CardNumber, cardDetails.Expiry, cardDetails.Cvv)].AvailableBalance;
        }

        public static string GenerateKey(long cardNumber, string expiry, int cvv)
        {
            return $"{cardNumber}-{expiry}-{cvv}";
        }
    }
}
