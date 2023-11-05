using CardPaymentService.Models;

namespace CardPaymentService.Business.Contracts
{
    public interface ITransactionManager
    {
        public TransactionResult ProcessTransaction(PaymentDetails paymentDetails);
    }
}
