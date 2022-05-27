namespace GiaoDien.Forms.ThongKe.TKLuong
{
    partial class UCLuong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnloc = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblQuy = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.cbbloc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbquy = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rjButton1 = new GiaoDien.Controls.RJButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sắpXếpTheoTổngLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tăngDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảmDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(25, 107);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(276, 23);
            this.txtsearch.TabIndex = 49;
            // 
            // btnloc
            // 
            this.btnloc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btnloc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnloc.Location = new System.Drawing.Point(434, 12);
            this.btnloc.Margin = new System.Windows.Forms.Padding(2);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(65, 28);
            this.btnloc.TabIndex = 48;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = false;
            this.btnloc.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Image = global::GiaoDien.Properties.Resources._273793115_311509870951971_7894980111370829672_n;
            this.search.Location = new System.Drawing.Point(320, 107);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(28, 22);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search.TabIndex = 52;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(85, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1081, 427);
            this.dataGridView1.TabIndex = 54;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenChucVu";
            this.Column3.HeaderText = "Chức Vụ";
            this.Column3.Name = "Column3";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SDT";
            this.Column9.HeaderText = "Số Điện Thoại";
            this.Column9.Name = "Column9";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LuongTheoCa";
            this.Column4.HeaderText = "Lương/1 ca";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PhuCap";
            this.Column5.HeaderText = "Phụ Cấp";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Thuong";
            this.Column6.HeaderText = "Thưởng";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoCaLam";
            this.Column7.HeaderText = "Số Ca Làm";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TongLuong";
            this.Column8.HeaderText = "Tổng Lương";
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lblLoc);
            this.panel1.Controls.Add(this.lblQuy);
            this.panel1.Controls.Add(this.lblNam);
            this.panel1.Controls.Add(this.lblThang);
            this.panel1.Controls.Add(this.cbbloc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbquy);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.cbbThang);
            this.panel1.Controls.Add(this.txtnam);
            this.panel1.Controls.Add(this.btnloc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(85, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 194);
            this.panel1.TabIndex = 58;
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.Red;
            this.lblLoc.Location = new System.Drawing.Point(395, 53);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(0, 16);
            this.lblLoc.TabIndex = 70;
            // 
            // lblQuy
            // 
            this.lblQuy.AutoSize = true;
            this.lblQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuy.ForeColor = System.Drawing.Color.Red;
            this.lblQuy.Location = new System.Drawing.Point(90, 163);
            this.lblQuy.Name = "lblQuy";
            this.lblQuy.Size = new System.Drawing.Size(0, 16);
            this.lblQuy.TabIndex = 69;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.ForeColor = System.Drawing.Color.Red;
            this.lblNam.Location = new System.Drawing.Point(239, 136);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(0, 16);
            this.lblNam.TabIndex = 68;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.ForeColor = System.Drawing.Color.Red;
            this.lblThang.Location = new System.Drawing.Point(91, 107);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(0, 16);
            this.lblThang.TabIndex = 66;
            // 
            // cbbloc
            // 
            this.cbbloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbloc.FormattingEnabled = true;
            this.cbbloc.Items.AddRange(new object[] {
            "Tháng",
            "Quý"});
            this.cbbloc.Location = new System.Drawing.Point(86, 15);
            this.cbbloc.Name = "cbbloc";
            this.cbbloc.Size = new System.Drawing.Size(75, 24);
            this.cbbloc.TabIndex = 65;
            this.cbbloc.Leave += new System.EventHandler(this.cbbloc_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Lọc theo:";
            // 
            // cbbquy
            // 
            this.cbbquy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbquy.FormattingEnabled = true;
            this.cbbquy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.cbbquy.Location = new System.Drawing.Point(155, 126);
            this.cbbquy.Name = "cbbquy";
            this.cbbquy.Size = new System.Drawing.Size(45, 24);
            this.cbbquy.TabIndex = 63;
            this.cbbquy.Leave += new System.EventHandler(this.cbbquy_Leave);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(83, 133);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(34, 17);
            this.lbl.TabIndex = 62;
            this.lbl.Text = "Quý";
            // 
            // cbbThang
            // 
            this.cbbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "12",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(159, 75);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(45, 24);
            this.cbbThang.TabIndex = 61;
            this.cbbThang.Leave += new System.EventHandler(this.cbbThang_Leave);
            // 
            // txtnam
            // 
            this.txtnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnam.Location = new System.Drawing.Point(275, 103);
            this.txtnam.Margin = new System.Windows.Forms.Padding(2);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(73, 23);
            this.txtnam.TabIndex = 60;
            this.txtnam.Leave += new System.EventHandler(this.txtnam_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tháng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.search);
            this.panel2.Location = new System.Drawing.Point(638, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 194);
            this.panel2.TabIndex = 60;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(370, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(139, 24);
            this.menuStrip2.TabIndex = 55;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 20);
            this.toolStripMenuItem1.Text = "Sắp xếp  số ca làm";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem2.Text = "Tăng dần";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem3.Text = "Giảm dần";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundColor = System.Drawing.Color.White;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rjButton1.Location = new System.Drawing.Point(371, 95);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(138, 41);
            this.rjButton1.TabIndex = 54;
            this.rjButton1.Text = "Xuất File";
            this.rjButton1.TextColor = System.Drawing.SystemColors.ControlText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sắpXếpTheoTổngLươngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(25, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(143, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sắpXếpTheoTổngLươngToolStripMenuItem
            // 
            this.sắpXếpTheoTổngLươngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tăngDầnToolStripMenuItem,
            this.giảmDầnToolStripMenuItem});
            this.sắpXếpTheoTổngLươngToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sắpXếpTheoTổngLươngToolStripMenuItem.Name = "sắpXếpTheoTổngLươngToolStripMenuItem";
            this.sắpXếpTheoTổngLươngToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.sắpXếpTheoTổngLươngToolStripMenuItem.Text = "Sắp xếp  tổng lương";
            // 
            // tăngDầnToolStripMenuItem
            // 
            this.tăngDầnToolStripMenuItem.Name = "tăngDầnToolStripMenuItem";
            this.tăngDầnToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.tăngDầnToolStripMenuItem.Text = "Tăng dần";
            this.tăngDầnToolStripMenuItem.Click += new System.EventHandler(this.tăngDầnToolStripMenuItem_Click);
            // 
            // giảmDầnToolStripMenuItem
            // 
            this.giảmDầnToolStripMenuItem.Name = "giảmDầnToolStripMenuItem";
            this.giảmDầnToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.giảmDầnToolStripMenuItem.Text = "Giảm dần";
            this.giảmDầnToolStripMenuItem.Click += new System.EventHandler(this.giảmDầnToolStripMenuItem_Click);
            // 
            // UCLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCLuong";
            this.Size = new System.Drawing.Size(1247, 730);
            this.Load += new System.EventHandler(this.UCLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbquy;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbloc;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblQuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private Controls.RJButton rjButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpTheoTổngLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tăngDầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảmDầnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}
