using System;
using System.Collections.Generic;
using Data;
using Domain;

namespace Business
{
    public class PaymentcardBusiness
    {
        private PaymentcardData paymentcardData;

        public PaymentcardBusiness(String connString)
        {
            this.paymentcardData = new PaymentcardData(connString);
        }//Fin del constructor.

        public List<Paymentcard> GetAllPaymentcard()
        {
            return this.paymentcardData.GetAllPaymentcard();
        }
    }
}
