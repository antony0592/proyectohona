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

        public PaymentCard AddPaymentCard(PaymentCard paymentCard)
        {
            return paymentCardBusiness.AddPaymentCard(paymentCard);
        }

        public List<PaymentCard> SelectPaymentcard()
        {
            return paymentCardBusiness.SelectPaymentcard();
        }

        public PaymentCard GetPaymentCardByNumber(string number)
        {
            return paymentCardBusiness.GetPaymentCardByNumber(number);
        }
        public int AddVoucher(int paymentId, int idreservation)
        {
            return paymentCardBusiness.AddVoucher(paymentId, idreservation);
        }
    }
}
