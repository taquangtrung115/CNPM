using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class ThuocBLL
    {
        DataSet ds = new DataSet();
       // SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        SqlDataAdapter da;
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        public DataTable loadGridView()
        {
            da = new SqlDataAdapter("select * from THUOC", cnn);
            da.Fill(ds, "dsT");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["dsT"].Columns[0];
            ds.Tables["dsT"].PrimaryKey = khoachinh;
            return ds.Tables["dsT"];
        }
        //public DataTable findGridView(string tenNV)
        //{
        //    da = new SqlDataAdapter("select * from NHANVIEN where TENNV = N'" + tenNV + "'", cnn);
        //    da.Fill(ds, "dsNV");
        //    DataColumn[] khoachinh = new DataColumn[1];
        //    khoachinh[0] = ds.Tables["dsNV"].Columns[0];
        //    ds.Tables["dsNV"].PrimaryKey = khoachinh;


        //    //foreach (DataRow item in ds.Tables)
        //    //{
        //    //    da.Fill(ds, "dsNV");
        //    //}
        //    return ds.Tables["dsNV"];

        //}
        public bool them(string maThuoc, string tenThuoc, string maLoai, string maNSX, string congDung, string hamLuong, string HSD, string donViCB, double giaCB, double soLuongCB, string donViBan, double giaBan, double soLuongBan, double giaTriQuyDoi,string quyCachDongGoi,string maViTri, string moTa)
        {
            try
            {
                DataRow dr = ds.Tables["dsT"].NewRow();
                dr["MATHUOC"] = maThuoc;
                dr["TENTHUOC"] = tenThuoc;
                dr["MALOAI"] = maLoai;
                dr["MANSX"] = maNSX;
                dr["CONGDUNG"] = congDung;
                dr["HAMLUONG"] = hamLuong;
                dr["HSD"] = HSD;
                dr["DONVICB"] = donViCB;
                dr["GIACB"] = giaCB;
                dr["SOLUONGCB"] = soLuongCB;
                dr["DONVIBAN"] = donViBan;
                dr["GIABAN"] = giaBan;
                dr["SOLUONGBAN"] = soLuongBan;
                dr["GIATRIQUYDOI"] = giaTriQuyDoi;
                dr["QUICACHDONGGOI"] = quyCachDongGoi;
                dr["MAVITRI"] = maViTri;
                dr["MOTA"] = moTa;
                ds.Tables["dsT"].Rows.Add(dr);
                luu();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool xoa(string maThuoc)
        {
            try
            {
                DataRow dr = ds.Tables["dsT"].Rows.Find(maThuoc);
                if (dr != null)
                {
                    dr.Delete();
                    luu();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool sua(string maThuoc, string tenThuoc, string maLoai, string maNSX, string congDung, string hamLuong, string HSD, string donViCB, double giaCB, double soLuongCB, string donViBan, double giaBan, double soLuongBan, double giaTriQuyDoi, string quyCachDongGoi, string maViTri, string moTa)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                DataRow dr = ds.Tables["dsT"].Rows.Find(maThuoc);
                if (dr != null)
                {
                    SqlCommand capnhat = new SqlCommand("UPDATE THUOC SET TENTHUOC=N'" + tenThuoc + "',MALOAI = '" + maLoai + "',MANSX = '" + maNSX + "',CONGDUNG = N'" + congDung + "',HAMLUONG =N'" + hamLuong + "',HSD = '" + HSD + "',DONVICB = N'" + donViCB + "', GIACB=" + giaCB + ",SOLUONGCB=" + soLuongCB + ",DONVIBAN= N'" + donViBan + "',SOLUONGBAN=" + soLuongBan + ",GIATRIQUYDOI = " + giaTriQuyDoi + ",QUICACHDONGGOI = N'" + quyCachDongGoi + "',MAVITRI='" + maViTri + "',MOTA=N'" + moTa + "' WHERE MATHUOC='" + maThuoc + "'", cnn);
                    capnhat.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public void luu()
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Update(ds.Tables["dsT"]);
        }
    }
}
