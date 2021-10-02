using System.ComponentModel.DataAnnotations;

namespace usingScaffolding.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Especie { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
