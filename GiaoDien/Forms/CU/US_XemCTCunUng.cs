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
    public partial class US_XemCTCunUng : UserControl
    {

        public delegate void DelegeateReload();
        public DelegeateReload d { get; set; }
        public US_XemCTCunUng()
        {
            InitializeComponent();
            txt_Address.Enabled = false;
            txt_Email.Enabled = false;
            txt_Codesupplier.Enabled = false;
            txt_SDT.Enabled = false;
            txt_Namesupplier.Enabled = false;
        }
        public Button btAddUpdate
        {
            get { return bt_AddUpdate; }
            set {  }
        }
        public Button btHuy
        {
            get { return bt_Close; }
            set { }
        }
        public TextBox txtDChi
        {
            get { return txt_Address; }
            set { }
        }
        public TextBox txtemail
        {
            get { return txt_Email; }
            set {  }
        }
        public TextBox txtsdt
        {
            get { return txt_SDT; }
            set {}
        }
        public TextBox txtten
        {
            get { return txt_Namesupplier; }
            set {  }
        }
        private void bt_AddUpdate_Click(object sender, EventArgs e)
        {
            if(bt_AddUpdate.Text == "Chỉnh sửa")
            {
                txt_Address.Enabled = true;
                txt_Email.Enabled = true;
                txt_SDT.Enabled = true;
                txt_Namesupplier.Enabled = true;
                bt_AddUpdate.Text = "OK";
            }
          
        }

        private void bt_Close_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            d();
        }
    }
}
