using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HolidayWallet.Data;
using HolidayWallet.Models;

namespace HolidayWallet.Pages.Currencies
{
    public class IndexModel : PageModel
    {
        private readonly HolidayWallet.Data.ApplicationDbContext _context;

        public IndexModel(HolidayWallet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Currency> Currency { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Currency = await _context.Currency.ToListAsync();
        }
    }
}
