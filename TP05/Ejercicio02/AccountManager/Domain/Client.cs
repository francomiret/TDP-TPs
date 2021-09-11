
using System;
using System.Collections.Generic;

namespace Ejercicio02.AccountManager.Domain
{
    public class Client
    {
        public Client(int pId, Document pDocument, string pFirstName, string pLastName)
        {
            Id = pId;
            Document = pDocument;
            FirstName = pFirstName;
            LastName = pLastName;
        }
        public Client()
        {

        }
        public int Id { get; set; }

        public Document Document { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public virtual IList<Account> Accounts { get; set; } = new List<Account>();

    }
}
