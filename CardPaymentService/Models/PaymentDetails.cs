namespace CardPaymentService.Models
{
    public class PaymentDetails
    {
        public decimal Amount { get; set; }

        public CardDetails cardDetails { get; set; }
    }
}
