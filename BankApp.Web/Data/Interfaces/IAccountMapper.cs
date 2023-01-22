using BankApp.Web.Data.Entity;
using BankApp.Web.Models;

namespace BankApp.Web.Data.Interfaces
{
    public interface IAccountMapper
    {
        public Account Map(AccountCreateModel model);
    }
}
