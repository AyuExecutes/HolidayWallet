using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HolidayWallet.Data;
using HolidayWallet.Models;

namespace HolidayWallet.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly HolidayWallet.Data.ApplicationDbContext _context;

        public IndexModel(HolidayWallet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
