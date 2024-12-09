using HolidayWallet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HolidayWallet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Holiday> Holiday { get; set; } = default!;
        public DbSet<Expense> Expense { get; set; } = default!;
        public DbSet<Currency> Currency { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;


    }

}
