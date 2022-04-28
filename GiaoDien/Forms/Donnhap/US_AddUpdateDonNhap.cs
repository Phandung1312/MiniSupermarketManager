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
            txtCU.Enabled = false;
            txtDG.Enabled = false;
            txtHD.Enabled = false;
            txtNV.Enabled = false;
            txtSL.Enabled = false;
            txtSP.Enabled = false;
            txtTien.Enabled = false;
            dateTimeHSD.Enabled = false;
            dateTimeNN.Enabled = false;
            dateTimeNSX.Enabled = false;
            txtCC.Enabled = false;
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
            get { return label1; }
            set { label1 = value; }
        }
        public TextBox txt1
        {
            get { return txtHD; }
            set { txtHD = value; }
        }
        public TextBox txt2
        {
            get { return txtCU; }
            set { txtCU = value; }
        }
        public TextBox txt3
        {
            get { return txtNV; }
            set { txtNV = value; }
        }
        public TextBox txt4
        {
            get { return txtTien; }
            set { txtTien = value; }
        }
        public TextBox txt5
        {
            get { return txtSP; }
            set { txtSP = value; }
        }
        public TextBox txt6
        {
            get { return txtDG; }
            set { txtDG = value; }
        }
        public TextBox txt7
        {
            get { return txtCC; }
            set { txtCC = value; }
        }
        public TextBox txt8
        {
            get { return txtSL; }
            set { txtSL = value; }
        }
        public DateTimePicker dtNN
        {
            get { return dateTimeNN; }
            set { dateTimeNN = value; }
        }
        public DateTimePicker dtNSX
        {
            get { return dateTimeNSX; }
            set { dateTimeNSX = value; }
        }
        public DateTimePicker dtHSD
        {
            get { return dateTimeHSD; }
            set { dateTimeHSD = value; }
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
                txtDG.Enabled = true;
                txtNV.Enabled = true;
                txtSL.Enabled = true;
                dateTimeHSD.Enabled = true;
                dateTimeNN.Enabled = true;
                dateTimeNSX.Enabled = true;
                bt_update.Text = "OK";
            }
        }
    }
}
