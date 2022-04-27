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
    public partial class UCQLNV : UserControl
    {
        public UCQLNV()
        {
            InitializeComponent();
        }
        public void OpenUserControl(UserControl userControl, object sender)
        {
            this.Controls.Clear();
            this.Controls.Add((userControl));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UCQLNV_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uc = new UCQLNV_Add();
            OpenUserControl(uc, sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var uc = new UCQLNV_Edit();
            OpenUserControl(uc, sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var uc = new UCQLNV_ViewDetails();
            OpenUserControl(uc, sender);
        }
    }
}
