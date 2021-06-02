using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class NhaSanXuatBLL
    {
        DataSet ds = new DataSet();
        //SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        SqlDataAdapter da;
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        public DataTable loadGridView()
        {
            da = new SqlDataAdapter("select * from NHASANXUAT", cnn);
            da.Fill(ds, "dsNSX");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsNSX"].Columns[0];
            ds.Tables["dsNSX"].PrimaryKey = khoachinh;
            return ds.Tables["dsNSX"];
        }
    }
}
