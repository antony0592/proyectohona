using System.Collections.Generic;
using Business;
using Domain;

namespace Presentation.Models
{
    public class PaymentcardModel:Paymentcard
    {
        PaymentcardBusiness paymentcardBusiness;
        public PaymentcardModel(string connectionString)
        {
            this.paymentcardBusiness = new PaymentcardBusiness(connectionString);
        }

        public PaymentcardModel()
        {

        }
        public List<Paymentcard> GetAllPaymentcard()
        {
            return this.paymentcardBusiness.GetAllPaymentcard();
        }

    }
}