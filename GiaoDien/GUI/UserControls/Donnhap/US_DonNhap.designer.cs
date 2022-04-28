namespace GiaoDien.Forms
{
    partial class US_DonNhap
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
            this.bt_Add = new GiaoDien.Controls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Show = new GiaoDien.Controls.RJButton();
            this.bt_Del = new GiaoDien.Controls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Bill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Search = new GiaoDien.Controls.RJButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bill)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Add.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Add.BorderRadius = 15;
            this.bt_Add.BorderSize = 0;
            this.bt_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Add.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Add.Location = new System.Drawing.Point(982, 11);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(101, 32);
            this.bt_Add.TabIndex = 6;
            this.bt_Add.Text = "Thêm đơn";
            this.bt_Add.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.bt_Add);
            this.panel1.Controls.Add(this.bt_Show);
            this.panel1.Controls.Add(this.bt_Del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 141);
            this.panel1.TabIndex = 15;
            // 
            // bt_Show
            // 
            this.bt_Show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Show.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Show.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Show.BorderRadius = 15;
            this.bt_Show.BorderSize = 0;
            this.bt_Show.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Show.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Show.Location = new System.Drawing.Point(524, 11);
            this.bt_Show.Name = "bt_Show";
            this.bt_Show.Size = new System.Drawing.Size(101, 32);
            this.bt_Show.TabIndex = 5;
            this.bt_Show.Text = "Xem chi tiết";
            this.bt_Show.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Show.UseVisualStyleBackColor = false;
            this.bt_Show.Click += new System.EventHandler(this.bt_Show_Click_1);
            // 
            // bt_Del
            // 
            this.bt_Del.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Del.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Del.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Del.BorderRadius = 15;
            this.bt_Del.BorderSize = 0;
            this.bt_Del.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Del.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Del.Location = new System.Drawing.Point(83, 11);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(101, 32);
            this.bt_Del.TabIndex = 4;
            this.bt_Del.Text = "Xóa đơn";
            this.bt_Del.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Del.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(426, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 43);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(18, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách đơn nhập";
            // 
            // DGV_Bill
            // 
            this.DGV_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Bill.Location = new System.Drawing.Point(61, 130);
            this.DGV_Bill.Name = "DGV_Bill";
            this.DGV_Bill.Size = new System.Drawing.Size(1040, 459);
            this.DGV_Bill.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.bt_Search);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.DGV_Bill);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 736);
            this.panel2.TabIndex = 16;
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_Search.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Search.BorderRadius = 15;
            this.bt_Search.BorderSize = 0;
            this.bt_Search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Search.ImageKey = "(none)";
            this.bt_Search.Location = new System.Drawing.Point(964, 95);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(119, 29);
            this.bt_Search.TabIndex = 18;
            this.bt_Search.TabStop = false;
            this.bt_Search.Text = "Tìm kiếm";
            this.bt_Search.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Search.UseMnemonic = false;
            this.bt_Search.UseVisualStyleBackColor = false;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(835, 103);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(123, 20);
            this.txt_Search.TabIndex = 17;
            // 
            // US_DonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "US_DonNhap";
            this.Size = new System.Drawing.Size(1166, 736);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RJButton bt_Add;
        private System.Windows.Forms.Panel panel1;
        private Controls.RJButton bt_Show;
        private Controls.RJButton bt_Del;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Bill;
        private System.Windows.Forms.Panel panel2;
        private Controls.RJButton bt_Search;
        private System.Windows.Forms.TextBox txt_Search;
    }
}
