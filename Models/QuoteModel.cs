using System;

namespace novabot.Models
{

public class QuoteModel{
    //FK
    public string UserId{get; set;}

    public string Content {get; set;}
    public string QuoteId{get;set;}
    public DateTimeOffset Date {get;set;}
    public int Upvotes {get;set}
    public int Downvotes {get; set ;}
}

}
