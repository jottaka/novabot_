using System;
using static novabot.Helpers.EnumerablesHelper;

namespace novabot.Models.ViewModels
{

public class ListQuoteRequestModel{
    public OrderByEnum OrderBy {get; set;}
    public int Page {get; set;}
    public int N {get; set;}
}

}
