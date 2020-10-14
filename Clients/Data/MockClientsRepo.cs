using System.Collections.Generic;
using Clients.Models;

namespace Clients.Data
{
    public class MockClientsRepo : IClientsRepo
    {
        public IEnumerable<Client> GetAppCommands()
        {
            var client = new List<Client>
            {
                new Client{Id=0, name="Bob", age=22, gender="Male"},
                new Client{Id=2, name="Christine", age=40, gender="Female"},
                new Client{Id=3, name="Amanda", age=35, gender="Female"}
            };
            return client;
        }

        public Client GetCommandById(int id)
        {
            return new Client { Id = 0, name = "Bob", age = 22, gender = "Male" };
        }
    }
}