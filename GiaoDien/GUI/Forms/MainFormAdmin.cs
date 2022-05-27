using GiaoDien.Forms.QLNV;
using GiaoDien.Forms.ThongKe.TKLuong;
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
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
            this.panelSubTK.Visible = false;
        }

        public void AddUserControl(UserControl uc)
        {
            this.panelDesktop.Controls.Clear();
            this.panelSubTK.Visible=false;
            this.panelDesktop.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        private void buttonSchdule_Click(object sender, EventArgs e)
        {
            var uc = new UCCalendar();
            AddUserControl(uc);
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            var uc = new UCProduct();
            AddUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panelSubTK.Visible = (!this.panelSubTK.Visible) ? true : false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            var uc = new UCLuong();
            AddUserControl(uc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var uc = new UCDoanhThu();
            AddUserControl(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uc = new QLNV.QLNV("");
            AddUserControl(uc);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void panelSubTK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void pictureUser_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
        