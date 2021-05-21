using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
    public class KhoaDAL
    {
        KhoaBLL k = new KhoaBLL();
        public DataTable loadGripview()
        {
            return k.loadGridView();
        }
    }
}
