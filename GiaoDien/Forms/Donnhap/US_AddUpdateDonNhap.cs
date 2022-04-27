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
    public partial class US_AddUpdateDonNhap : UserControl
    {
        public delegate void DelegeateReload();
        public DelegeateReload d { get; set; }
        public US_AddUpdateDonNhap()
        {
            InitializeComponent();
            txt_Codesupplier.Enabled = false;
            txt_Codebill.Enabled = false;
            txt_Codestaff.Enabled = false;
            txt_Money.Enabled = false;
            dateTimeNN.Enabled = false;
            txt_Note.Enabled = false;
            txt_Numbersector.Enabled = false;
        }
        public Button ButtonUpdate
        {
            get { return bt_AddUpdate; }
            set
            {            }
        }
        public Label label
        {
            get { return label1; }
            set { label1 = value; }
        }
        public TextBox txt1
        {
            get { return txt_Codebill; }
            set { txt_Codebill = value; }
        }
        public TextBox txt2
        {
            get { return txt_Codesupplier; }
            set { txt_Codesupplier = value; }
        }
        public TextBox txt3
        {
            get { return txt_Codestaff; }
            set { txt_Codestaff = value; }
        }
        public TextBox txt4
        {
            get { return txt_Money; }
            set { txt_Money = value; }
        }
        
      
        public TextBox txt7
        {
            get { return txt_Note; }
            set { txt_Note = value; }
        }
        public TextBox txt8
        {
            get { return txt_Numbersector; }
            set { txt_Numbersector = value; }
        }
        public DateTimePicker dtNN
        {
            get { return dateTimeNN; }
            set { dateTimeNN = value; }
        }
      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void Reload()
        {
            this.Visible = true;
        }
       
        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            d();
        }

        private void bt_AddUpdate_Click(object sender, EventArgs e)
        {
            US_ChitietHangNhap ds = new US_ChitietHangNhap();
            ds.Dock = DockStyle.Fill;
            if (bt_AddUpdate.Text == "Thêm")
            {
                ds.dtNNCT.Visible = false;
                ds.lbNN.Visible = false;
            }
            this.Parent.Controls.Add(ds);
            this.Visible = false;
            ds.d = new US_ChitietHangNhap.DelegeateReload(Reload);
        }
    }
}
