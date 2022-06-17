using BankApi.Application.Services.Account;
using BankApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BankApi.Controllers
{
    [Route("")]
    [ApiController]
     public class AccountController : ControllerBase
    {
        private readonly IAccountApplicationService _accountApplicationService;

        public AccountController(IAccountApplicationService accountApplicationService)
        {
            _accountApplicationService = accountApplicationService;
        }
        /// <summary>
        /// Reset account
        /// </summary>
        /// <returns></returns>
        [HttpPost("reset")]
        public ActionResult Reset()
        {
            _accountApplicationService.Reset();
            return Ok();
        }

        /// <summary>
        /// Get balance by account_id
        /// </summary>
        /// <param name="account_id"></param>
        /// <returns></returns>
        [HttpGet("balance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<int> Get(string account_id)
        {
            var account = _accountApplicationService.GetAccount(account_id);

            if ( account.Id == null)
            {
                return NotFound(0);
            }

            var result = _accountApplicationService.GetBalance(account_id);
            return Ok(result);
        }

        /// <summary>
        /// Send event
        /// </summary>
        /// <param name="eventModel"></param>
        /// <returns></returns>
        [HttpPost("event")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult SendEvent(EventEntity request)
        {
            try
            {
                var result = _accountApplicationService.SendEvent(request);

                var response = JsonConvert.SerializeObject(result);

                return Created(string.Empty, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
