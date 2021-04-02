using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_crud.Models;

namespace razor_crud.Pages.Films
{
    public class IndexModel : PageModel
    {
        private readonly razorcrudToyContext _context;

        public IndexModel(razorcrudToyContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; }

        public async Task OnGetAsync()
        {
            Film = await _context.Film.ToListAsync();
        }
    }
}
