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
    }
}
