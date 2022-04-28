namespace GiaoDien.Forms
{
    partial class US_chitietKeHang
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
            this.panelKehang = new System.Windows.Forms.Panel();
            this.bt_ShowAdminSale = new GiaoDien.Controls.RJButton();
            this.bt_Show = new GiaoDien.Controls.RJButton();
            this.bt_Close = new GiaoDien.Controls.RJButton();
            this.bt_Search = new GiaoDien.Controls.RJButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.DGV_shefl = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panelKehang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_shefl)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKehang
            // 
            this.panelKehang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKehang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelKehang.Controls.Add(this.bt_ShowAdminSale);
            this.panelKehang.Controls.Add(this.bt_Show);
            this.panelKehang.Controls.Add(this.bt_Close);
            this.panelKehang.Controls.Add(this.bt_Search);
            this.panelKehang.Controls.Add(this.txt_Search);
            this.panelKehang.Controls.Add(this.DGV_shefl);
            this.panelKehang.Controls.Add(this.label4);
            this.panelKehang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panelKehang.Location = new System.Drawing.Point(0, 0);
            this.panelKehang.Name = "panelKehang";
            this.panelKehang.Size = new System.Drawing.Size(1158, 705);
            this.panelKehang.TabIndex = 15;
            // 
            // bt_ShowAdminSale
            // 
            this.bt_ShowAdminSale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_ShowAdminSale.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_ShowAdminSale.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_ShowAdminSale.BorderRadius = 15;
            this.bt_ShowAdminSale.BorderSize = 0;
            this.bt_ShowAdminSale.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_ShowAdminSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ShowAdminSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_ShowAdminSale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_ShowAdminSale.Location = new System.Drawing.Point(686, 614);
            this.bt_ShowAdminSale.Name = "bt_ShowAdminSale";
            this.bt_ShowAdminSale.Size = new System.Drawing.Size(101, 32);
            this.bt_ShowAdminSale.TabIndex = 25;
            this.bt_ShowAdminSale.Text = "Xem chi tiết";
            this.bt_ShowAdminSale.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_ShowAdminSale.UseVisualStyleBackColor = false;
            this.bt_ShowAdminSale.Click += new System.EventHandler(this.bt_ShowAdminSale_Click);
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
            this.bt_Show.Location = new System.Drawing.Point(658, 614);
            this.bt_Show.Name = "bt_Show";
            this.bt_Show.Size = new System.Drawing.Size(101, 32);
            this.bt_Show.TabIndex = 24;
            this.bt_Show.Text = "Xem chi tiết";
            this.bt_Show.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Show.UseVisualStyleBackColor = false;
            this.bt_Show.Click += new System.EventHandler(this.bt_Show_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Close.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Close.BorderRadius = 15;
            this.bt_Close.BorderSize = 0;
            this.bt_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Close.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Close.Location = new System.Drawing.Point(318, 614);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(101, 32);
            this.bt_Close.TabIndex = 23;
            this.bt_Close.Text = "Hủy";
            this.bt_Close.TextColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Close.UseVisualStyleBackColor = false;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click_1);
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
            this.bt_Search.Location = new System.Drawing.Point(965, 115);
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
            this.txt_Search.Location = new System.Drawing.Point(836, 123);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(123, 20);
            this.txt_Search.TabIndex = 21;
            // 
            // DGV_shefl
            // 
            this.DGV_shefl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_shefl.Location = new System.Drawing.Point(73, 150);
            this.DGV_shefl.Name = "DGV_shefl";
            this.DGV_shefl.Size = new System.Drawing.Size(1027, 420);
            this.DGV_shefl.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(455, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chi tiết kệ hàng";
            // 
            // US_chitietKeHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelKehang);
            this.Name = "US_chitietKeHang";
            this.Size = new System.Drawing.Size(1150, 697);
            this.panelKehang.ResumeLayout(false);
            this.panelKehang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_shefl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKehang;
        private System.Windows.Forms.DataGridView DGV_shefl;
        private System.Windows.Forms.Label label4;
        private Controls.RJButton bt_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private Controls.RJButton bt_Close;
        private Controls.RJButton bt_Show;
        private Controls.RJButton bt_ShowAdminSale;
    }
}
