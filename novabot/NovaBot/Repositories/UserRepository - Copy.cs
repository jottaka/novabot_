using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NovaBot.Models;
using NovaBot.Models.ViewModels;
using NovaBot.Repositories.interfaces;
using NovaBot.Data;

namespace NovaBot.Repositories
{
    public class SlackRepository : ISlackRepository
    {
        private readonly ApplicationDbContext _context;
        public SlackRepository(
            ApplicationDbContext context
            )
        {
            _context = context;
        }

        public async Task<string> AddQuoteAsync(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}