using UPIPaymentService.Business.Contracts;
using UPIPaymentService.Data.Contracts;
using UPIPaymentService.Models;

namespace UPIPaymentService.Business.Logic
{
    public class UPIValidator : IUPIValidator
    {
        private IUPIAccountData _upiAccountData;
        public UPIValidator(IUPIAccountData upiAccountData) {
            _upiAccountData = upiAccountData;
        }
        
        public bool ValidateUpiId(string upiId)
        {
            if (_upiAccountData.GetUPIAccountDetails().ContainsKey(upiId))
            {
                return true;
            }
            else
                return false;

        }
    }
}
