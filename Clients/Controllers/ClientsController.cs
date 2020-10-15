using System.Collections.Generic;
using Clients.Data;
using Clients.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Clients.Controllers
{
    //GET api/clients
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientsRepo _repository;

        public ClientsController(IClientsRepo repository)
        {
            _repository = repository;
        }


        //private readonly MockClientsRepo _repository = new MockClientsRepo();
        [EnableCors("Policy")]
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAllCommands()
        {
            var clientInfo = _repository.GetAppCommands();
            return Ok(clientInfo);
        }

        //GET api/clients/id
        [EnableCors("PolicyId")]
        [HttpGet("{id}")]
        public ActionResult<Client> GetCommandByID(int id)
        {
            var clientInfo = _repository.GetCommandById(id);
            return Ok(clientInfo);
        }
    }
}
