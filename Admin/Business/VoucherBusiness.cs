using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class VoucherBusiness
    { 
        private VoucherData voucherData;

        public VoucherBusiness(String connString)
        {
            this.voucherData = new VoucherData(connString);
        }//Fin del constructor.

        public List<Voucher> GetAllVoucher()
        {
            return this.voucherData.GetAllVoucher();
        }

        public void DeleteVoucherList(int id)
        {
            this.voucherData.DeleteVoucherList(id);
        }

    }
}
