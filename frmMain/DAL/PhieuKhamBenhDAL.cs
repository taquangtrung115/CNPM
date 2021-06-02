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
    }
}
