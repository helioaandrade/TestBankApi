﻿using BankApi.Application.Services.Account;
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

            if (account.Id == null)
            {
                return NotFound(0);
            }

            var result = _accountApplicationService.GetBalance(account_id);
            return Ok(result);
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
        public ActionResult SendEvent(EventEntity request)
        {
            try
            {
                if (!CheckEventType(request.Type))
                {
                    return NotFound(0);
                }

                var result = _accountApplicationService.SendEvent(request);

                if (request.Type.ToLower() == "withdraw" )
                {
                    if (result.Origin == null)
                        return NotFound(0);
                }
 
                if (request.Type.ToLower() == "transfer")
                {
                    if (result.Destination == null)
                        return NotFound(0);
                }

                var response = JsonConvert.SerializeObject(result);

                return Created(string.Empty, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        private bool CheckEventType( string eventType)
        {
            return new List<string> { "deposit", "withdraw", "transfer" }.Contains(eventType);
        }


    }
}
