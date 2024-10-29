using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMind.Models
{
    public class Aluno
    {
        //Dados para armazenar
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Matricula { get; set; }
        [Required]
        public string Serie { get; set; }
        [Phone]
        public string Telefone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        //Relacionamento com a classe Turma
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}