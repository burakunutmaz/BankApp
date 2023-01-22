using BankApp.Web.Data.Entity;
using BankApp.Web.Data.Interfaces;
using BankApp.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Web.Mapping
{
    public class AccountMapper : IAccountMapper
    {
        public Account Map(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                UserId = model.UserId,
                Balance = model.Balance
            };
        }
    }
}
