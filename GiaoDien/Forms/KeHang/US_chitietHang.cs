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
    public partial class US_CTkeHang : UserControl
    {
        public delegate void DelegeateReload();
        public DelegeateReload d { get; set; }
        public US_CTkeHang()
        {
            InitializeComponent();
            txt_CodeShelf.Enabled = false;
            txt_Codeproduct.Enabled = false;
            txtNumber.Enabled = false;
        }
        public Button close
        {
            get { return bt_Close; }
            set {  }
        }
        public Button update
        {
            get { return bt_Update; }
            set {  }
        }
      
        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            d();
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            txtNumber.Enabled = true;
            if (bt_Update.Text == "Chỉnh sửa")
                bt_Update.Text = "OK";
        }
    }
}
