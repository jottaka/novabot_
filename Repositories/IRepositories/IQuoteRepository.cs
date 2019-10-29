using System.Collections.Generic;
using novabot.Models;
using novabot.Models.ViewModels;
using static novabot.Helpers.EnumerablesHelper;

namespace novabot.Repositories.interfaces
{

    public interface IQuoteRepository{
    
    string AddQuote(QuoteModel quote);
    void UpdateQuote(QuoteModel quote);
    void DeleteQuote(string id);
    ListQuoteResponseModel GetList(ListQuoteRequestModel request);
    void Upvote(string quoteId); 
    void Downvote(string quoteId);
}

}
