using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMind.Models
{
    public class Turma
    {
        public int Id { get; set; }

        [Required] //Anotação para que o campo não seja nulo ou vazio
        public string Nome { get; set; }
        [Required]
        public string Secao { get; set; }
        [Required]
        public string Sala { get; set; }
        [Required]
        public string Disciplina { get; set; }
    }
}