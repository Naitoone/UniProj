using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniProj.Data;
using UniProj.Models;

namespace UniProj.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly UniProj.Data.WebShopContext _context;

        public IndexModel(UniProj.Data.WebShopContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Client = await _context.Clients.Take(10).ToListAsync();
        }
    }
}
