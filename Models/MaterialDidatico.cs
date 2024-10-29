using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMind.Models
{
    public class MaterialDidatico
    {
        //Dados para armazenar
        public int Id { get; set; }
        [Required]
        public string  Titulo { get; set; }

        [Required]
        public string TipoArquivo { get; set; }
        
        public string Descricao { get; set; }

        [Required]
        [FileExtensions(Extensions = "pdf, doc, docx, txt")] //Anotação para poder limitar os tipos de arquivos
        public IFormFile Arquivo { get; set; }
        public string  CaminhoArquivo { get; set; }
        public string  ConteudoTexto { get; set; }
        [Url]
        public string  Url { get; set; }

        //Relacionamento com Turma
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}