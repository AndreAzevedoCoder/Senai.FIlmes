using System.ComponentModel.DataAnnotations;

namespace ProjetoFilmes.Domains
{
    public partial class Filmes
    {
        public int IdFilme { get; set; }

        // Define que a propriedade Titulo é obrigatória
        // Caso não seja informada, exibe a mensagem de erro
        [Required(ErrorMessage = "Informe o título do filme")]
        public string Titulo { get; set; }

        public int? IdGenero { get; set; }

        public Generos IdGeneroNavigation { get; set; }
    }
}
