using System.Collections.Generic;
using Ejercicio02.AccountManager.Domain;

namespace Ejercicio02.AccountManager.DAL
{
    public interface IAccountRepository : IRepository<Account>
    {

        IEnumerable<Account> GetOverdrawnAccounts();

    }
}
