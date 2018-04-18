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
        /// <param name="blog">Objeto computador</param>
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
        public void Deletar(long idItem, String DonoBlog)
        {

            if (DonoBlog == "joao")
            {
                _blogDAO.Deletar(idItem, DonoBlog);
            }
        }

        /// <summary>
        /// Inserir um novo computador
        /// </summary>
        /// <param name="blog">Obejto no computador</param>
        public void Inserir(Blog blog)
        {
            var todosItensDoBlog = _blogDAO.ObterTodos();
            todosItensDoBlog.ForEach(_blog =>
            {
                if (_blog.Email == blog.Email)
                {
                    throw new System.ArgumentException("Email existente");
                }                  
                
            });

            _blogDAO.Inserir(blog);

        }

        /// <summary>
        /// Obter um computador
        /// </summary>
        /// <param name="blog">Identificador do computador</param>
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
