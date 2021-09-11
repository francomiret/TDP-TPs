using AutoMapper;
using System.Collections.Generic;
using Ejercicio02.AccountManager.DAL;
using Ejercicio02.AccountManager.DAL.EntityFramework;
using Ejercicio02.AccountManager.Domain;
using Ejercicio02.AccountManager.IO;
using System.Linq;
using System;

namespace Ejercicio02.AccountManager
{
    public class Bank
    {

        private static readonly IMapper cMapper;

        static Bank()
        {
            var mConfiguration = new MapperConfiguration(pConfiguration =>
            {
                pConfiguration.CreateMap<AccountMovement, AccountMovementDTO>();
            });

            cMapper = mConfiguration.CreateMapper();
        }

        /// <summary>
        /// Este metodo busca un cliente en la BDD
        /// </summary>
        /// <param name="pClienteId"></param> corresponde al id del Cliente
        /// <returns></returns>
        public ClientDTO BuscarCliente(int pClienteId)
        {
            using var bDbContext = new AccountManagerDbContext();
            using IUnitOfWork bUoW = new UnitOfWork(bDbContext);
            var cliente = bUoW.ClientRepository.Get(pClienteId);
            if (cliente != null)
            {
                ClientDTO clienteDTO = new ClientDTO(cliente);
                return clienteDTO;
            }
            else
            {
                throw new System.Exception();
            }
        }

        /// <summary>
        /// Este metodo registra movimientos en la BDD (acreditar y debitar)
        /// </summary>
        /// <param name="pClienteId"></param> corresponde al id del cliente
        /// <param name="pCuentaId"></param> corresponde al id de la cuenta
        /// <param name="pFecha"></param> corredponde a la fecha del movimiento
        /// <param name="pDescription"></param> correponde a una descripcion
        /// <param name="pAmount"></param> corresponde al monto del moviento
        public void RegistrarMovimiento(int pClienteId,int pCuentaId, DateTime pFecha, string pDescription, double pAmount)
        {
            using var bDbContext = new AccountManagerDbContext();
            using IUnitOfWork bUoW = new UnitOfWork(bDbContext);
            var cliente = bUoW.ClientRepository.Get(pClienteId);
            if (cliente != null)
            {
                var cuenta = bUoW.AccountRepository.Get(pCuentaId);
                var moviemiento = new AccountMovement()
                {
                    Date = pFecha,
                    Description = pDescription,
                    Amount = pAmount
                };
                cuenta.Movements.Add(moviemiento);
            }
            else
            {
                throw new SystemException();
            }
            bUoW.Complete();
        }

        /// <summary>
        /// Este metodo agrega un cliente a la BDD
        /// </summary>
        /// <param name="pFirstName"></param> corresponde al nombre del cliente
        /// <param name="pLastName"></param> corresponde al apellido del cliente
        /// <param name="pDocument"></param> corresponde al documento del cliente
        public void CrearCliente(string pFirstName, string pLastName, string pDocument)
        {
            using var bDbContext = new AccountManagerDbContext();
            using IUnitOfWork bUoW = new UnitOfWork(bDbContext);
            var cliente = new Client()
            {

                FirstName = pFirstName,
                LastName = pLastName,
                Document = new Document()
                {
                    Number = pDocument,
                    Type = DocumentType.DNI
                }
            };
            bUoW.ClientRepository.Add(cliente);
            bUoW.Complete();
        }

        /// <summary>
        /// Este metodo crea una cuenta en la BDD 
        /// </summary>
        /// <param name="pClienteId"></param> corresponde al id del cliente
        /// <param name="pAccountName"></param> corresponde al nombre de la cuenta
        /// <param name="pOverDraftLimit"></param> corresponde al limite descubierto
        public void CrearCuenta(int pClienteId, string pAccountName, double pOverDraftLimit)
        {
            using var bDbContext = new AccountManagerDbContext();
            using IUnitOfWork bUoW = new UnitOfWork(bDbContext);
            var cliente = bUoW.ClientRepository.Get(pClienteId);
            if (cliente.Accounts.Where(t => t.Name == pAccountName).Count() != 0)
            {
                throw new System.Exception();
            }
            else
            {
                var cuenta = new Account()
                {
                    Name = pAccountName,
                    OverdraftLimit = pOverDraftLimit
                };
                cliente.Accounts.Add(cuenta);
            }

            bUoW.Complete();
        }

