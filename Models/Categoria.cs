namespace School_of_net_MVC.Models {
    public class Categoria {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString(){
            return $"Id: {this.Id}\nNome: {this.Nome}";
        }
    }
}