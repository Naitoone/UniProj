using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniProj.Models;

namespace UniProj.Pages.Workers
{
    public class EditModel : PositionNamePageModel
    {
        private readonly Data.WebShopContext _context;

        public EditModel(Data.WebShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Worker Worker { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Workers == null)
            {
                return NotFound();
            }

            Worker = await _context.Workers
                .AsNoTracking()
                .Include(c => c.Position)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Worker == null)
            {
                return NotFound();
            }

            PositionDropDownList(_context, Worker.IdPosition);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workerToUpdate = await _context.Workers.FindAsync(id);

            if (workerToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Worker>(
                 workerToUpdate,
                 "worker",   // Prefix for form value.
                   s => s.Id, s => s.IdPosition, s => s.Name, s => s.LastName, s => s.Email, s => s.PhoneNumber, s => s.Salary))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            PositionDropDownList(_context, workerToUpdate.IdPosition);
            return Page();
        }
    }
}
