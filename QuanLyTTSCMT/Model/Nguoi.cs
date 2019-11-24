using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_TTSCMT.Model
{
    public class Nguoi
    {
        private string ten;
        private string mSSV;
        private string sDT;
        private string tenTaiKhoan;
        private string mKTaiKhoan;
        protected bool quyenQuanLy;
        public Nguoi() { }
        public Nguoi(string ten,string mSSV,string sDT,string tenTaiKhoan,string mKTaiKhoan)
        {
            Ten = ten;
            MSSV = mSSV;
            SDT = sDT;
            TenTaiKhoan = tenTaiKhoan;
            MKTaiKhoan = mKTaiKhoan;
        }

        public Nguoi(string ten,string mSSV,string sDT)
        {
            Ten = ten;
            MSSV = mSSV;
            SDT = sDT;
        }
        public string Ten { get => ten; set => ten = value; }
        public string MSSV { get => mSSV; set => mSSV = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MKTaiKhoan { get => mKTaiKhoan; set => mKTaiKhoan = value; }
        public bool QuyenQuanLy { get => quyenQuanLy; }
    }
}
