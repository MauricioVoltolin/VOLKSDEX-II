using System.ComponentModel.DataAnnotations.Schema;

namespace volksdex.Models
{
    [Table("carros")]
    public class Carro
    {
        public int Id { get; set; }
        public string NomeModelo { get; set; }
        public int AnoLancamento { get; set; }
        public int? AnoDescontinuado { get; set; }
        public string Tipo { get; set; }
        public string Motorizacao { get; set; }
        public string Potencia { get; set; }
        public string Torque { get; set; }
        public string Cambio { get; set; }
        public int Popularidade { get; set; }
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
    }
}
