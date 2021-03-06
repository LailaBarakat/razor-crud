using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_crud.Models;

namespace razor_crud.Pages.Toys
{
    public class CreateModel : PageModel
    {
        private readonly razorcrudToyContext _context;

        public CreateModel(razorcrudToyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Toy Toy { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Toy.Add(Toy);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
