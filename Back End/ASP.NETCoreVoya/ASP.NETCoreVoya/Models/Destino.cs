using System.ComponentModel.DataAnnotations;
namespace ASP.NETCoreVoya.Models
{
    public class Destino
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Informe a forma de pagamento!")]
        public string Pagamento { get; set; }

        [Required(ErrorMessage = "Informe o destino da viagem!")]
        public string DestinoViagem { get; set; }

        [Required(ErrorMessage = "Informe a data de ida!")]
        public DateTime DataIda { get; set; }
        public string DataIdaFormatada => DataIda.ToString("yyyy-MM-dd");

        [Required(ErrorMessage = "Informe a data de volta!")]
        public DateTime DataVolta { get; set; }
        public string DataVoltaFormatada => DataVolta.ToString("yyyy-MM-dd");

    }
}