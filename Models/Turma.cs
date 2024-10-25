using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMind.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Secao { get; set; }
        public string Sala { get; set; }
        public string Disciplina { get; set; }
    }
}