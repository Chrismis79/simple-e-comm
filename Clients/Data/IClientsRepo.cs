using System.Collections.Generic;
using Clients.Models;

namespace Clients.Data
{
    public interface IClientsRepo
    {
        IEnumerable<Client> GetAppCommands();
        Client GetCommandById(int id);

    }
}