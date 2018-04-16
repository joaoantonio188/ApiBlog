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
        public void Atualizar(int idItem, TodoItem item)
        {
            var computadorAtual = _blogDAO.Obter(idItem);
            computadorAtual.AutoAtualizar(item);
            _blogDAO.Atualizar(computadorAtual);
        }

        /// <summary>
        /// Excluir um computador
        /// </summary>
        /// <param name="idItem">Identificador do computador</param>
        public void Deletar(int idItem)
        {
            _blogDAO.Deletar(idItem);
        }

        /// <summary>
        /// Inserir um novo computador
        /// </summary>
        /// <param name="item">Obejto no computador</param>
        public void Inserir(TodoItem item)
        {
            _blogDAO.Inserir(item);
        }

        /// <summary>
        /// Obter um computador
        /// </summary>
        /// <param name="idItem">Identificador do computador</param>
        /// <returns>Retorna computador encontrado</returns>
        public TodoItem Obter(int idItem)
        {
            return _blogDAO.Obter(idItem);
        }

        /// <summary>
        /// Obtem todos os computadores
        /// </summary>
        /// <returns>Retorna uma lista de computadores</returns>
        public List<TodoItem> ObterTodos()
        {
            return _blogDAO.ObterTodos();
        }
    }
   
  
       
    
}
