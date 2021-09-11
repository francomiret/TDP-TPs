using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Ejercicio02.AccountManager.Domain
{
    public class Account
    {
        public Account()
        {

        }
        public Account(int pId, string pNombre, double pLimite)
        {
            Id = pId;
            Name = pNombre;
            OverdraftLimit = pLimite;
        }

        public int Id { get; set; }

        public String Name { get; set; }

        public double OverdraftLimit { get; set; }
            
        public virtual IList<AccountMovement> Movements { get; set; } = new List<AccountMovement>();

        public double GetBalance()
        {
            return (from Movements in this.Movements select Movements.Amount).Sum();
        }

        public IEnumerable<AccountMovement> GetLastMovements(int pCount = 7)
        {
            return this.Movements.OrderByDescending(pMovement => pMovement.Date).Take(pCount);
        }

    }
}
