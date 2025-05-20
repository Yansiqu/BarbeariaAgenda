using System.ComponentModel.DataAnnotations;

namespace BarbeariaAgenda.Models
{
    public class Agendamento
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        // Torna o tipo 'Barbeiro' anulável
        public Barbeiro? Barbeiro { get; set; }

        // Pode adicionar outras propriedades conforme necessário
    }
}
