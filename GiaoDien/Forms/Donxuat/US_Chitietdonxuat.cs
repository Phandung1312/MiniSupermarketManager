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
    public partial class US_Chitietdonxuat : UserControl
    {
        public delegate void DelegeateReload();
        public DelegeateReload d { get; set; }
        public DateTimePicker dtNNCT
        {
            get { return dateTimeNX; }
            set { dateTimeNX = value; }
        }
        public Label lbNX
        {
            get { return lb_NX; }
            set { lb_NX = value; }
        }
        public US_Chitietdonxuat()
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
