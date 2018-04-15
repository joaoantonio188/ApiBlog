using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
            
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }

    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Titulo { get; set; }
        public string Data { get; set; }
        public float Nota { get; set; }
        public string ComentarioNota { get; set; }
        public string Texto { get; set; }
        public string DataTexto { get; set; }
        public string User { get; set; }
        public string Email { get; set; }
        public string DonoBlog { get; set; }    
    }
}
