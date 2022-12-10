using Flunt.Br;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(firstName, 3, "Name.FirstName", "Nome deve ter pelo mneos 3 caracteres")
                .IsGreaterThan(lastName, 3, "Name.LastName", "Sobrenome deve ter pelo mneos 3 caracteres"));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
