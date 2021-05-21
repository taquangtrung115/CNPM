using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using System.Data;
namespace DAL
{
    public class ThuocDAL
    {
        ThuocBLL t = new ThuocBLL();
        public DataTable loadGripView()
        {
            return t.loadGridView();
        }
        public bool them(string maThuoc, string tenThuoc, string maLoai, string maNSX, string congDung, string hamLuong, string HSD, string donViCB, double giaCB, double soLuongCB, string donViBan, double giaBan, double soLuongBan, double giaTriQuyDoi, string quyCachDongGoi, string maViTri, string moTa)
        {
            if (t.them(maThuoc, tenThuoc,maLoai,maNSX,congDung,hamLuong,HSD,donViCB,giaCB,soLuongCB,donViBan,giaBan,soLuongBan,giaTriQuyDoi,quyCachDongGoi,maViTri,moTa) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool xoa(string maLoai)
        {
            if (t.xoa(maLoai) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool sua(string maThuoc, string tenThuoc, string maLoai, string maNSX, string congDung, string hamLuong, string HSD, string donViCB, double giaCB, double soLuongCB, string donViBan, double giaBan, double soLuongBan, double giaTriQuyDoi, string quyCachDongGoi, string maViTri, string moTa)
        {
            if (t.sua(maThuoc, tenThuoc, maLoai, maNSX, congDung, hamLuong, HSD, donViCB, giaCB, soLuongCB, donViBan, giaBan, soLuongBan, giaTriQuyDoi, quyCachDongGoi, maViTri, moTa) == true)
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
