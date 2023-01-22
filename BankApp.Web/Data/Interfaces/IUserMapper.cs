using BankApp.Web.Data.Entity;
using BankApp.Web.Models;

namespace BankApp.Web.Data.Interfaces
{
    public interface IUserMapper
    {
        List<UserListModel> MapToListOfUserList(List<User> users);
        UserListModel MapToUserList(User user);
    }
}
