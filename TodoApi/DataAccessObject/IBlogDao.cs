using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.DataAccessObject
{
    public interface IBlogDao
    {
        void Inserir(Blog blog);
        void Deletar(long idItem, String DonoBLog);
        void Atualizar(Blog blog);
        Blog Obter(long idItem);
        List<Blog> ObterTodos();
    }
}
