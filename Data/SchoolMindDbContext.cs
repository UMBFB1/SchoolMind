using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolMind.Models;

namespace SchoolMind.Data
{
    public class SchoolMindDbContext : DbContext{
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<MaterialDidatico> MateriaisDidaticos { get; set; }
        public SchoolMindDbContext(DbContextOptions<SchoolMindDbContext> options)
            : base(options){
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }
    }
}