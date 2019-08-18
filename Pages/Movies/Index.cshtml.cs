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
    public class IndexModel : PageModel
    {
        private readonly HelloAspDotnetCore.Models.HelloAspDotnetCoreContext _context;

        public IndexModel(HelloAspDotnetCore.Models.HelloAspDotnetCoreContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}
