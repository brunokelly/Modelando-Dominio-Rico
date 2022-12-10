using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        public Student(Name name, Email email, Document document, List<Subscription> subscription)
        {
            Name = name;
            Email = email;
            Document = document;
            _subscription = subscription;
        }

        public Name  Name { get; private set; }
        public Email Email { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }
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
