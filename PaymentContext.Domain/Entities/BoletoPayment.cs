﻿using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities
{
    public partial class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode,
            string boletoNumber,
            string number,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            Address address,
            Document document,
            string payer,
            Email email) : base(number,
                paidDate,
                expireDate,
                total,
                totalPaid,
                address,
                document,
                payer,
                email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }
        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
