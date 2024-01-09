using Learn_Net_Core_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Learn_Net_Core_Web.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
