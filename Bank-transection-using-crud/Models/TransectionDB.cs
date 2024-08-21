using Microsoft.EntityFrameworkCore;

namespace Bank_transection_using_crud.Models
{
    public class TransectionDB:DbContext
    {
        public TransectionDB(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Transection> Transections { get; set; }
    }
}