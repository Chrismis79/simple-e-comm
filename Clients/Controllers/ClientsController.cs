using System.Collections.Generic;
using Clients.Data;
using Clients.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clietns.Controllers
{
    //GET api/clients
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly MockClientsRepo _repository = new MockClientsRepo();
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAllCommands()
        {
            var clientInfo = _repository.GetAppCommands();
            return Ok(clientInfo);
        }

        //GET api/clients/id
        [HttpGet("{id}")]
        public ActionResult<Client> GetCommandByID(int id)
        {
            var clientInfo = _repository.GetCommandById(id);
            return Ok(clientInfo);
        }
    }
}
