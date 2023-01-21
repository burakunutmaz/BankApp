namespace BankApp.Web.Data.Entity
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public int AccountNumber { get; set; }

        public int UserId { get; set; }

        public User user { get; set; }
    }
}
