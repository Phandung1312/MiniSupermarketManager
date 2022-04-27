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

        private void bt_xem_Click(object sender, EventArgs e)
        {
            US_AddUpdateDX us = new US_AddUpdateDX();
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.d = new US_AddUpdateDX.DelegeateReload(Reload);
        }
        public void Reload()
        {
            this.Visible = true;
        }
        private void bt_Them_Click(object sender, EventArgs e)
        {
            
            US_AddUpdateDX ds = new US_AddUpdateDX();
            ds.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(ds);
            ds.ButtonUpdate.Text = "OK";
            ds.label.Visible = false;
            ds.txt1.Visible = false;
            ds.txt2.Enabled = true;
            ds.txt3.Enabled = true;
            ds.txt4.Enabled = true;
            ds.txt5.Enabled = true;
            ds.txt6.Enabled = true;
            ds.dtNX.Enabled = true;
            this.Visible = false;
            ds.d = new US_AddUpdateDX.DelegeateReload(Reload);
            
  
        }
    }
}
