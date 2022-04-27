using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Admin_Statit
{
    public partial class UCTaking : UserControl
    {
        public UCTaking()
        {
            InitializeComponent();
        }
        public void OpenUserControl(UserControl userControl, object sender)
        {
            userControl.Dock = DockStyle.Fill;
            this.panelTK.Controls.Clear();
            this.panelTK.Controls.Add((userControl));

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void theoMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new UCTakingProduct();
            OpenUserControl(uc, sender);
        }

        private void sắpXếpTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void theoHãngCungỨngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new UCSupplier();
            OpenUserControl(uc, sender);
        }
    }
}
