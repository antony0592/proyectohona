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
            return this.paymentCardData.AddPaymentCard(paymentCard);
        }


    }
}
