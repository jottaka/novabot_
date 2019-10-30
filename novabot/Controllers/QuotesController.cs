using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using novabot.Models;
using novabot.Repositories.interfaces;

namespace novabot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuotesController : ControllerBase
    {
        private readonly ILogger<QuotesController> _logger;
        private readonly IQuoteRepository _quotesRepository;

        public QuotesController(
            ILogger<QuotesController> logger,
            IQuoteRepository quotesRepository)
        {
            _logger = logger;
            _quotesRepository = quotesRepository;
        }

        [HttpPost]
        public IActionResult GetUsers([FromBody] QuoteModel quote){
            try{
                
                var quoteId =  _quotesRepository.AddQuote(quote);

                return Ok(quoteId);

            }catch(Exception e){
                _logger.LogError($"Não foi possivel adicionar quote: {e}");
                return BadRequest();
            }
        }

[HttpPost]
        public IActionResult UpdateQuote([FromBody] QuoteModel quote){
            try{
                _quotesRepository.UpdateQuote(quote);
                return Ok();

            }catch(Exception e){
                _logger.LogError($"Não foi possivel modificar quote: {e}");
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult DeleteQuote([FromBody] string quoteId){
            try{
                _quotesRepository.DeleteQuote(quoteId);
                return Ok();

            }catch(Exception e){
                _logger.LogError($"Não foi possivel deletar quote: {e}");
                return BadRequest();
            }
        }

[HttpPost]
        public IActionResult UpdateQuote([FromBody] QuoteModel quote){
            try{
                _quotesRepository.UpdateQuote(quote);
                return Ok();

            }catch(Exception e){
                _logger.LogError($"Não foi possivel modificar quote: {e}");
                return BadRequest();
            }
        }

    }
}
