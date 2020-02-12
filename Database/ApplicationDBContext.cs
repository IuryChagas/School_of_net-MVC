using Microsoft.EntityFrameworkCore;
using School_of_net_MVC.Database;
using School_of_net_MVC.Models;

namespace School_of_net_MVC.Database {
    public class ApplicationDBContext : DbContext {

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Categoria>  Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
            
        }
    }
}