using BankApp.Web.Data.Entity;

namespace BankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        void Create(Account account);
    }
}
