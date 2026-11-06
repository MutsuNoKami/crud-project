using crud_project.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_project.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options){}
        
        DbSet<Expense> Expenses {get;set;}

    }
}