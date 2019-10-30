using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NovaBot.Models;
using NovaBot.Models.ViewModels;
using NovaBot.Repositories.interfaces;

namespace NovaBot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SlackController : ControllerBase
    {
        private readonly ILogger<SlackController> _logger;
        private readonly IUserRepository _userRepository;

        public SlackController(
            ILogger<SlackController> logger,
            IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult SlackVerification([FromBody] SlackEventRequestModel request)
        {
            try
            {
                IActionResult response;
                switch (request.type)
                {
                    case "url_verification":
                        response = Ok(request.challenge);
                            break;
                    case "message":
                        response = Ok();
                        break;
                    default:
                        response = Ok();
                        break;
                }

                return response;
            }
            catch (Exception e)
            {
                _logger.LogError($"Erro ao receber evento do slack: {e}");
                return BadRequest();
            }
        }


    }
}
