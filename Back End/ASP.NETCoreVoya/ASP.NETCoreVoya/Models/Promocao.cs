using System.ComponentModel.DataAnnotations;
namespace ASP.NETCoreVoya.Models
{
    public class Promocao
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço do pacote de viagem!")]
        public float Preco { get; set; }

    }
}

