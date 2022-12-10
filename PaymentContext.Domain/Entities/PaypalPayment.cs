namespace PaymentContext.Domain.Entities
{
    public class PaypalPayment : Payment
    {
        public PaypalPayment(string transactionCode, 
            string number,
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
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }


}
