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
        public Button btreconmend
        {
            get { return bt_Recommend; }
            set
            {
               
            }
        }
        public Button btDel
        {
            get { return bt_Del; }
            set
            {
               
            }
        }
        public Button btReturn
        {
            get { return bt_Return; }
            set
            {
               
            }
        }
        public void Reload()
        {
            this.Visible = true;
        }
       

        private void bt_xem_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_Show_Click(object sender, EventArgs e)
        {
            US_chitietKeHang us = new US_chitietKeHang();
            us.Dock = DockStyle.Fill;
            if (btreconmend.Visible)
            {
                us.btShowAdminSale.Visible = false;
            }
            else us.btShow.Visible = false;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.f = new US_chitietKeHang.DelegeateReload(Reload);
        }
    }
}
