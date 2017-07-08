using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;
using ToDo.Repository;
using ToDo.Data;
using ToDo.Responses;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ToDoItemsController : Controller
    {
        IRepository<ToDoItem> db;
        public ToDoItemsController(ToDoContext toDoContext)
        {
            db = new ToDoRepository<ToDoItem>(toDoContext);
        }
        // GET: api/values
        [HttpGet]
        public ApiResponse<IEnumerable<ToDoItem>> Get()
        {
            return new ApiResponse<IEnumerable<ToDoItem>>("1.0", "getAll", db.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ApiResponse<ToDoItem> Get(long id)
        {
            return new ApiResponse<ToDoItem>("1.0", "getById", db.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]ToDoItem itemToAdd)
        {
            db.Create(itemToAdd);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ToDoItem itemToAdd)
        {
            db.Update(itemToAdd);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Delete(id);
        }
    }
}
