using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.Posts
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly RazorPagesApp.Data.RazorPagesPostContext _context;

        public IndexModel(RazorPagesApp.Data.RazorPagesPostContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get; set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
