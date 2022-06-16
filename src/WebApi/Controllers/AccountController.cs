using BankApi.Application.Messages.Account;
using BankApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BankApi.Controllers
{
    [Route("")]
    [ApiController]

    public class AccountController : ControllerBase
    {
        /// <summary>
        /// Reset account
        /// </summary>
        /// <returns></returns>
        [HttpPost("reset")]
        public ActionResult Reset()
        {
            // TODO: call account service
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
        public ActionResult<int> Get(int account_id)
        {
            // TODO: call account service

            // only test
            if (account_id == 999)
            {
                return BadRequest();
            }

            return Ok(20);
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
            // TODO: call account service

            // only test

            // mock test deposit
            var result = new DepositResponse
            {
                Destination = new AccountEntity { Id = "222", Balance = 20 }
            };

            //// mock test transfer
            //var result = new TransferResponse
            //{
            //    Origin = new AccountEntity { Id = "111", Balance = 10 },
            //    Destination = new AccountEntity { Id = "222", Balance = 20 }
            //};

            // mock test Withdraw
            //var result = new WithdrawResponse { Origin = new AccountEntity { Id = "123", Balance = 20 } };

            var response = JsonConvert.SerializeObject(result);
            return Ok(response);
        }
    }
}
