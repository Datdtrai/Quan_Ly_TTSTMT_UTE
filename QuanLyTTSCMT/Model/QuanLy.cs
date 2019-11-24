using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_TTSCMT.Model
{
    public class QuanLy:Nguoi
    {

        public QuanLy():base()
        {
            quyenQuanLy = true;
        }
        public QuanLy(string ten, string mSSV, string sDT, string tenTaiKhoan, string mKTaiKhoan):base (ten,mSSV,sDT,tenTaiKhoan,mKTaiKhoan)
        {
            quyenQuanLy = true;
        }
        public QuanLy(QuanLy root)
        {
            quyenQuanLy = true;
            Ten = root.Ten;
            MSSV = root.MSSV;
            SDT = root.SDT;
            TenTaiKhoan = root.TenTaiKhoan;
            MKTaiKhoan = root.MKTaiKhoan;
        }
        public void thongKeDoanhThu(DateTime batDau,DateTime ketThuc)
        {

        }
        public void themNhanVien(string ten, string mSSV, string sDT, string tenTaiKhoan, string mKTaiKhoan)
        {

        }
    }
}
