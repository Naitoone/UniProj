using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniProj.Models;

namespace UniProj.Pages.Workers
{
    public class IndexModel : PageModel
    {
        private readonly Data.WebShopContext _context;

        public IndexModel(Data.WebShopContext context)
        {
            _context = context;
        }

        public IList<Worker> Worker { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Workers != null)
            {
                Worker = await _context.Workers.AsNoTracking().Include(x => x.Position).ToListAsync();
            }
        }
    }
}
