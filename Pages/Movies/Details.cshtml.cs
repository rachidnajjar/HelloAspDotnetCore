using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloAspDotnetCore.Models;

namespace HelloAspDotnetCore.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly HelloAspDotnetCore.Models.HelloAspDotnetCoreContext _context;

        public DetailsModel(HelloAspDotnetCore.Models.HelloAspDotnetCoreContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
