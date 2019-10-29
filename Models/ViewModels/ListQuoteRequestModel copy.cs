using System;
using static novabot.Helpers.EnumerablesHelper;

namespace novabot.Models.ViewModels
{

public class ListQuoteResponseModel{
    public int TotalQuotes {get; set;}
    public string NumberOfPages {get; set;}
    public List<QuoteModel> quotes{get;set;}
    public int PageNumber {get; set;}


}

}
