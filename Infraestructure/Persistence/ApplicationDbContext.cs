using Microsoft.EntityFrameworkCore;

namespace api_admision.Infraestructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
    }
}
