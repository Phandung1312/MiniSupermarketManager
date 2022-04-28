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
    public partial class US_XemCTCunUng : UserControl
    {

        public delegate void DelegeateReload();
        public DelegeateReload d { get; set; }
        public US_XemCTCunUng()
        {
            InitializeComponent();
            txtDC.Enabled = false;
            txtEmail.Enabled = false;
            txtMaCU.Enabled = false;
            txtSDT.Enabled = false;
            txtTenCU.Enabled = false;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            d();
        }
    }
}
