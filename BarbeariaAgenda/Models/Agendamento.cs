using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarbeariaAgenda.Models
{
    public class Agendamento
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        [Required]
        public int BarbeiroId { get; set; } 

        [ForeignKey("BarbeiroId")]
        public Barbeiro? Barbeiro { get; set; }
    }
}


