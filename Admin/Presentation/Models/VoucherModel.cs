using Domain;
using Business;
using System.Collections.Generic;

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

        public void DeleteVoucherList(int id)
        {
            this.voucherBusiness.DeleteVoucherList(id);
        }


    }
}