using Microsoft.AspNetCore.Mvc;
using UPIPaymentService.Models;
using UPIPaymentService.Business.Contracts;

namespace UPIPaymentService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UPIController : ControllerBase
    {
        private readonly IUPIValidator _upiIdValidator;
        private readonly ITransactionManager _transactionManager;
        public UPIController(IUPIValidator upiIdValidator, ITransactionManager transactionManager)
        {
            _upiIdValidator = upiIdValidator;
            _transactionManager = transactionManager;
        }

        [HttpPost(Name = "IntiateTransation")]
        public IActionResult Post([FromBody] PaymentDetails paymentDetails)
        {
            TransactionResult result = null;
            if (_upiIdValidator.ValidateUpiId(paymentDetails.UpiId))
            {
                result = _transactionManager.ProcessTransaction(paymentDetails);
                if (result == null) {
                    return BadRequest("Transaction failed: Insuffiecient Balance");
                }
            }
            else
            {
                return BadRequest("Invalid UPI Id!");
            }
            return Ok(result);
        }
    }
}