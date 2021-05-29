using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
   public class DangNhapDAL
    {
       DangNhapBLL dn = new DangNhapBLL();
       public bool dangNhap(string tendangnhap, string matkhau)
       {
           return dn.login(tendangnhap, matkhau);
       }
       public string layCHucVu(string tendangnhap, string matkhau)
       {
           return dn.layChucVu(tendangnhap, matkhau).ToString();
           
       }
    }
}
