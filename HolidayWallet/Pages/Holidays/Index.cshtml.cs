using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HolidayWallet.Data;
using HolidayWallet.Models;

namespace HolidayWallet.Pages.Holidays
{
    public class IndexModel : PageModel
    {
        private readonly HolidayWallet.Data.ApplicationDbContext _context;

        public IndexModel(HolidayWallet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Holiday> Holiday { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Holiday = await _context.Holiday.ToListAsync();
        }
    }
}
