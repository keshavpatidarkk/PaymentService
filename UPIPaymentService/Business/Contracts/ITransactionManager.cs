using UPIPaymentService.Models;

namespace UPIPaymentService.Business.Contracts
{
    public interface ITransactionManager
    {
        public TransactionResult ProcessTransaction(PaymentDetails paymentDetails);
    }
}
