using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
   public class BenhNhanBLL
    {
        DataSet ds = new DataSet();
        //SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-1RP7O2E\\SQLEXPRESS;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=sa2012");
        SqlDataAdapter da;
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");

        public DataTable loadGridView()
        {
            da = new SqlDataAdapter("select * from BENHNHAN", cnn);
            da.Fill(ds, "dsBN");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsBN"].Columns[0];
            ds.Tables["dsBN"].PrimaryKey = khoachinh;
            return ds.Tables["dsBN"];
        }
    }
}
