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

        public void Reload()
        {
            this.Visible = true;
        }
        private void bt_xem_Click(object sender, EventArgs e)
        {
            US_XemCTCunUng us = new US_XemCTCunUng();
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.d = new US_XemCTCunUng.DelegeateReload(Reload);
        }
    }
}
