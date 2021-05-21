using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
  public  class NhaSanXuatDAL
    {
        NhaSanXuatBLL nsx = new NhaSanXuatBLL();
        public DataTable loadGripView()
        {
            return nsx.loadGridView();
        }
    }
}
