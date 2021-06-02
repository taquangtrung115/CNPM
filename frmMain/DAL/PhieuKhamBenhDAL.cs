using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
  public  class PhieuKhamBenhDAL
    {
      PhieuKhamBenhBLL pkb = new PhieuKhamBenhBLL();

      public DataTable load_PhieuKhamBenh() {
       return   pkb.load_PhieuKhamBenh();
      }


      public bool them(int maPhieu, int maBN, string maNV, string ngayLapPhieu, string maPhong, string tinhTrangSucKhoe, string deNghiKham, string maGiaKham, string trangThaiPhieu)
      {
          if (pkb.them(maPhieu,maBN,maNV,ngayLapPhieu,maPhong,tinhTrangSucKhoe,deNghiKham,maGiaKham,trangThaiPhieu) == true)
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
