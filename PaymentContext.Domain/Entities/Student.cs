using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public Student(string firstName, string lastName, string email, string document, List<Subscription> subscription)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Document = document;
            _subscription = subscription;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Document { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions
        {
            get
            { 
                return _subscription.ToArray();
            }
        }
        public List<Subscription> _subscription;

        public void AddSubscription(Subscription subscription)
        {
            foreach(var sub in Subscriptions)
            {
                sub.Inactive();
            }

            _subscription.Add(subscription);
        }
    }
}
