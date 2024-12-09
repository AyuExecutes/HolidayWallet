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
        private readonly HolidayWallet.Data.ApplicationDbContext _context;

        public CreateModel(HolidayWallet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CurrencyId"] = new SelectList(_context.Set<Currency>(), "Id", "Id");
        ViewData["HolidayId"] = new SelectList(_context.Holiday, "Id", "Id");
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
