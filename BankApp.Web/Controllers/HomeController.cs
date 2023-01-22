using Microsoft.AspNetCore.Mvc;
using BankApp.Web.Data.Context;
using BankApp.Web.Models;
using BankApp.Web.Data.Repositories;
using BankApp.Web.Data.Interfaces;

namespace BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserMapper _userMapper;

        public HomeController(
            IUserRepository userRepository, IUserMapper userMapper)
        {
            _userRepository = userRepository;
            _userMapper = userMapper;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_userRepository.GetAll()));
        }
    }
}
