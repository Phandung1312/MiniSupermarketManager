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
    public partial class USXuatHang : UserControl
    {
        public USXuatHang()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            this.Visible = true;
        }
     
        private void bt_Show_Click(object sender, EventArgs e)
        {
            US_AddUpdateDX us = new US_AddUpdateDX();
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.d = new US_AddUpdateDX.DelegeateReload(Reload);
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            US_AddUpdateDX ds = new US_AddUpdateDX();
            ds.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(ds);
            ds.btAddUpdate.Text = "Thêm";
            ds.txt2.Enabled = true;
            ds.txt3.Enabled = true;
            ds.txt4.Enabled = true;
            ds.dtNX.Enabled = true;
            this.Visible = false;
            ds.d = new US_AddUpdateDX.DelegeateReload(Reload);
        }
    }
}
