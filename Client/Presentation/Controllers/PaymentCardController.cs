using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class PaymentCardController : Controller
    {
        private readonly IConfiguration _configuration;
        string connectionString = "";

        public PaymentCardController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        [HttpPost]
        public JsonResult AddPaymentCard(PaymentCard paymentCard)
        {
            PaymentCardModel paymentCardModel = new PaymentCardModel(connectionString);
            PaymentCard newPaymentCard = paymentCardModel.GetPaymentCardByNumber(paymentCard.cardnumber);

            if (newPaymentCard == null)
            {
                return Json(paymentCardModel.AddPaymentCard(paymentCard));
            }
            return Json(newPaymentCard);
        }
    }
}