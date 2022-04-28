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
    public partial class UCAddPlan : UserControl
    {
        public delegate void AddPlan_Del();
        public AddPlan_Del Del { get; set; }
        public UCAddPlan()
        {
            InitializeComponent();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePickerStarte.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            Del();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
