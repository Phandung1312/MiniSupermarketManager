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
            this.bt_TK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_XemCTHang = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelKehang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKehang
            // 
            this.panelKehang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKehang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelKehang.Controls.Add(this.bt_TK);
            this.panelKehang.Controls.Add(this.textBox1);
            this.panelKehang.Controls.Add(this.dataGridView1);
            this.panelKehang.Controls.Add(this.bt_XemCTHang);
            this.panelKehang.Controls.Add(this.bt_close);
            this.panelKehang.Controls.Add(this.label4);
            this.panelKehang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panelKehang.Location = new System.Drawing.Point(0, 0);
            this.panelKehang.Name = "panelKehang";
            this.panelKehang.Size = new System.Drawing.Size(1158, 705);
            this.panelKehang.TabIndex = 15;
            // 
            // bt_TK
            // 
            this.bt_TK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_TK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_TK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_TK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_TK.Location = new System.Drawing.Point(991, 111);
            this.bt_TK.Name = "bt_TK";
            this.bt_TK.Size = new System.Drawing.Size(113, 29);
            this.bt_TK.TabIndex = 14;
            this.bt_TK.Text = "Tìm kiếm";
            this.bt_TK.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(780, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1027, 420);
            this.dataGridView1.TabIndex = 12;
            // 
            // bt_XemCTHang
            // 
            this.bt_XemCTHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_XemCTHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_XemCTHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_XemCTHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_XemCTHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_XemCTHang.Location = new System.Drawing.Point(755, 617);
            this.bt_XemCTHang.Name = "bt_XemCTHang";
            this.bt_XemCTHang.Size = new System.Drawing.Size(113, 29);
            this.bt_XemCTHang.TabIndex = 10;
            this.bt_XemCTHang.Text = "Xem chi tiết hàng";
            this.bt_XemCTHang.UseVisualStyleBackColor = false;
            this.bt_XemCTHang.Click += new System.EventHandler(this.bt_XemCTHang_Click);
            // 
            // bt_close
            // 
            this.bt_close.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_close.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_close.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_close.Location = new System.Drawing.Point(289, 617);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(113, 29);
            this.bt_close.TabIndex = 11;
            this.bt_close.Text = "Hủy";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKehang;
        private System.Windows.Forms.Button bt_TK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_XemCTHang;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label4;
    }
}
