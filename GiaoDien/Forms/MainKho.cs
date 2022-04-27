using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Forms
{
    public partial class MainKho : Form
    {
        public MainKho()
        {
            InitializeComponent();
            this.PanelSubKho.Visible = false;
        }
        public void OpenUserControl(UserControl userControl, object sender)
        {
            userControl.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Clear();
            this.panelDesktop.Controls.Add((userControl));
        }

        private void bt_Kehang_Click(object sender, EventArgs e)
        {
            US_KeHang us = new US_KeHang();
            OpenUserControl(us, sender);
        }

        private void bt_Kho_Click(object sender, EventArgs e)
        {
            this.PanelSubKho.Visible = (!this.PanelSubKho.Visible) ? true : false;
        }

        private void bt_Nhaphang_Click(object sender, EventArgs e)
        {
            US_DonNhap us = new US_DonNhap();
            OpenUserControl(us, sender);
        }

        private void bt_Xuathang_Click(object sender, EventArgs e)
        {
            USXuatHang us = new USXuatHang();
            OpenUserControl(us, sender);
        }

        private void bt_Xemkho_Click(object sender, EventArgs e)
        {
            US_TTKho us = new US_TTKho();
            OpenUserControl(us, sender);
        }

        private void bt_Trichxuatbaocao_Click(object sender, EventArgs e)
        {
            US_TrichXuatBaoCao us = new US_TrichXuatBaoCao();
            OpenUserControl(us, sender);
        }

        private void bt_Hangcungung_Click(object sender, EventArgs e)
        {
            US_HangCungUng us = new US_HangCungUng();
            us.btAdd.Visible = false;
            us.btDel.Visible = false;
            us.btrecommend.Location = new Point(1007, 17);
            OpenUserControl(us, sender);
        }

        private void bt_Account_Click(object sender, EventArgs e)
        {
            UcAccount ac = new UcAccount();
            OpenUserControl(ac, sender);
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
