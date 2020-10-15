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
                new Client{Id=0, name="Bob", age=22, gender="Male", company="NAPA", email="myemail@gmail.com", phone="999-090-3824"},
                new Client{Id=1, name="Christine", age=40, gender="Female", company="Lambda", email="chrisemail@gmail.com", phone="918-045-4476"},
                new Client{Id=2, name="Amanda", age=35, gender="Female", company="Amazon", email="amandamail@gmail.com", phone="232-443-4566"}
            };
            return client;
        }

        public Client GetCommandById(int id)
        {
            Client client = id switch
            {
                0 => new Client { Id = 0, name = "Bob", age = 22, gender = "Male", company = "NAPA", email = "myemail@gmail.com", phone = "999-090-3824" },
                1 => new Client { Id = 1, name = "Christine", age = 40, gender = "Female", company = "Lambda", email = "chrisemail@gmail.com", phone = "918-045-4476" },
                2 => new Client { Id = 2, name = "Amanda", age = 35, gender = "Female", company = "Amazon", email = "amandamail@gmail.com", phone = "232-443-4566" },
            };
            return client;
        }

    }
}