using UPIPaymentService.Business.Contracts;
using UPIPaymentService.Data.Contracts;
using UPIPaymentService.Models;

namespace UPIPaymentService.Business.Logic
{
    public class TransactionManager : ITransactionManager
    {
        private IUPIAccountData _upiAccountData;
        public TransactionManager(IUPIAccountData upiAccountData)
        {
            _upiAccountData = upiAccountData;
        }
        public TransactionResult ProcessTransaction(PaymentDetails paymentDetails)
        {
            TransactionResult transactionResult=null;
            if (_upiAccountData.GetAccountBalance(paymentDetails.UpiId) >= paymentDetails.Amount)
            {
                transactionResult = new TransactionResult
                {
                    TransactionId = Guid.NewGuid(),
                    Status = "Success",
                    Message = "Transaction successful."
                };
            }
            return transactionResult;
        }
    }
}
