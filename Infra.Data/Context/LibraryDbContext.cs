using System.Security.Cryptography.X509Certificates;
using JLRP.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
