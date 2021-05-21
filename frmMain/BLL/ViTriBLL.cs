using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class ViTriBLL
    {
        DataSet ds = new DataSet();
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        SqlDataAdapter da;

        public DataTable loadGridView()
        {
            da = new SqlDataAdapter("select * from VITRI", cnn);
            da.Fill(ds, "dsVT");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsVT"].Columns[0];
            ds.Tables["dsVT"].PrimaryKey = khoachinh;
            return ds.Tables["dsVT"];
        }
    }
}
