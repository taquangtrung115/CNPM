using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
   public class BangGiaKhamBenhDAL
    {
       BangGiaKhamBenhBLL bgkb = new BangGiaKhamBenhBLL();

       public DataTable load_BangGiaKhamBenh() {
           return bgkb.load_BangGiaKham();
       }
        public float layGiaKhamBenh(string maGiaKham) {
            return bgkb.layGiaTienKham(maGiaKham);
        }
    }
}
