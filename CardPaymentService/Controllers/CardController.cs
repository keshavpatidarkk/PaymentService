using Microsoft.AspNetCore.Mvc;
using CardPaymentService.Models;
using CardPaymentService.Business.Contracts;

namespace CardPaymentService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        private readonly ICardValidator _cardValidator;
        private readonly ITransactionManager _transactionManager;
        public CardController(ICardValidator cardValidator, ITransactionManager transactionManager)
        {
            _cardValidator = cardValidator;
            _transactionManager = transactionManager;
        }

        [HttpPost(Name = "IntiateTransation")]
        public IActionResult Post([FromBody] PaymentDetails paymentDetails)
        {
            TransactionResult result = null;
            if (_cardValidator.ValidateCardDetails(paymentDetails.cardDetails))
            {
                result = _transactionManager.ProcessTransaction(paymentDetails);
                if (result == null) {
                    return BadRequest("Transaction failed: Insuffiecient Balance");
                }
            }
            else
            {
                return BadRequest("Invalid Card details");
            }
            return Ok(result);
        }
    }
}