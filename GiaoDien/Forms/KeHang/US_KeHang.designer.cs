namespace GiaoDien.Forms
{
    partial class US_KeHang
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Listshelf = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Search = new GiaoDien.Controls.RJButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Show = new GiaoDien.Controls.RJButton();
            this.bt_Del = new GiaoDien.Controls.RJButton();
            this.bt_Recommend = new GiaoDien.Controls.RJButton();
            this.bt_Return = new GiaoDien.Controls.RJButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Listshelf)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(409, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 43);
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
            this.label2.Size = new System.Drawing.Size(320, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách kệ bán hàng";
            // 
            // DGV_Listshelf
            // 
            this.DGV_Listshelf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Listshelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Listshelf.Location = new System.Drawing.Point(61, 130);
            this.DGV_Listshelf.Name = "DGV_Listshelf";
            this.DGV_Listshelf.Size = new System.Drawing.Size(1034, 467);
            this.DGV_Listshelf.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.bt_Search);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.DGV_Listshelf);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 636);
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
            this.bt_Search.Location = new System.Drawing.Point(953, 95);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(119, 29);
            this.bt_Search.TabIndex = 22;
            this.bt_Search.TabStop = false;
            this.bt_Search.Text = "Tìm kiếm";
            this.bt_Search.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Search.UseMnemonic = false;
            this.bt_Search.UseVisualStyleBackColor = false;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(824, 103);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(123, 20);
            this.txt_Search.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách kệ bán hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-13, -33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 58);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.bt_Show);
            this.panel1.Controls.Add(this.bt_Del);
            this.panel1.Controls.Add(this.bt_Recommend);
            this.panel1.Controls.Add(this.bt_Return);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 100);
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
            this.bt_Show.Location = new System.Drawing.Point(971, 6);
            this.bt_Show.Name = "bt_Show";
            this.bt_Show.Size = new System.Drawing.Size(101, 32);
            this.bt_Show.TabIndex = 9;
            this.bt_Show.Text = "Xem chi tiết";
            this.bt_Show.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Show.UseVisualStyleBackColor = false;
            this.bt_Show.Click += new System.EventHandler(this.bt_Show_Click);
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
            this.bt_Del.Location = new System.Drawing.Point(680, 6);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(101, 32);
            this.bt_Del.TabIndex = 8;
            this.bt_Del.Text = "Xóa kệ";
            this.bt_Del.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Del.UseVisualStyleBackColor = false;
            // 
            // bt_Recommend
            // 
            this.bt_Recommend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Recommend.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Recommend.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Recommend.BorderRadius = 15;
            this.bt_Recommend.BorderSize = 0;
            this.bt_Recommend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Recommend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Recommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Recommend.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Recommend.Location = new System.Drawing.Point(358, 6);
            this.bt_Recommend.Name = "bt_Recommend";
            this.bt_Recommend.Size = new System.Drawing.Size(101, 32);
            this.bt_Recommend.TabIndex = 7;
            this.bt_Recommend.Text = "Đề xuất mua";
            this.bt_Recommend.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Recommend.UseVisualStyleBackColor = false;
            // 
            // bt_Return
            // 
            this.bt_Return.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Return.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Return.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Return.BorderRadius = 15;
            this.bt_Return.BorderSize = 0;
            this.bt_Return.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Return.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Return.Location = new System.Drawing.Point(84, 6);
            this.bt_Return.Name = "bt_Return";
            this.bt_Return.Size = new System.Drawing.Size(101, 32);
            this.bt_Return.TabIndex = 6;
            this.bt_Return.Text = "Trả hàng";
            this.bt_Return.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Return.UseVisualStyleBackColor = false;
            // 
            // US_KeHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "US_KeHang";
            this.Size = new System.Drawing.Size(1166, 736);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Listshelf)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Listshelf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Controls.RJButton bt_Return;
        private Controls.RJButton bt_Recommend;
        private Controls.RJButton bt_Del;
        private Controls.RJButton bt_Show;
        private Controls.RJButton bt_Search;
        private System.Windows.Forms.TextBox txt_Search;
    }
}
