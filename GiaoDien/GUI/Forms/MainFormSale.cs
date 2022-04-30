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
    public partial class MainFormSale : Form
    {
        private Form activeForm;
        public MainFormSale()
        {
            InitializeComponent();
           
        }
        public void AddUserControl(UserControl uc)
        {
            this.panelDesktop.Controls.Clear();
            this.panelDesktop.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }







        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSchdule_Click(object sender, EventArgs e)
        {
            var uc = new UCCalendar();
            AddUserControl(uc);
        }
    }
}

