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
   

    public partial class UCSceduleSale : UserControl
    {
        public delegate void ScheduleDel();
        public ScheduleDel DelSch { get; set; }

        public UCSceduleSale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            DelSch();
        }
    }
}
