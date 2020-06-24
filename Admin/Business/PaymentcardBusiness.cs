using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            List <Paymentcard> paymentcards = this.paymentcardData.GetAllPaymentcard();

            for (int k = 0; k < paymentcards.Count; k++)
            {
                string cardNumber = paymentcards[k].cardnumber.ToString();
                string newCardNumber = cardNumber.Substring(cardNumber.Length - 4);
                paymentcards[k].cardnumber = long.Parse(newCardNumber);
            }

                return paymentcards;
        }
    }
}
