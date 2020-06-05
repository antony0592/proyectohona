using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class PaymentCardModel
    {
        PaymentCardBusiness paymentCardBusiness;
        public PaymentCardModel(string connectionString)
        {
            this.paymentCardBusiness = new PaymentCardBusiness(connectionString);
        }

        public int AddPaymentCard(PaymentCard paymentCard)
        {
            return paymentCardBusiness.AddPaymentCard(paymentCard);
        }

        public List<PaymentCard> SelectPaymentcard()
        {
            return paymentCardBusiness.SelectPaymentcard();
        }

        public PaymentCard GetPaymentCardByNumber(long number)
        {
            return paymentCardBusiness.GetPaymentCardByNumber(number);
        }

    }
}
