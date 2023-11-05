using UPIPaymentService.Data.Contracts;
using UPIPaymentService.Models;

namespace UPIPaymentService.Data.Logic
{
    public class UPIAccountData : IUPIAccountData
    {
        private readonly Dictionary<string, UpiAccountDetails> allUpiAccountDetailsList;
        public UPIAccountData() {

            allUpiAccountDetailsList = new Dictionary<string, UpiAccountDetails>
        {
           {"user1@upi", new UpiAccountDetails { AccountBalance = 1000.50m, UpiId = "user1@upi"}},
           {"user2@upi" , new UpiAccountDetails { AccountBalance = 750.25m, UpiId = "user2@upi" }},
           {"user3@upi" , new UpiAccountDetails { AccountBalance = 500.00m, UpiId = "user3@upi" }},
           {"user4@upi", new UpiAccountDetails { AccountBalance = 1200.75m, UpiId = "user4@upi"}},
           {"user5@upi" , new UpiAccountDetails { AccountBalance = 300.60m, UpiId = "user5@upi" }},
           {"user6@upi" , new UpiAccountDetails { AccountBalance = 950.20m, UpiId = "user6@upi" }},
           {"user7@upi" , new UpiAccountDetails { AccountBalance = 800.40m, UpiId = "user7@upi" }},
           {"user8@upi" , new UpiAccountDetails { AccountBalance = 650.70m, UpiId = "user8@upi" }},
           {"user9@upi", new UpiAccountDetails { AccountBalance = 1800.90m, UpiId = "user9@upi"}},
           {"user10@upi", new UpiAccountDetails { AccountBalance = 250.15m, UpiId = "user10@upi" }}
        };
        }
        public Dictionary<string, UpiAccountDetails> GetUPIAccountDetails()
        {
            return allUpiAccountDetailsList;
        }

        public Decimal GetAccountBalance(string UpiId)
        {
            return allUpiAccountDetailsList[UpiId].AccountBalance;
        }

    }
}
