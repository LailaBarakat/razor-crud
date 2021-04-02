using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_crud.Models;

namespace razor_crud.Pages.Toys
{
    public class DetailsModel : PageModel
    {
        private readonly razorcrudToyContext _context;

        public DetailsModel(razorcrudToyContext context)
        {
            _context = context;
        }

        public Toy Toy { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Toy = await _context.Toy.FirstOrDefaultAsync(m => m.ID == id);

            if (Toy == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
