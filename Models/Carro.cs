using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volksdex_II.Models
{
    [Table("carros")]
    public class Carro
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nomeModelo")]
        [Required]
        public string NomeModelo { get; set; }

        [Column("anoLancamento")]
        [Required]
        public int AnoLancamento { get; set; }

        [Column("anoDescontinuado")]
        public int? AnoDescontinuado { get; set; }

        [Column("tipo")]
        [Required]
        public string Tipo { get; set; }

        [Column("motorizacao")]
        [Required]
        public string Motorizacao { get; set; }

        [Column("potencia")]
        public string Potencia { get; set; }

        [Column("torque")]
        public string Torque { get; set; }

        [Column("cambio")]
        [Required]
        public string Cambio { get; set; }

        [Column("popularidade")]
        public int? Popularidade { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("imagemUrl")]
        public string ImagemUrl { get; set; }
    }
}
