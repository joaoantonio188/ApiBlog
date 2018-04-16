using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.DataAccessObject
{
    public interface IBlogDao
    {
        void Inserir(TodoItem item);
        void Deletar(int idItem);
        void Atualizar(TodoItem item);
        TodoItem Obter(int idItem);
        List<TodoItem> ObterTodos();
    }
}
