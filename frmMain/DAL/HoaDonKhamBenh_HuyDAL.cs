using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BLL;
namespace DAL
{
 public   class HoaDonKhamBenh_HuyDAL
    {
     HoaDonKhamBenh_HuyBLL hdkb = new HoaDonKhamBenh_HuyBLL();

     public DataTable load_HDKB() {
         return hdkb.load_HoaDonKhamBenh();
     }

     public bool them(int maHoaDonKham, int soPhieuKham, string ngayLAPHD,float thanhTien)
     {
         if ( hdkb.them(maHoaDonKham,soPhieuKham,ngayLAPHD,thanhTien)== true)
         {
             return true;

         }
         else
         {
             return false;
         }
     }

    
    }
}
