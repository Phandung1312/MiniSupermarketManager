using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Forms.QLNV
{
    public partial class QLNV : UserControl
    {
        public QLNV()
        {
            InitializeComponent();
        }

        public void AddUserControl(UserControl uc)
        {
            this.Controls.Clear();
            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            var uc = new UCQLNV_Edit();
            AddUserControl(uc);
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            var uc = new UCQLNV_ViewDeils();
            AddUserControl(uc);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var uc = new UCQLNVAdd();
            AddUserControl(uc);
        }
    }
}
