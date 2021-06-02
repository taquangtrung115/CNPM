﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
   public class Report
    {
        DataSet ds = new DataSet();
        //SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        SqlDataAdapter da;
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        public DataTable loadBillByBillID(string maBN)
        {
            da = new SqlDataAdapter("exec HoaDon N'" + maBN + "'", cnn);
            da.Fill(ds, "dsHD");
            return ds.Tables["dsHD"];
        }
        public DataTable phieuKhamBenh(int maBN)
        {
            da = new SqlDataAdapter("exec rpPhieuKhamBenh " + maBN, cnn);
            da.Fill(ds, "dsPK");
            return ds.Tables["dsPK"];
        }
        public DataTable datHang(string maDH)
        {
            da = new SqlDataAdapter("exec rpDatHang '" + maDH + "'", cnn);
            da.Fill(ds, "dsDH");
            return ds.Tables["dsDH"];
        }
        public DataTable nhapHang(string maNH)
        {
            da = new SqlDataAdapter("exec rpNhapHang '" + maNH + "'", cnn);
            da.Fill(ds, "dsNH");
            return ds.Tables["dsNH"];
        }
    }
}
