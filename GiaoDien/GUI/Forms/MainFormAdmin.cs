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
    }
}
        