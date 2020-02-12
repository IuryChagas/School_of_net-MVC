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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseLazyLoadingProxies();
        }

        // Customização de Tabela com Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //  para definir um novo nome para tabela!
            modelBuilder.Entity<Produto>().ToTable("NovoNomeDaTabela");

            // Para tornar obrigatório colocar no nome do produto,
            //não sendo mais possível enviar um nome de produto vazio no BD.
            //modelBuilder.Entity<Produto>().Property(p => p.Nome).IsRequired();

            // Para definir uma quantidade maxima de caracteres que o nome do produto terá! até 100 caracteres!
            modelBuilder.Entity<Produto>().Property(p => p.Nome).HasMaxLength(100);
        }
    }
}