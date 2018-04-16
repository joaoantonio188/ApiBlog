using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;


namespace TodoApi.DataAccessObject
{
    public class BlogDao : IBlogDao
    {
        private readonly TodoContext _bancoDeDados;

        public BlogDao(TodoContext bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public void Inserir(TodoItem item)
        {
            _bancoDeDados.TodoItems.Add(item);
            _bancoDeDados.SaveChanges();
        }

        public void Atualizar(TodoItem item)
        {
            _bancoDeDados.TodoItems.Update(item);
            _bancoDeDados.SaveChanges();
        }

        public void Deletar(int idItem)
        {
            var computador = _bancoDeDados.TodoItems.Find(idItem);
            _bancoDeDados.TodoItems.Remove(computador);
            _bancoDeDados.SaveChanges();
        }

        public TodoItem Obter(int idItem)
        {
            return _bancoDeDados.TodoItems.Find(idItem);
        }

        public List<TodoItem> ObterTodos()
        {
            return _bancoDeDados.TodoItems.ToList();
        }
    }
}
