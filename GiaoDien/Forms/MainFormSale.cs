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

        public void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void OpenUserControl(UserControl userControl, object sender)
        {
            this.panelDesktop.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add((userControl));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Kehang_Click(object sender, EventArgs e)
        {
            US_KeHang us = new US_KeHang();
            us.btDel.Visible = false;
            us.btreconmend.Visible = false;
            us.btReturn.Visible = false;
            OpenUserControl(us, sender);
        }
    }
}

