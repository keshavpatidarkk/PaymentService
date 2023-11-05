using CardPaymentService.Business.Contracts;
using CardPaymentService.Data.Contracts;
using CardPaymentService.Models;

namespace CardPaymentService.Business.Logic
{
    public class TransactionManager : ITransactionManager
    {
        private ICardData _cardData;
        public TransactionManager(ICardData cardData)
        {
            _cardData = cardData;
        }
        public TransactionResult ProcessTransaction(PaymentDetails paymentDetails)
        {
            TransactionResult transactionResult=null;
            if (_cardData.GetCardBalance(paymentDetails.cardDetails) >= paymentDetails.Amount)
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
