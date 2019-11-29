using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTTSCMT.Model
{
    public partial class FrmNhanVien : Form
    {
        private NhanVienRoot nhanVienRoot;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DB_QuanLyTTSCMTEntities newDataBase = new DB_QuanLyTTSCMTEntities();
            var select = from table in newDataBase.NhanViens select table;
            foreach (var iteam in select)
                if (iteam.ID == NguoiSuDung.ID)
                {
                    nhanVienRoot = new NhanVienRoot(iteam.Ten, iteam.MSSV, iteam.SDT, iteam.TenTaiKhoan, iteam.MKTaiKhoan);
                    lblNguoiNhanMay.Text = "Người nhận máy: " + iteam.Ten;
                }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
