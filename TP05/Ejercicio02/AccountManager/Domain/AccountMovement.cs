using System;

namespace Ejercicio02.AccountManager.Domain
{
    public class AccountMovement
    {
        public AccountMovement()
        {

        }
        public AccountMovement(int pId, DateTime pDate, string pDescripcion, double pAmount)
        {
            Id = pId;
            Date = pDate;
            Description = pDescripcion;
            Amount = pAmount;
        }
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public double Amount { get; set; }

    }
}
