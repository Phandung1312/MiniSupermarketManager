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
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
            this.panelSubTK.Visible = false;
        }
        public void OpenUserControl(UserControl userControl, object sender)
        {
            this.panelDesktop.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add((userControl));
        }

        private void bt_Kho_Click(object sender, EventArgs e)
        {
            US_TrichXuatBaoCao us = new US_TrichXuatBaoCao();
            us.btReport.Visible = false;
            OpenUserControl(us, sender);
        }

        private void bt_Kehang_Click(object sender, EventArgs e)
        {
            US_KeHang us = new US_KeHang();
            us.btDel.Visible = false;
            us.btreconmend.Visible = false;
            us.btReturn.Visible = false;
            OpenUserControl(us, sender);
        }

        private void bt_Hangcungung_Click(object sender, EventArgs e)
        {
            US_HangCungUng us = new US_HangCungUng();
            us.btrecommend.Visible = false;
            OpenUserControl(us, sender);
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        