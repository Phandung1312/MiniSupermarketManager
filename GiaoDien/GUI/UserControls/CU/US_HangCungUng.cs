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
    public partial class US_HangCungUng : UserControl
    {
        public US_HangCungUng()
        {
            InitializeComponent();
        }
        public Button btAdd
        {
            get { return bt_Add; }
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
        public Button btrecommend
        {
            get { return bt_Recommend; }
            set
            {
                
            }
        }
       
        public void Reload()
        {
            this.Visible = true;
        }
       
        private void bt_Thêm_Click(object sender, EventArgs e)
        {
            US_XemCTCunUng us = new US_XemCTCunUng();
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.btAddUpdate.Text = "OK";
            us.txtDChi.Enabled = true;
            us.txtemail.Enabled = true;
            us.txtsdt.Enabled = true;
            us.txtten.Enabled = true;
            us.d = new US_XemCTCunUng.DelegeateReload(Reload);
        }

        private void bt_Xem_Click(object sender, EventArgs e)
        {
            US_XemCTCunUng us = new US_XemCTCunUng();
            if (btrecommend.Visible == true)
            {
                us.btAddUpdate.Visible = false;
                us.btHuy.Location = new Point(582, 225);
            }
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.d = new US_XemCTCunUng.DelegeateReload(Reload);
        }
    }
}
