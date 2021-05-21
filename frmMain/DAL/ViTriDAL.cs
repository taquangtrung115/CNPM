using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
    public class ViTriDAL
    {
        ViTriBLL vt = new ViTriBLL();
        public DataTable loadGripView()
        {
            return vt.loadGridView();
        }
    }
}
