using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIDeneme.Business.Abstract;
using WebAPIDeneme.Business.Constants;
using WebAPIDeneme.Models;

namespace WebAPIDeneme.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ToDoController : Controller
    {
        private ITodo _todo;
        public ToDoController(ITodo todo)
        {
            _todo = todo;
        }

        [HttpGet("getListAllToDo")]
        public IActionResult GetListAllToDo()
        {
            var result = _todo.GetListAllToDo();
            if (result!=null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(Messages.ErrorGetListAllToDo);
            }
        }

        [HttpGet("getListCompletedToDo")]
        public IActionResult GetListCompletedToDo()
        {
            var result = _todo.GetListCompletedToDo();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(Messages.ErrorGetListCompletedToDo);
            }
        }

        [HttpGet("getListUncompletedToDo")]
        public IActionResult GetListUncompletedToDo()
        {
            var result = _todo.GetListUncompletedToDo();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(Messages.ErrorGetListUncompletedToDo);
            }
        }

        [HttpGet("getToDo")]
        public IActionResult GetTodo(int id)
        {
            var result = _todo.GetToDo(id);
            if (result.Message == "Başarılı")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("AddNewToDo")]
        public IActionResult AddNewTodo([FromForm] ToDoModel toDoModel)
        {
            var result = _todo.AddNewTodo(toDoModel);
            if (result == "Başarılı")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("UpdateToDo")]
        public IActionResult UpdateToDo([FromForm] ToDoModel toDoModel)
        {
            var result = _todo.UpdateToDo(toDoModel);
            if (result=="Başarılı")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
