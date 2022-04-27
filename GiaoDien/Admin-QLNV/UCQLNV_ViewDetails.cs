using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Admin_QLNV
{
    public partial class UCQLNV_ViewDetails : UserControl
    {
        public UCQLNV_ViewDetails()
        {
            InitializeComponent();
        }
        public void OpenUserControl(UserControl userControl, object sender)
        {
            this.Controls.Clear();
            this.Controls.Add((userControl));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uc = new UCQLNV();
            OpenUserControl(uc, sender);
        }
    }
}
