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
    public partial class US_chitietKeHang : UserControl
    {
        public delegate void DelegeateReload();
        public DelegeateReload f { get; set; }
        public Button btShow
        {
            get { return bt_Show; }
            set {  }
        }
        public Button btShowAdminSale
        {
            get { return bt_ShowAdminSale; }
            set {  }
        }
        public US_chitietKeHang()
        {
            InitializeComponent();
        }
        public void OpenUserControl(UserControl userControl, object sender)
        {
            userControl.Dock = DockStyle.Fill;
            this.panelKehang.Controls.Clear();
            this.panelKehang.Controls.Add((userControl));
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
           
        }
        public void Reload()
        {
            this.Visible = true;
        }
     
        private void bt_Close_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            f();
        }

        private void bt_Show_Click(object sender, EventArgs e)
        {
            US_CTkeHang us = new US_CTkeHang();
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.d = new US_CTkeHang.DelegeateReload(Reload);
        }

        private void bt_ShowAdminSale_Click(object sender, EventArgs e)
        {
            US_CTkeHang us = new US_CTkeHang();
            us.Dock = DockStyle.Fill;
            us.update.Visible = false;
            us.close.Location = new Point(501, 262);
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.d = new US_CTkeHang.DelegeateReload(Reload);
        }
    }
}
