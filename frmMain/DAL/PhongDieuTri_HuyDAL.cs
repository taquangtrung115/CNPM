using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BLL;

namespace DAL
{
   public class PhongDieuTri_HuyDAL
    {
       PhongDieuTri_HuyBLL pdt = new PhongDieuTri_HuyBLL();
       public DataTable load_cbPhongDieuTri() {
           return pdt.load_PhongDieuTri();
       }
    }
}
