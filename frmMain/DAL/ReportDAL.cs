using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
   public class ReportDAL
    {

        Report hd = new Report();
        public DataTable loadBillByBillID(string maBN)
        {

            return hd.loadBillByBillID(maBN);
        }
        public DataTable phieuKhamBenh(int maBN)
        {

            return hd.phieuKhamBenh(maBN);
        }
        public DataTable datHang(string maDH)
        {

            return hd.datHang(maDH);
        }
        public DataTable nhapHang(string maNH)
        {

            return hd.nhapHang(maNH);
        }
    }
}
