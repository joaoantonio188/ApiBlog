using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options){ }

    }

    public class TodoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdItem { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string TituloBlog { get; set; }
        public string DataCriação { get; set; }
        public float Nota { get; set; }
        public string ComentarioNota { get; set; }
        public string Texto { get; set; }
        public string DataTexto { get; set; }
        public string User { get; set; }
        public string Email { get; set; }
        public string DonoBlog { get; set; }


        public void AutoAtualizar(TodoItem item)
        {
            this.Name = item.Name;
            this.IsComplete = item.IsComplete;
            this.TituloBlog = item.TituloBlog;
            this.DataCriação = item.DataCriação;
            this.Nota = item.Nota;
            this.ComentarioNota = item.ComentarioNota;
            this.Texto = item.Texto;
            this.DataTexto = item.DataTexto;
            this.User = item.User;
            this.Email = item.Email;
            this.DonoBlog = item.DonoBlog;
         
        }
    }
}
