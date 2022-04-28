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
    public partial class US_CTkeHang : UserControl
    {
        public delegate void DelegeateReload();
        public DelegeateReload d { get; set; }
        public US_CTkeHang()
        {
            InitializeComponent();
            txtMaKe.Enabled = false;
            txtMaSP.Enabled = false;
            txtSL.Enabled = false;
        }

       private void bt_close_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            d();
        }

        private void bt_update_Click_1(object sender, EventArgs e)
        {
            txtSL.Enabled = true;
            if (bt_update.Text == "Chỉnh sửa")
                bt_update.Text = "OK";
        }
    }
}
