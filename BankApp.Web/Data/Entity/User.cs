namespace BankApp.Web.Data.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
