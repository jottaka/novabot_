using System.Collections.Generic;
using novabot.Helpers;
using novabot.Models;
using novabot.Models.ViewModels;
using novabot.Repositories.interfaces;

namespace novabot.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        public string AddQuote(QuoteModel quote)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteQuote(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Downvote(string quoteId)
        {
            throw new System.NotImplementedException();
        }

        public ListQuoteResponseModel GetList(ListQuoteRequestModel request)
        {
            throw new System.NotImplementedException();
        }

        public string GetQuote(QuoteModel quote)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateQuote(QuoteModel quote)
        {
            throw new System.NotImplementedException();
        }

        public void Upvote(string quoteId)
        {
            throw new System.NotImplementedException();
        }
    }
}