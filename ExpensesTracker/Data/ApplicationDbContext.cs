using ExpensesTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpensesTracker.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ExpenseModel> ExpenseTracker { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseModel>().HasData(
                new ExpenseModel { ET_Id = 1, ET_Amount=20 ,ET_Date= new DateOnly(2024, 02, 25),ET_Expense_Name="test",ET_RefundYN='N' },
                new ExpenseModel { ET_Id = 2, ET_Amount = 80, ET_Date = new DateOnly(2024, 01, 15), ET_Expense_Name = "test", ET_RefundYN = 'N' },
                new ExpenseModel { ET_Id = 3, ET_Amount = 50, ET_Date = new DateOnly(2024, 01, 22), ET_Expense_Name = "test", ET_RefundYN = 'Y' },
                new ExpenseModel { ET_Id = 4, ET_Amount = 30, ET_Date = new DateOnly(2024, 02, 28), ET_Expense_Name = "test", ET_RefundYN = 'Y' }
                );
        }
    }
}
