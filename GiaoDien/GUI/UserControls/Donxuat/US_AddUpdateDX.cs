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

    public partial class US_AddUpdateDX : UserControl
    {
        public delegate void DelegeateReload();
        public DelegeateReload d { get; set; }
        public US_AddUpdateDX()
        {
            InitializeComponent();
            txt_Number.Enabled = false;
            txt_Codebill.Enabled = false;
            txt_Codeshelf.Enabled = false;
            txt_Codewarehouse.Enabled = false;
            dateTimeNX.Enabled = false;
        }
        
        public TextBox txt2
        {
            get { return txt_Codeshelf; }
            set { txt_Codeshelf = value; }
        }
        public TextBox txt3
        {
            get { return txt_Codewarehouse; }
            set { txt_Codewarehouse = value; }
        }

        public Button btAddUpdate
        {
            get { return bt_AddUpdate; }
            set
            { }
        }
        
        public TextBox txt4
        {
            get { return txt_Number; }
            set { txt_Number = value; }
        }
        
        public DateTimePicker dtNX
        {
            get { return dateTimeNX; }
            set { dateTimeNX = value; }
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
            US_Chitietdonxuat ds = new US_Chitietdonxuat();
            ds.Dock = DockStyle.Fill;
            if (bt_AddUpdate.Text == "Thêm")
            {
                ds.dtNNCT.Visible = false;
                ds.lbNX.Visible = false;
            }
            this.Parent.Controls.Add(ds);
            this.Visible = false;
            ds.d = new US_Chitietdonxuat.DelegeateReload(Reload);
        }
    }
}
