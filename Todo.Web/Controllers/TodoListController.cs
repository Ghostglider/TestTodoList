using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.Practices.Unity;
using System.Net;


namespace Todo.Web.Controllers
{
	[System.Web.Http.RoutePrefix("GestionTodo")]
    public class TodoListController : ApiController
    {
		private static List<Models.Todo> lstTodo = new List<Models.Todo>() ;
        // GET: TodoList
        public ActionResult Index()
        {
            return null;
        }

		[System.Web.Http.HttpPost]
		[System.Web.Http.Route("Ajout/{todoLabel}/{todoDesc}")]
		public IHttpActionResult AddTodo([FromUri] string todoLabel, [FromUri] string todoDesc)
		{
			Models.Todo myTodo = new Models.Todo();

			myTodo.Id = lstTodo.Count==0 ? 1 : lstTodo.Max(s => s.Id) + 1;
			myTodo.TodoLabel = todoLabel;
			myTodo.TodoDescription = todoDesc;
			myTodo.Traite = false;
			lstTodo.Add(myTodo);
			return Ok();
		}

		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("AfficheAll")]
		public IHttpActionResult GetAllTodo()
		{
			var result = lstTodo.ToArray();
			return Ok(result);
		}

		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("AfficheOne/{todoId:int}")]
		public IHttpActionResult GetTodoById(int todoId)
		{
			var result = lstTodo.FirstOrDefault(s => s.Id == todoId);
			return Ok(result);

		}

	
    }
}