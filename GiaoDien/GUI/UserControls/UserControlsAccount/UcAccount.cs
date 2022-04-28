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
    public partial class UcAccount : UserControl
    {

        public UcAccount()
        {
            InitializeComponent();
        }
        public void Reload()
        {
            this.Visible = true;
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            UCChangePassword cp= new UCChangePassword();
            this.Parent.Controls.Add(cp);
            this.Visible = false;
            cp.d = new UCChangePassword.DelegeateReload(Reload);

        }

        private void panel52_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
