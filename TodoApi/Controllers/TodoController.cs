using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using BusinessLayer.Interface;

namespace TodoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly IBlogBll _blogBll;

        public TodoController(IBlogBll blogBll)
        {
            _blogBll = blogBll;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Json(_blogBll.ObterTodos());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet("{idItem}")]
        public IActionResult Get(long idItem)
        {

            try
            {
                return Json(_blogBll.Obter(idItem));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Blog item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _blogBll.Inserir(item);
                    return StatusCode(201);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{idItem}")]
        public IActionResult Put(long idItem, [FromBody]Blog blog)
        {
            try
            {
                _blogBll.Atualizar(idItem, blog);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{idItem}")]
        public IActionResult Delete(long idItem, [FromHeader] String DonoBlog )
        {
            try
            {
                _blogBll.Deletar(idItem, DonoBlog);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}