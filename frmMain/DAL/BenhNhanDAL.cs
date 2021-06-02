using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
   public class BenhNhanDAL
    {
    BenhNhanBLL bn = new BenhNhanBLL();
        public DataTable loadGripView()
        {
            return bn.loadGridView();
        }

        public bool them( int maBN,string tenBN,  string ngaySinh, string gioiTinh, string diaChi,  string sDT)
        {
            if (bn.them(maBN,tenBN,ngaySinh,gioiTinh,diaChi,sDT) == true)
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
