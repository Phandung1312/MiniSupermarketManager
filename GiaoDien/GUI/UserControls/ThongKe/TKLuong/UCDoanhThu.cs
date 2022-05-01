using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Forms.ThongKe.TKLuong
{
    public partial class UCDoanhThu : UserControl
    {
        public UCDoanhThu()
        {
            InitializeComponent();
        }
        public void AddUserControl(UserControl uc)
        {
            this.panelTK.Controls.Clear();
          //  this.panelSubTK.Visible = false;
            this.panelTK.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void theoMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new UCDoanhThu_MatHang();
            AddUserControl(uc);
        }

        private void theoHãngCungỨngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new UCDoanhThu_HangCU();
            AddUserControl(uc);
        }
    }
}
