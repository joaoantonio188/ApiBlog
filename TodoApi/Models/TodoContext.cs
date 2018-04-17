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
        public DbSet<Blog> TodoItems { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options){ }

    }

    public class Blog
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


        public void AutoAtualizar(Blog blog)
        {
            this.Name = blog.Name;
            this.IsComplete = blog.IsComplete;
            this.TituloBlog = blog.TituloBlog;
            this.DataCriação = blog.DataCriação;
            this.Nota = blog.Nota;
            this.ComentarioNota = blog.ComentarioNota;
            this.Texto = blog.Texto;
            this.DataTexto = blog.DataTexto;
            this.User = blog.User;
            this.Email = blog.Email;
            this.DonoBlog = blog.DonoBlog;
         
        }
    }
}
