using System.ComponentModel.DataAnnotations;

namespace ProjetoFilmes.Domains
{
    /// <summary>
    /// Classe responsável pelo modelo de usuários
    /// </summary>
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }

        // Define que a propriedade Email é obrigatória
        // Caso não seja informada, exibe a mensagem de erro
        [Required(ErrorMessage = "Informe o e-mail do usuário")]
        // Define uma pré-validação para e-mail
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Define que a propriedade Senha é obrigatória
        // Caso não seja informada, exibe a mensagem de erro
        [Required(ErrorMessage = "Informe a senha do usuário")]
        // Define uma pré-validação para senha
        [DataType(DataType.Password)]
        // Define a quantidade de caracteres da propriedade
        // Caso seja menor que 3 ou maior que 30, exibe a mensagem de erro
        [StringLength(30, MinimumLength = 3, ErrorMessage = "A senha deve conter de 3 a 30 caracteres")]
        public string Senha { get; set; }

        // Define que a propriedade Permissao é obrigatória
        // Caso não seja informada, exibe a mensagem de erro
        [Required(ErrorMessage = "Informe o tipo de permissão do usuário")]
        public string Permissao { get; set; }
    }
}
