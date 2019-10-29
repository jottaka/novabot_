using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using novabot.Models;

namespace novabot.Repositories.interfaces
{

public interface IUserRepository{
    
    List<UserModel> GetUsers();
    UserModel GetUser(string userId);
    string AddUser(UserModel user);
    void UpdateUsr(UserModel user);
    void DeleteUser(string userId);
}

}
