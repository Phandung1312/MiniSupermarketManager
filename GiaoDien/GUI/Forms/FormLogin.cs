using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.BLL;

namespace GiaoDien.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.btShowPass.Visible = false;
            this.btHidePass.Visible = true;
            this.txtPassWord.PasswordChar = default;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.btHidePass.Visible = false;
            this.btShowPass.Visible = true;
            this.txtPassWord.PasswordChar = '*';
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjBtLogin_Click(object sender, EventArgs e)
        {
            lNontification.Visible = false;
            string UserName = txtUser.Text;
            string PassWord=txtPassWord.Text;
            int check =BLL_Login.Instance.CheckLogin(UserName, PassWord);
            if (check == 0)
            {
                lNontification.Text = "Tài khoản hoặc Mật khẩu không đúng.Vui lòng kiểm tra lại!";
                lNontification.Visible = true;
            }
            else
            {
                if (check == 1)
                {
                    MainFormAdmin fAd=new MainFormAdmin();
                    fAd.Show();
                    return;
                }
                if (check == 2)
                {
                   MainKho fKho=new MainKho();
                    fKho.Show();
                    return;
                }
                if (check == 3)
                {
                    MainFormSale fSale= new MainFormSale();
                    fSale.Show();
                    return;
                }
            }
        }
    }
}
