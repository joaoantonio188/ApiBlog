using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace BusinessLayer.Interface
{ 

    public interface IBlogBll
    {
        void Inserir(Blog blog);
        void Deletar(long idItem, String DonoBlog);
        void Atualizar(long idItem, Blog blog);
        Blog Obter(long idItem);
        List<Blog> ObterTodos();
    }
}