        /// <summary>
        /// este metodo devuelve todas las cuentas de un cliente
        /// </summary>
        /// <param name="pClientId"></param> corresponde al id del cliente
        /// <returns></returns>
        public IEnumerable<AccountDTO> GetClientAccounts(int pClientId)
        {
            IList<AccountDTO> mAccounts;

            using (var bDbContext = new AccountManagerDbContext())
            {
                using (IUnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    var bClient = bUoW.ClientRepository.Get(pClientId);

                    if (bClient != null && bClient.Accounts.Count > 0)
                    {
                        mAccounts = new List<AccountDTO>(bClient.Accounts.Count);

                        foreach (var bAccount in bClient.Accounts)
                        {
                            mAccounts.Add(new AccountDTO
                            {
                                Id = bAccount.Id,
                                Name = bAccount.Name,
                                Balance = bAccount.GetBalance(),
                                OverDraftLimit = bAccount.OverdraftLimit
                            });
                        }
                    }
                    else
                    {
                        mAccounts = new List<AccountDTO>();
                    }
                }
            }

            return mAccounts;
        }

        /// <summary>
        /// Este metodo devuelve todos los movimientos de una cuenta
        /// </summary>
        /// <param name="pAccountId"></param>
        /// <returns></returns>
        public IEnumerable<AccountMovementDTO> GetAccountMovements(int pAccountId)
        {
            IList<AccountMovementDTO> mAccountMovements;
            using (var bDbContext = new AccountManagerDbContext())
            {
                using IUnitOfWork bUoW = new UnitOfWork(bDbContext);
                var bAccount = bUoW.AccountRepository.Get(pAccountId);

                if (bAccount != null && bAccount.Movements.Count > 0)
                {
                    mAccountMovements = cMapper.Map<IList<AccountMovementDTO>>(bAccount.Movements);
                }
                else
                {
                    mAccountMovements = new List<AccountMovementDTO>();
                }
            }
            return mAccountMovements;
        }

        /// <summary>
        /// Este metodo devuelve los ultimos N moviemitentos de una cuenta
        /// </summary>
        /// <param name="pCuentaId"></param> corresponde al id de la cuenta
        /// <param name="pCount"></param> corresponde a la cantidad de movimientos que se desea ver
        /// <returns></returns>
        public IEnumerable<AccountMovementDTO> UltimosNMovimientos(int pCuentaId, int pCount)
        {
            using var bDbContext = new AccountManagerDbContext();
            using IUnitOfWork bUoW = new UnitOfWork(bDbContext);

            var bAccount = bUoW.AccountRepository.Get(pCuentaId);
            var lastNMovements = bAccount.GetLastMovements(pCount);
            IList<AccountMovementDTO> mAccounts = new List<AccountMovementDTO>();
            foreach (var bMovement in lastNMovements)
            {
                mAccounts.Add(new AccountMovementDTO
                {
                    Id = bMovement.Id,
                    Date= bMovement.Date,
                    Description = bMovement.Description,
                    Amount = bMovement.Amount
                });
            }          
            return mAccounts;

        }

        /// <summary>
        /// Este metodo devuelve todas las cuentas con sobregiro es decir
        /// cuentas que tienen  saldo negativo y superaron el limite de descubierto
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountDTO> CuentasConSobregiro()
        {
            using var bDbContext = new AccountManagerDbContext();
            using IUnitOfWork bUoW = new UnitOfWork(bDbContext);
             
            var listaCuentas = bUoW.AccountRepository.GetOverdrawnAccounts();
            IList<AccountDTO> mAccounts = new List<AccountDTO>();
            foreach (var bAccount in listaCuentas)
                {
                mAccounts.Add(new AccountDTO
                    {
                        Id = bAccount.Id,
                        Name = bAccount.Name,
                        Balance = bAccount.GetBalance(),
                        OverDraftLimit = bAccount.OverdraftLimit
                    });
                }
            return mAccounts;
        }

    }
}
