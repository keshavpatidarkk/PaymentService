using UPIPaymentService.Models;

namespace UPIPaymentService.Data.Contracts
{
    public interface IUPIAccountData
    {
        public Dictionary<string, UpiAccountDetails>  GetUPIAccountDetails();

        public Decimal GetAccountBalance(string upiId);
        
    }
}
