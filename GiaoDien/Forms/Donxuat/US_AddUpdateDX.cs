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
            txtDX.Enabled = false;
            txtKH.Enabled = false;
            txtKHO.Enabled = false;
            txtNV.Enabled = false;
            txtSL.Enabled = false;
            txtSP.Enabled = false;
            dateTimeNX.Enabled = false;
        }
        public Button ButtonUpdate
        {
            get { return bt_update; }
            set
            {
                bt_update = value;
            }
        }
        public Label label
        {
            get { return lbDX; }
            set { lbDX = value; }
        }
        public TextBox txt1
        {
            get { return txtDX; }
            set { txtDX = value; }
        }
        public TextBox txt2
        {
            get { return txtKH; }
            set { txtKH = value; }
        }
        public TextBox txt3
        {
            get { return txtKHO; }
            set { txtKHO = value; }
        }
        public TextBox txt4
        {
            get { return txtNV; }
            set { txtNV = value; }
        }
        public TextBox txt5
        {
            get { return txtSL; }
            set { txtSL = value; }
        }
        public TextBox txt6
        {
            get { return txtSP; }
            set { txtSP = value; }
        }

        public DateTimePicker dtNX
        {
            get { return dateTimeNX; }
            set { dateTimeNX = value; }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            d();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (bt_update.Text == "Chỉnh sửa")
            {
                txtSL.Enabled = true;
                txtKH.Enabled = true;
                txtKHO.Enabled = true;
                txtNV.Enabled = true;
                dateTimeNX.Enabled = true;
                bt_update.Text = "OK";
            }
        }
    }
}
