﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
   public class DangNhapBLL
    {
        DataSet ds = new DataSet();
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-R95F3JA;Initial Catalog=QLPHONGKHAMBENH;User ID=sa;Password=taquangtrung");
        

        public bool login(string taiKhoan, string matKhau)
        {

            string sqlAcount = "select tendangnhap, MatKhau from NhanVien where tendangnhap = '" + taiKhoan + "' and MatKhau = '" + matKhau + "'";
            SqlCommand cmd = new SqlCommand(sqlAcount, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}