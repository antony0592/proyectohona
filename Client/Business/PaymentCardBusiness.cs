using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PaymentCardBusiness
    {
        private PaymentCardData paymentCardData;

        public PaymentCardBusiness(String connString)
        {
            this.paymentCardData = new PaymentCardData(connString);
        }//Fin del constructor.
        public int AddPaymentCard(PaymentCard paymentCard)
        {
            return paymentCardData.AddPaymentCard(paymentCard);
        }

        public List<PaymentCard> SelectPaymentcard()
        {
            return paymentCardData.SelectPaymentcard();
        }

        public PaymentCard GetPaymentCardByNumber(long number)
        {
            return SelectPaymentcard().Find(p => p.Number == number);
        }
    }
}
