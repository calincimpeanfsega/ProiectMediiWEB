using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;
using MyWebApp.Models;

namespace MyWebApp.Pages.Admins
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public bool MessageSent { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // code to send email goes here
            MessageSent = true;
        }
    }
}
