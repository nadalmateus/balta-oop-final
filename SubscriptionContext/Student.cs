using Balta.SharedContext;
using Balta.SubscriptionContext;

namespace SubscriptionContext
{
    public class Student : Base
    {
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}