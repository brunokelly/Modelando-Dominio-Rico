namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string creditCardNumber, string cardHolderName, string lastTransactionNumber, string number,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string address,
            string document,
            string payer,
            string email) : base(number,
                paidDate,
                expireDate,
                total,
                totalPaid,
                address,
                document,
                payer,
                email)
        {
            CreditCardNumber = creditCardNumber;
            CardHolderName = cardHolderName;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CreditCardNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }


}
