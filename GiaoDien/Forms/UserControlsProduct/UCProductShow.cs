﻿using System;
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
    
    public partial class UCProductShow : UserControl
    {
        public delegate void MyDelegate();
        public MyDelegate delReload { get; set; }
        public UCProductShow()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            delReload();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
