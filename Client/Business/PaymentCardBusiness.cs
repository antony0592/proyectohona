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
        public PaymentCard AddPaymentCard(PaymentCard paymentCard)
        {
            return paymentCardData.AddPaymentCard(paymentCard);
        }

        public List<PaymentCard> SelectPaymentcard()
        {
            return paymentCardData.SelectPaymentcard();
        }

        public PaymentCard GetPaymentCardByNumber(string number)
        {
            return SelectPaymentcard().Find(p => p.cardnumber == number);
        }
        public int AddVoucher(int paymentId, int idreservation)
        {
            return paymentCardData.AddVoucher(paymentId, idreservation);
        }
    }
}
