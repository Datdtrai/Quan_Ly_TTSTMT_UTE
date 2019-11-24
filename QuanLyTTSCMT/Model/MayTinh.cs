using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_TTSCMT.Model
{
    public class MayTinh
    {
        private string loaiMayTinh;
        private string tenMayTinh;
        private string tenChuMay;
        private string tenNV;
        private DateTime ngayNhanMay;
        private DateTime ngayGiaoMay;
        private string tinhTrang;
        private string thanhTien;
        public MayTinh() { }
        public MayTinh(string tenNV,string loaiMayTinh,string tenMayTinh,string tenChuMay,DateTime ngayNhanMay,DateTime ngayGiaoMay,string tinhTrang,string thanhTien) 
        {
            TenNV = tenNV;
            LoaiMayTinh = loaiMayTinh;
            TenMayTinh = tenMayTinh;
            TenChuMay = tenChuMay;
            NgayNhanMay = ngayNhanMay;
            NgayGiaoMay = ngayGiaoMay;
            TinhTrang = tinhTrang;
            ThanhTien = thanhTien;
        }
        public MayTinh(MayTinh root)
        {
            LoaiMayTinh = root.LoaiMayTinh;
            TenMayTinh = root.TenMayTinh;
            TenChuMay = root.TenChuMay;
            NgayNhanMay = root.NgayNhanMay;
            NgayGiaoMay = root.NgayGiaoMay;
            TinhTrang = root.TinhTrang;
            ThanhTien = root.ThanhTien;
            TenNV = root.TenNV;
        }
        public string LoaiMayTinh { get => loaiMayTinh; set => loaiMayTinh = value; }
        public string TenMayTinh { get => tenMayTinh; set => tenMayTinh = value; }
        public string TenChuMay { get => tenChuMay; set => tenChuMay = value; }
        public DateTime NgayNhanMay { get => ngayNhanMay; set => ngayNhanMay = value; }
        public DateTime NgayGiaoMay { get => ngayGiaoMay; set => ngayGiaoMay = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
    }
}
