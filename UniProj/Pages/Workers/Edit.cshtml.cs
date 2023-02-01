using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniProj.Data;
using UniProj.Models;

namespace UniProj.Pages.Workers
{
    public class EditModel : PositionNamePageModel
    {
        private readonly UniProj.Data.WebShopContext _context;

        public EditModel(UniProj.Data.WebShopContext context)
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
                .Include(c => c.Position).FirstOrDefaultAsync(m => m.IdPosition == id);

            if (Worker == null)
            {
                return NotFound();
            }

            PositionDropDownList(_context, Worker.Id);

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
                   c => c.Name, c => c.IdPosition))
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
