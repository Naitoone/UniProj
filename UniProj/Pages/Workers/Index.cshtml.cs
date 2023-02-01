using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniProj.Data;
using UniProj.Models;

namespace UniProj.Pages.Workers
{
    public class IndexModel : PageModel
    {
        private readonly UniProj.Data.WebShopContext _context;

        public IndexModel(UniProj.Data.WebShopContext context)
        {
            _context = context;
        }

        public IList<Worker> Worker { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Workers != null)
            {
                Worker = await _context.Workers.ToListAsync();
            }
        }
    }
}
