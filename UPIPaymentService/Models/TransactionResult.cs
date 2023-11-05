namespace UPIPaymentService.Models
{
    public class TransactionResult
    {
        public Guid TransactionId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
