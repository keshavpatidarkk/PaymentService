using UPIPaymentService.Models;

namespace UPIPaymentService.Business.Contracts
{
    public interface IUPIValidator
    {
        public bool ValidateUpiId(string upiId);
    }
}
