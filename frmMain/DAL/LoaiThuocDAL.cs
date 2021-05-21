using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
   public class LoaiThuocDAL
    {
       LoaiThuocBLL lt = new LoaiThuocBLL();
       public DataTable loadGripView()
       {
           return lt.loadGridView();
       }
       public bool them(string maLoai, string tenLoai)
       {
           if (lt.them(maLoai,tenLoai)== true)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       public bool xoa(string maLoai)
       {
           if (lt.xoa(maLoai) == true)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       public bool sua(string maLoai, string tenLoai)
       {
           if (lt.sua(maLoai, tenLoai) == true)
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
