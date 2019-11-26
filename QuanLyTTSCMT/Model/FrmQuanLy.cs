using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTTSCMT.Model;
namespace QuanLyTTSCMT.Model
{
    
    public partial class FrmQuanLy : Form
    {

        private QuanLyRoot quanLyRoot;
        public FrmQuanLy()
        {
            InitializeComponent();
        }

        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            DB_QuanLyTTSCMTEntities newDataBase = new DB_QuanLyTTSCMTEntities();
            var select = from table in newDataBase.NhanViens select table;
            foreach (var iteam in select) // Tại sao phải có thao tác thêm thông tin người dùng vào quanLyRoot?
                if (iteam.ID == NguoiSuDung.ID)
                {
                    quanLyRoot = new QuanLyRoot(iteam.Ten, iteam.MSSV, iteam.SDT, iteam.TenTaiKhoan, iteam.MKTaiKhoan);
                    lblNguoiNhanMay.Text = "Người nhận máy: " + iteam.Ten;
                }
        }

        private void dataThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {

            if (txtTenNhanVien.Text == "" || txtMSSVNV.Text == "" || txtSDTNV.Text == "" || txtTenTaiKhoan.Text == "" || txtMatKhau.Text == "")
                MessageBox.Show("Bạn phải điền hết thông tin chúng tôi yêu cầu", "Lỗi");
            else if (txtMatKhau.Text != txtXNMK.Text)
            {
                txtXNMK.Text = "";
                MessageBox.Show("Mời bạn xác nhận lại mật khẩu");
            }
            else if (!quanLyRoot.kiemTraSDT(txtSDTNV.Text)||txtSDTNV.TextLength!=10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi");
            }
            else
            {
                DB_QuanLyTTSCMTEntities newDataBase = new DB_QuanLyTTSCMTEntities();
                var select = from table in newDataBase.NhanViens select table;
                bool check = true;

                foreach (var iteam in select)
                {
                    if (iteam.MSSV == txtMSSVNV.Text || iteam.TenTaiKhoan == txtTenTaiKhoan.Text)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    quanLyRoot.themNhanVien(txtTenNhanVien.Text, txtMSSVNV.Text, txtSDTNV.Text, txtTenTaiKhoan.Text, txtMatKhau.Text, cbQuyenQuanLy.Checked);
                    MessageBox.Show("Thêm nhân viên thành công:");
                }
                else
                    MessageBox.Show("Nhân Viên hoặc Tài Khoản đã tồn tại", "Lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
