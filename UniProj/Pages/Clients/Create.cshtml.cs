using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniProj.Data;
using UniProj.Models;

namespace UniProj.Pages.Clients
{
    public class CreateModel : PageModel
    {
        private readonly UniProj.Data.WebShopContext _context;

        public CreateModel(UniProj.Data.WebShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyClient = new Client();

            if (await TryUpdateModelAsync<Client>(
                emptyClient,
                "client",   // Prefix for form value.
                c=> c.Name, c => c.LastName, c => c.Email, c => c.NrPhone))
            {
                _context.Clients.Add(emptyClient);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }


    }
}
