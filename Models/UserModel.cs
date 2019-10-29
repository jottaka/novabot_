using System.Collections.Generic;


namespace novabot.Models
{

public class UserModel{
    public string Name {get; set;}
    public string ProfilePicture{get; set;}
    public string UserId{get;set;}
    public uint Ranking {get;set;}
    public List<QuoteModel> Quotes;
}

}
