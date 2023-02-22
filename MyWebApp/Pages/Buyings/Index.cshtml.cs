
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;
using MyWebApp.Models;

namespace MyWebApp.Pages.Buyings
{
    public class IndexModel : PageModel
    {
        private readonly MyWebApp.Data.MyWebAppContext _context;

        public IndexModel(MyWebApp.Data.MyWebAppContext context)
        {
            _context = context;
        }

        public IList<Buying> Buying { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Buying != null)
            {
                Buying = await _context.Buying
                .Include(b => b.Client)
                .Include(b => b.Product).ToListAsync();
            }
        }
    }
}
