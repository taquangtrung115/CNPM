using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BLL
{
    public class HoaDonKhamBenh_HuyBLL
    {
        DataSet ds = new DataSet();
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-1RP7O2E\\SQLEXPRESS;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=sa2012");
        //SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        SqlDataAdapter da;

        public DataTable load_HoaDonKhamBenh()
        {
            da = new SqlDataAdapter("select * from HoaDonKhamBenh", cnn);
            da.Fill(ds, "dsHDKB");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsHDKB"].Columns[0];
            ds.Tables["dsHDKB"].PrimaryKey = khoachinh;
            return ds.Tables["dsHDKB"];
        }


        public bool them(int maHoaDonKhamBenh, int maPKB, string ngayLapPhieu, float thanhTien)
        {

            try
            {
                DataRow dr = ds.Tables["dsHDKB"].NewRow();
                dr["SOHDKHAM"] = maHoaDonKhamBenh;
                dr["SOPHIEUKHAM"] = maPKB;

                dr["NGAYLAPHDKHAM"] = ngayLapPhieu;


                dr["THANHTIEN"] = thanhTien;
                ds.Tables["dsHDKB"].Rows.Add(dr);
                luu();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void luu()
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Update(ds.Tables["dsHDKB"]);
        }
    }
}
