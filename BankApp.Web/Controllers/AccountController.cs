using BankApp.Web.Data.Context;
using BankApp.Web.Data.Entity;
using BankApp.Web.Data.Interfaces;
using BankApp.Web.Data.Repositories;
using BankApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly IGenericRepository<Account> _accountRepository;
        private readonly IGenericRepository<User> _userRepository;

        public AccountController(IGenericRepository<Account> accountRepository,
            IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
            _accountRepository = accountRepository;
        }

        public IActionResult Create(int id)
        {
            var userInfo = _userRepository.GetById(id);
            return View(new UserListModel
            {
                Id = userInfo.Id,
                Name = userInfo.Name,
                Surname = userInfo.Surname
            });
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {

            _accountRepository.Create(new Account
            {
                AccountNumber = model.AccountNumber,
                Balance = model.Balance,
                UserId = model.UserId
            });
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult GetByUserId(int userId)
        {
            var query = _accountRepository.GetQueryable();
            var accounts = query.Where(x => x.UserId == userId).ToList();
            
            var user = _userRepository.GetById(userId);

            ViewBag.FullName = user.Name + " " + user.Surname;

            var list = new List<AccountListModel>();
            foreach (var item in accounts)
            {
                list.Add(new()
                {
                    AccountNumber = item.AccountNumber,
                    Balance = item.Balance,
                    UserId = item.UserId,
                });
            }

            return View(list);
        }
    }
}
