namespace School_of_net_MVC.Models {
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; } 
        // para definir o relacionamento entre produto com categoria.
        // Relação de 1 p 1: Ou seja, o produto tem uma categoria!!
    }
}