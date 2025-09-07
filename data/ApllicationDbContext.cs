using crud_opration.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_opration.data
{
    public class ApllicationdbContext : DbContext
    {
        public ApllicationdbContext(DbContextOptions<ApllicationdbContext>options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        }
}
