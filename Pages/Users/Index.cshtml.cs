using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rpc.Models;
using RpcUsers.Data;

namespace RpcUsers.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly RpcUsers.Data.RpcUsersContext _context;

        public IndexModel(RpcUsers.Data.RpcUsersContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
