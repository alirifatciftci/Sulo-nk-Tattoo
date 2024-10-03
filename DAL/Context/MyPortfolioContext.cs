using Microsoft.EntityFrameworkCore;
using süleyman.DAL.Entities;


namespace süleyman.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=OLDDRA\\SQLEXPRESS;Initial Catalog=MyPortfolioDb;Integrated Security=true;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    
        




    }
}
