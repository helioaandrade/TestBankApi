using BankApi.Application.Services.Account;
using BankApi.Domain.Common;
using BankApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        /// <returns></returns

        [HttpPost("reset")]
        [Produces("text/plain")]
        public ActionResult Reset()
        {
            _accountApplicationService.Reset();
            return Ok("OK");
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

            if (account.Id == null)
            {
                return NotFound(0);
            }

            return Ok(_accountApplicationService.GetBalance(account_id));
        }

        /// <summary>
        /// Send account events
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("event")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> SendEvent(EventEntity request)
        {
            try
            {
                if (!_accountApplicationService.CheckEventType(request.Type))
                {
                    return NotFound(0);
                }

                var result = _accountApplicationService.SendEvent(request);

                if (request.Type.ToLower() == Constants.EVENT_WITHDRAW)
                {
                    if (result.Origin == null)
                        return NotFound(0);
                }

                if (request.Type.ToLower() == Constants.EVENT_TRANSFER)
                {
                    if (result.Destination == null)
                        return NotFound(0);
                }

                return Created(string.Empty, result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
