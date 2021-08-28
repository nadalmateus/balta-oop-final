namespace Balta.SubscriptionContext
{
    using SharedContext;

    public class User : Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}