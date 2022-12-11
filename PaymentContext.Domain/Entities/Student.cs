using Flunt.Br;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        public Student(Name name, Email email, Document document)
        {
            Name = name;
            Email = email;
            Document = document;
            _subscription = new List<Subscription>();

            AddNotifications(name, email, document);
        }

        public Name Name { get; private set; }
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
            AddNotifications(new Contract()
                 .Requires()
                    .IsFalse(AnySubscriptionActive(), "Student.Subscriptions", "Você já tem uma assinatura ativa")
                    .AreNotEquals(0, subscription.Payments.Count, "Student.Subscription.Payments", "Esta assinatura não possui pagamentos"));

            if (IsValid)
                _subscription.Add(subscription);
        }

        private bool AnySubscriptionActive()
        {
            return _subscription.Any(sub => sub.Active);
        }
    }
}
