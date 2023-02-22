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
    public class DetailsModel : PageModel
    {
        private readonly MyWebApp.Data.MyWebAppContext _context;

        public DetailsModel(MyWebApp.Data.MyWebAppContext context)
        {
            _context = context;
        }

      public Buying Buying { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Buying == null)
            {
                return NotFound();
            }

            var buying = await _context.Buying.FirstOrDefaultAsync(m => m.ID == id);
            if (buying == null)
            {
                return NotFound();
            }
            else 
            {
                Buying = buying;
            }
            return Page();
        }
    }
}
