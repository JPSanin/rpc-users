using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RpcUsers.Data;

namespace RpcUsers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RpcUsers.Data.RpcUsersContext _context;

        [BindProperty(SupportsGet = true)]
        public String UserID { get; set;}
        [BindProperty(SupportsGet = true)]
        public String Password { get; set;}

        public IndexModel(ILogger<IndexModel> logger, RpcUsers.Data.RpcUsersContext context)
        {
            _logger = logger;
            _context = context;
        }

        /*public void OnGet()
        {
            Console.WriteLine("Usuario: " + UserID + "\nPassword: " + Password);
        }*/

        public async Task<IActionResult> OnGetAsync() {
            Console.WriteLine("Usuario: " + UserID + "\nPassword: " + Password);

            if (UserID != null && Password != null)
            {
                var dataBaseUser = _context.User.FirstOrDefault(u => u.Username == UserID && u.Password == Password);
                if (dataBaseUser is null) {
                    return Page();
                }
                else {
                    return RedirectToPage("./Users/Index");
                }
            }
            else
            {
                return Page();
            }
        }
    }
}