using Domain;
using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Presentation.Models
{
    public class VoucherModel : Voucher
    {

        VoucherBusiness voucherBusiness;
        public VoucherModel(string connectionString)
        {
            this.voucherBusiness = new VoucherBusiness(connectionString);
        }

        public VoucherModel()
        {

        }
        public List<Voucher> GetAllVoucher()
        {
            return this.voucherBusiness.GetAllVoucher();
        }


    }
}