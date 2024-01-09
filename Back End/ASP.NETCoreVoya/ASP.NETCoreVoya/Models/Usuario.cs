using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreVoya.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Nome completo obrigatório!")]
        [MaxLength(100, ErrorMessage = "Atenção: Ultrapassou a quantidade máxima de caracteres")]
        [MinLength(3, ErrorMessage = "Atenção: Registre o nome completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo CPF obrigatório!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Endereço obrigatório!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "E-mail obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone obrigatório!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Senha obrigatória!")]
        public string Senha { get; set; }
    }
}

