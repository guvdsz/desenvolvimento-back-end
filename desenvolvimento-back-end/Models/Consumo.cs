using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desenvolvimento_back_end.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A data é obrigatória.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "A quilometragem é obrigatória.")]
        public int Quilometragem { get; set; }

        [Required(ErrorMessage = "O tipo é obrigatório.")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "O veículo é obrigatório.")]
        public int  VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; } 

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Outros
    }
}
