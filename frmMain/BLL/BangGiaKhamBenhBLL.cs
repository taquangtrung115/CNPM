using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BLL
{
  public  class BangGiaKhamBenhBLL
    {
        DataSet ds = new DataSet();
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-1RP7O2E\\SQLEXPRESS;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=sa2012");

        SqlDataAdapter da;

        public DataTable load_BangGiaKham()
        {
            da = new SqlDataAdapter("select * from BangGiaKhamBenh", cnn);
            da.Fill(ds, "dsBGKB");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsBGKB"].Columns[0];
            ds.Tables["dsBGKB"].PrimaryKey = khoachinh;
            return ds.Tables["dsBGKB"];
        }
      //////////////////////////////////////////////


    }
}
