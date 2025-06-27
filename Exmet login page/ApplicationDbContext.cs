using Microsoft.EntityFrameworkCore;       // ✅ for DbContext, DbSet
using Exmet_login_page;                    // ✅ your namespace that contains the User class


public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=JAYKISHAN-PC\\MSSQLSERVER01;Database=users;Integrated Security=True;TrustServerCertificate=True;");
    }
}
