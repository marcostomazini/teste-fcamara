using System.ComponentModel.DataAnnotations;

namespace Angle_MVC6_Angular_Seed.Models.AgendaModels
{
    public class Produto : Entidade
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public double Preco { get; set; }
    }
}
