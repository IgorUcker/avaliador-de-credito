using System.ComponentModel.DataAnnotations.Schema;

namespace AvaliadorDeCredito.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public double? Salario { get; set; }
        [NotMapped]
        public int? Idade { get; set; }
        [NotMapped]
        public string? Situacao { get; set; }
        [NotMapped]
        public string? Limite { get; set; }
    }
}
