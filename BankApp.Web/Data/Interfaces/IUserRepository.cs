using BankApp.Web.Data.Entity;

namespace BankApp.Web.Data.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);

        void Create(User user);
    }
}
