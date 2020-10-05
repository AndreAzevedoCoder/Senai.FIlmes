using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFilmes.Domains
{
    public partial class Generos
    {
        public Generos()
        {
            Filmes = new HashSet<Filmes>();
        }

        public int IdGenero { get; set; }

        // Define que a propriedade Nome é obrigatória
        // Caso não seja informada, exibe a mensagem de erro
        [Required(ErrorMessage = "Informe o nome do gênero")]
        public string Nome { get; set; }

        public ICollection<Filmes> Filmes { get; set; }
    }
}
