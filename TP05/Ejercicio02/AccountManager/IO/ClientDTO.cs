using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.AccountManager.Domain;

namespace Ejercicio02.AccountManager.IO
{
    public class ClientDTO
    {
        public readonly int Id;
        public readonly string firstName;
        public readonly string lastName;

        public ClientDTO(Client cliente)
        {
            Id = cliente.Id;
            firstName = cliente.FirstName;
            lastName = cliente.LastName;        
        }
     
    }
}
