using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniProj.Data;
using UniProj.Models;

namespace UniProj.Pages.Workers
{
    public class CreateModel : PositionNamePageModel
    {
        private readonly UniProj.Data.WebShopContext _context;

        public CreateModel(UniProj.Data.WebShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PositionDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Worker Worker { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyWorker = new Worker();

            if (await TryUpdateModelAsync<Worker>(
                 emptyWorker,
                 "worker",   // Prefix for form value.
                 s => s.Id, s => s.IdPosition, s => s.Name, s => s.LastName, s => s.Email, s => s.PhoneNumber, s => s.Salary))
            {
                _context.Workers.Add(emptyWorker);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            PositionDropDownList(_context, emptyWorker.Id);
            return Page();

        }
    }
}
