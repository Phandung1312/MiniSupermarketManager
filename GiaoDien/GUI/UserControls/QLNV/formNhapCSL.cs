using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.BLL;
using GiaoDien.DTO;
using System.Text.RegularExpressions;


namespace GiaoDien.GUI.UserControls.QLNV
{
    public partial class formNhapCSL : Form
    {
        public formNhapCSL()
        {
            InitializeComponent();

        }

        private void formNhapCSL_Load(object sender, EventArgs e)
        {
            object ma = BLL_Staff.Instance.TimMaNV();
            string x= (string) ma;
            lblMaNV.Text = x;
            object ten = BLL_Staff.Instance.TimTenNV();
            string y = (string) ten;
            lblTenNV.Text = y;
               
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CSLuong cs = new CSLuong();
            cs.ID_Staff = lblMaNV.Text;
              cs.Luong= Convert.ToInt32( txtluong.Text);
            cs.Thuong=Convert.ToInt32(txtthuong.Text);
            cs.PhuCap=Convert.ToInt32(txtphucap.Text);
            BLL_Staff.Instance.ThemLuong(cs);
            MessageBox.Show("Đã Thêm Thành Công \nChính Sách Lương Nhân Viên "+lblTenNV.Text+"Với Mã NV: "+lblMaNV.Text);
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

     
        private void txtluong_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{4,50}$");
            if (string.IsNullOrEmpty(txtluong.Text))
            {
                lblLuong.Text = "Lương không được để trống.";
            }
            else
            {
                if (r.IsMatch(txtluong.Text) == false)
                    lblLuong.Text = "Lương không hợp lệ..";
                else
                    lblLuong.Text = "";
            }
        }

        private void txtthuong_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{1,50}$");
            if (string.IsNullOrEmpty(txtthuong.Text))
            {
                lblthuong.Text = "Thưởng không được để trống.";
            }
            else
            {
                if (r.IsMatch(txtthuong.Text) == false)
                    lblthuong.Text = "Thưởng không hợp lệ..";
                else
                    lblthuong.Text = "";
            }
        }

        private void txtphucap_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{1,50}$");
            if (string.IsNullOrEmpty(txtphucap.Text))
            {
                lblphucap.Text = "Phụ cấp không được để trống.";
            }
            else
            {
                if (r.IsMatch(txtphucap.Text) == false)
                    lblphucap.Text = "Phụ cấp không hợp lệ..";
                else
                    lblphucap.Text = "";
            }
        }
    }
}
