using Microsoft.EntityFrameworkCore;

namespace FinalProject.ASP.NETcoreMVC.Models
{
    public class QuarterlySalesDB : DbContext
    {
        public DbSet<QuarterlySales> sales { get; set; }

        public QuarterlySalesDB(DbContextOptions<QuarterlySalesDB> options)
            : base(options)
        {

        }
    }
}
