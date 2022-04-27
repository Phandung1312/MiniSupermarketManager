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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void RjButton1_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "kho")
            {
                MainKho fa = new MainKho();
                this.Visible = true;
                fa.Show();
            }
            if (txtUser.Text == "admin")
            {
                MainFormAdmin fa = new MainFormAdmin();
                this.Visible = true;
                fa.Show();
            }
            if(txtUser.Text == "sale")
            {
                MainFormSale fa = new MainFormSale();
                this.Visible= true;
                fa.Show();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button3.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.button3.Visible = false;
            this.button1.Visible = true;
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
