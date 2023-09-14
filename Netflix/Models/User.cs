using Netflix.Enum;

namespace Netflix.Models
{
    public class User
    {

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PaiementInfo { get; set; }

        public SubscriptionEnum Subscription { get; set; }  

        public Guid ProfilId { get; set; }
        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public User(string Firstname, string Email, string Address, string Phone, string PaiementInfo)
        {
            this.Firstname = Firstname;
            this.Email = Email;
            this.Address = Address;
            this.Phone = Phone;
            this.PaiementInfo = PaiementInfo;
        }

    }
}
