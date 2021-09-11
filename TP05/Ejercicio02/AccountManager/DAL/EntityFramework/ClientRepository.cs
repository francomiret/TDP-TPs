using Ejercicio_02.FRCU.ISI.TdP.AccountManager;
using Ejercicio02.AccountManager.Domain;

namespace Ejercicio02.AccountManager.DAL.EntityFramework
{

    public class ClientRepository : Repository<Client, AccountManagerDbContext>, IClientRepository
    {

        public ClientRepository(AccountManagerDbContext pDbContext) : base(pDbContext)
        {

        }




    }
}
