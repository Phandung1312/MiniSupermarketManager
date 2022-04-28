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
    public partial class US_KeHang : UserControl
    {
        public US_KeHang()
        {
            InitializeComponent();
        }
        public Button bt1
        {
            get { return bt_dexuat; }
            set
            {
                bt_dexuat = value;
            }
        }
        public Button bt2
        {
            get { return bt_xoaKe; }
            set
            {
                bt_xoaKe = value;
            }
        }
        public Button bt3
        {
            get { return BT_TraHang; }
            set
            {
                BT_TraHang = value;
            }
        }
        public Button bt4
        {
            get { return bt_xem; }
            set
            {
                bt_xem = value;
            }
        }
        public void Reload()
        {
            this.Visible = true;
        }
        private void bt_xem_Click_1(object sender, EventArgs e)
        {
            US_chitietKeHang us = new US_chitietKeHang();
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.f = new US_chitietKeHang.DelegeateReload(Reload);
        }
    }
}
