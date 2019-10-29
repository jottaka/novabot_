using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using novabot.Models;
using static novabot.Helpers.EnumerablesHelper;

namespace novabot.Repositories.interfaces
{

public interface IQuoteRepository{
    
    string GetQuote(QuoteModel quote);
    void UpdateQuote(QuoteModel quote);
    void DeleteQuote(string id);
    List<QuoteModel> GetList(OrderByEnum orderBy, int page, int N);
    void Upvote(string quoteId); 
    void Downvote(string quoteId)
}

}
