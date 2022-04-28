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
    public partial class US_DonNhap : UserControl
    {
        public US_DonNhap()
        {
            InitializeComponent();
            
        }

        public void Reload()
        {
            this.Visible = true;
        }
      
        private void bt_Add_Click_1(object sender, EventArgs e)
        {
            US_AddUpdateDonNhap ds = new US_AddUpdateDonNhap();
            ds.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(ds);
            ds.ButtonUpdate.Text = "Thêm";
            ds.label.Visible = false;
            ds.txt1.Visible = false;
            ds.txt2.Enabled = true;
            ds.txt3.Enabled = true;
            ds.txt4.Enabled = true;
            ds.txt7.Enabled = true;
            ds.dtNN.Enabled = true;
            ds.txt8.Enabled = true;
            this.Visible = false;
            ds.d = new US_AddUpdateDonNhap.DelegeateReload(Reload);
        }

        private void bt_Show_Click_1(object sender, EventArgs e)
        {
            US_AddUpdateDonNhap us = new US_AddUpdateDonNhap();
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.d = new US_AddUpdateDonNhap.DelegeateReload(Reload);
        }
    }
}
