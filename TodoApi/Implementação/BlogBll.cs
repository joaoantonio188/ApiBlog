using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using BusinessLayer.Interface;
using TodoApi.DataAccessObject;

namespace TodoApi.Implementação
{
    public class BlogBll : IBlogBll
    {

        public readonly IBlogDao _blogDAO;

        public BlogBll(IBlogDao blogDao)
        {
            _blogDAO = blogDao;
        }

        /// <summary>
        /// Atualizar computador
        /// </summary>
        /// <param name="idItem">Identificador do computador</param>
        /// <param name="item">Objeto computador</param>
        public void Atualizar(long idItem, Blog blog)
        {
            var idItemAtual = _blogDAO.Obter(idItem);
            idItemAtual.AutoAtualizar(blog);
            _blogDAO.Atualizar(idItemAtual);
        }

        /// <summary>
        /// Excluir um computador
        /// </summary>
        /// <param name="idItem">Identificador do computador</param>
        public void Deletar(long idItem)
        {
            _blogDAO.Deletar(idItem);
        }

        /// <summary>
        /// Inserir um novo computador
        /// </summary>
        /// <param name="item">Obejto no computador</param>
        public void Inserir(Blog blog)
        {
            _blogDAO.Inserir(blog);
        }

        /// <summary>
        /// Obter um computador
        /// </summary>
        /// <param name="idItem">Identificador do computador</param>
        /// <returns>Retorna computador encontrado</returns>
        public Blog Obter(long idItem)
        {
            return _blogDAO.Obter(idItem);
        }

        /// <summary>
        /// Obtem todos os computadores
        /// </summary>
        /// <returns>Retorna uma lista de computadores</returns>
        public List<Blog> ObterTodos()
        {
            return _blogDAO.ObterTodos();
        }
    }
   
  
       
    
}
