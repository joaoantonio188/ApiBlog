using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using Microsoft.AspNetCore.Mvc.Formatters;


namespace TodoApi.DataAccessObject
{
    public class BlogDao : IBlogDao
    {
        private readonly TodoContext _bancoDeDados;

        public BlogDao(TodoContext bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public void Inserir(Blog blog)
        {
            _bancoDeDados.TodoItems.Add(blog);
            _bancoDeDados.SaveChanges();
        }

        public void Atualizar(Blog blog)
        {
            _bancoDeDados.TodoItems.Update(blog);
            _bancoDeDados.SaveChanges();
        }

        public void Deletar(long idItem, String DonoBlog)
        {
            var ItensBlog = _bancoDeDados.TodoItems.Find(idItem);
            _bancoDeDados.TodoItems.Remove(ItensBlog);
            _bancoDeDados.SaveChanges();
        }

        public Blog Obter(long idItem)
        {
            return _bancoDeDados.TodoItems.Find(idItem);
        }

        public List<Blog> ObterTodos()
        {
            return _bancoDeDados.TodoItems.ToList();
            
        }
    }
}
