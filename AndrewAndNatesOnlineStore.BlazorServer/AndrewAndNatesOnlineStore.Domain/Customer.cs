using System.Security.Principal;

namespace AndrewAndNatesOnlineStore.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
        public DateTime CustomerJoinDate { get; set; }
        public bool PremiumMember { get; set; }
        public Shoppingcart Shopppingcart { get; set; }

    }
}