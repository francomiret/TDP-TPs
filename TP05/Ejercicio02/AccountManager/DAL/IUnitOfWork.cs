using System;

namespace Ejercicio02.AccountManager.DAL
{
    public interface IUnitOfWork : IDisposable
    {

        IAccountRepository AccountRepository { get; }

        IClientRepository ClientRepository { get; }

        void Complete();

    }
}
