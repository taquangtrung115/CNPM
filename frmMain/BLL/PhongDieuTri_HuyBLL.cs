using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BLL
{
  public  class PhongDieuTri_HuyBLL
    {
        DataSet ds = new DataSet();
        //SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-1RP7O2E\\SQLEXPRESS;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=sa2012");
        SqlDataAdapter da;
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-1RP7O2E\\SQLEXPRESS;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=sa2012");

        public DataTable load_PhongDieuTri()
        {
            da = new SqlDataAdapter("select * from Phong", cnn);
            da.Fill(ds, "dsP");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsP"].Columns[0];
            ds.Tables["dsP"].PrimaryKey = khoachinh;
            return ds.Tables["dsP"];
        }
    }
}
