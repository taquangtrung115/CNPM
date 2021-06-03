using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BLL
{
   public class PhieuKhamBenhBLL
    {
        DataSet ds = new DataSet();
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-1RP7O2E\\SQLEXPRESS;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=sa2012");
        //SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        SqlDataAdapter da;
        public DataTable loadPhieuKhamBenh(string tenBN)
        {
            da = new SqlDataAdapter("exec rpPhieuKhamBenh N'"+tenBN+"'", cnn);
            da.Fill(ds, "dsPK");
            
            return ds.Tables["dsPK"];
        }
        public DataTable load_PhieuKhamBenh()
        {
            da = new SqlDataAdapter("select * from PhieuKhamBenh", cnn);
            da.Fill(ds, "dsPKB");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsPKB"].Columns[0];
            ds.Tables["dsPKB"].PrimaryKey = khoachinh;
            return ds.Tables["dsPKB"];
        }


        public bool them(int maPhieu,int maBN, string maNV, string ngayLapPhieu, string maPhong, string tinhTrangSucKhoe, string deNghiKham,string maGiaKham,string trangThaiPhieu)
        {

            try
            {
                DataRow dr = ds.Tables["dsPKB"].NewRow();

                dr["SOPHIEUKHAM"] = maPhieu;
                dr["MABN"] = maBN;
                dr["MANV"] = maNV;
                dr["NGAYLAPPHIEU"] = ngayLapPhieu;
                dr["MAPHONG"] = maPhong;
                dr["TINHTRANGSUCKHOE"] = tinhTrangSucKhoe;
                dr["DENGHIKHAM"] = deNghiKham;
                dr["MAGIAKHAM"] = maGiaKham;
                dr["TRANGTHAIPHIEU"] = trangThaiPhieu;
                ds.Tables["dsPKB"].Rows.Add(dr);
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
            da.Update(ds.Tables["dsPKB"]);
        }

    }
}
