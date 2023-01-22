using BankApp.Web.Data.Context;
using BankApp.Web.Data.Entity;
using BankApp.Web.Data.Interfaces;

namespace BankApp.Web.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BankContext _context;

        public UserRepository(BankContext context)
        {
            _context = context;
        }

        public User GetById(int id)
        {
            return _context.Users.SingleOrDefault(x => x.Id == id);
        }

        public void Create(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }

        public void Remove(User user)
        {
            _context.Set<User>().Remove(user);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Set<User>().ToList();
        }
    }
}
