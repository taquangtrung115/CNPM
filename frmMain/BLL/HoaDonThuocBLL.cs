using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
   public class HoaDonThuocBLL
    {
        DataSet ds = new DataSet();
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        SqlDataAdapter da;

        public DataTable loadBillByBillID()
        {
            da = new SqlDataAdapter("select * from KHOA", cnn);
            da.Fill(ds, "dsKhoa");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsKhoa"].Columns[0];
            ds.Tables["dsKhoa"].PrimaryKey = khoachinh;
            return ds.Tables["dsKhoa"];
        }
    }
}
