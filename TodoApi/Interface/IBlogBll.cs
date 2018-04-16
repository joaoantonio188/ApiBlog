using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace BusinessLayer.Interface
{ 

    public interface IBlogBll
    {
        void Inserir(TodoItem item);
        void Deletar(int idItem);
        void Atualizar(int idItem, TodoItem item);
        TodoItem Obter(int idItem);
        List<TodoItem> ObterTodos();
    }
}
