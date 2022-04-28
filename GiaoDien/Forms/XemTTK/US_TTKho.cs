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
    public partial class US_TTKho : UserControl
    {
        public US_TTKho()
        {
            InitializeComponent();
        }
        public void Reload()
        {
            this.Visible = true;
        }
        private void bt_xem_Click(object sender, EventArgs e)
        {
            US_XemTTKho us = new US_XemTTKho();
            us.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(us);
            this.Visible = false;
            us.d = new US_XemTTKho.DelegeateReload(Reload);
        }
    }
}
