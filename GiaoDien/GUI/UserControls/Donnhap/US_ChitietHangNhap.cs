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
    public partial class US_ChitietHangNhap : UserControl
    {
        public delegate void DelegeateReload();
        public DelegeateReload d { get; set; }
        public DateTimePicker dtNNCT
        {
            get { return dateTimeNN; }
            set { dateTimeNN = value; }
        }
        public Label lbNN
        {
            get { return lb_NN; }
            set { lb_NN = value; }
        }
        public US_ChitietHangNhap()
        {
            InitializeComponent();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            d();
        }
    }
}
