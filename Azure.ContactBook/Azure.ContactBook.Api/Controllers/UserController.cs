using Azure.ContactBook.Api.Data.Entities.ContactBook;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Azure.ContactBook.Api.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ContactBookContext _context;
        private readonly Infreastructure.Core.User user;
        public UserController(ContactBookContext context)
        {
            _context = context;
            user = new Infreastructure.Core.User(_context);
        }

        [HttpGet]
        [Route("api/usuarios")]
        public ActionResult Get()
        {
            return Ok(user.GetAll());
        }

        [HttpPost ("{id}")]
        [Route("api/usuario")]
        public ActionResult Get(int id)
        {
            return Ok(user.Get(id));
        }

        [HttpPost]
        [Route("api/registro/usuario")]
        public ActionResult Post([FromBody]User userBody)
        {
            return Ok(user.Insert(userBody));
        }

        [HttpPut]
        [Route("api/actualizar/usuario/{id}")]
        public ActionResult Put(int id, [FromBody] User userBody)
        {
            if (userBody.Id == id)
                return Ok(user.Update(userBody));
            return BadRequest();
        }

        [HttpDelete]
        [Route("api/eliminar/usuario/{id}")]
        public ActionResult Delete(int id)
        {
            if (id > 0)
                return Ok(user.Delete(id));
            return BadRequest();
        }
    }
}