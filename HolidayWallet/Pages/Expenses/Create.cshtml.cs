using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HolidayWallet.Data;
using HolidayWallet.Models;

namespace HolidayWallet.Pages.Expenses
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int HolidayId { get; set; }

        public IActionResult OnGet()
        {
            Holiday? holiday = _context.Holiday.FirstOrDefault(h => h.Id == HolidayId);

            ViewData["HolidayName"] = holiday?.Destination;
         
            ViewData["CurrencyList"] = new SelectList(_context.Set<Currency>(), "Id", "FromCode");
            ViewData["HolidayId"] = holiday?.Id;

            return Page();
        }

        [BindProperty]
        public Expense Expense { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Expense.Add(Expense);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
