using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.AspNetCore.NewDb.Models;

namespace EFGetStarted.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EFGetStarted.AspNetCore.NewDb.Models.BloggingContext _context;

        public IndexModel(EFGetStarted.AspNetCore.NewDb.Models.BloggingContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blogs.ToListAsync();
        }
    }
}
