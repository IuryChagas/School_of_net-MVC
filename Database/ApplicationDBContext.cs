using Microsoft.EntityFrameworkCore;
namespace School_of_net_MVC.Database {
    public class ApplicationDBContext : DbContext {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
            
        }
    }
}