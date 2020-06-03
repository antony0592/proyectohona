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

        public List<PaymentCard> GetPaymentCard()
        {
            return this.paymentCardData.GetPaymentCard();
        }

        public int AddPaymentCard(PaymentCard paymentCard)
        {

            List<PaymentCard> paymentCards = paymentCardData.GetPaymentCard();

            PaymentCard newPaymentCard = paymentCards.Find(c => c.Number == paymentCard.Number);

            if (newPaymentCard != null) 
            {
                return 1;
            }

            return this.paymentCardData.AddPaymentCard(paymentCard);
        }


    }
}
