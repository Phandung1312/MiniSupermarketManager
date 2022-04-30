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
    public partial class UCProduct : UserControl
    {
        public UCProduct()
        {
            InitializeComponent();
        }
        public void Reload()
        {
            this.Visible = true;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var uc = new UCProductShow();
            this.Visible = false;
            this.Parent.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.delReload = new UCProductShow.MyDelegate(Reload);

        }


    }
}
