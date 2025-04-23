using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desenvolvimento_back_end.Models
{
    [Table("Veículos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A placa é obrigatória.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O ano de fabricação é obrigatório.")]
        [Display(Name = "Ano de Fabricãção")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O ano do modelo é obrigatório.")]
        [Display(Name = "Ano do Modelo")]
        public string AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
