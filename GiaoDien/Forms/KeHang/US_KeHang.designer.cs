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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_TraHang = new System.Windows.Forms.Button();
            this.bt_xoaKe = new System.Windows.Forms.Button();
            this.bt_xem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_dexuat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-55, -103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 43);
            this.panel3.TabIndex = 8;
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
            // BT_TraHang
            // 
            this.BT_TraHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_TraHang.BackColor = System.Drawing.Color.Red;
            this.BT_TraHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TraHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BT_TraHang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BT_TraHang.Location = new System.Drawing.Point(61, 8);
            this.BT_TraHang.Name = "BT_TraHang";
            this.BT_TraHang.Size = new System.Drawing.Size(104, 23);
            this.BT_TraHang.TabIndex = 2;
            this.BT_TraHang.Text = "Trả hàng về kho";
            this.BT_TraHang.UseVisualStyleBackColor = false;
            // 
            // bt_xoaKe
            // 
            this.bt_xoaKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_xoaKe.BackColor = System.Drawing.Color.Red;
            this.bt_xoaKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoaKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xoaKe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_xoaKe.Location = new System.Drawing.Point(643, 8);
            this.bt_xoaKe.Name = "bt_xoaKe";
            this.bt_xoaKe.Size = new System.Drawing.Size(117, 23);
            this.bt_xoaKe.TabIndex = 2;
            this.bt_xoaKe.Text = "Xóa kệ";
            this.bt_xoaKe.UseVisualStyleBackColor = false;
            // 
            // bt_xem
            // 
            this.bt_xem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_xem.BackColor = System.Drawing.Color.Red;
            this.bt_xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_xem.Location = new System.Drawing.Point(253, 8);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(106, 23);
            this.bt_xem.TabIndex = 2;
            this.bt_xem.Text = "Xem chi tiết";
            this.bt_xem.UseVisualStyleBackColor = false;
            this.bt_xem.Click += new System.EventHandler(this.bt_xem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_TraHang);
            this.panel1.Controls.Add(this.bt_xoaKe);
            this.panel1.Controls.Add(this.bt_xem);
            this.panel1.Controls.Add(this.bt_dexuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 52);
            this.panel1.TabIndex = 9;
            // 
            // bt_dexuat
            // 
            this.bt_dexuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_dexuat.BackColor = System.Drawing.Color.Red;
            this.bt_dexuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dexuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_dexuat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_dexuat.Location = new System.Drawing.Point(448, 8);
            this.bt_dexuat.Name = "bt_dexuat";
            this.bt_dexuat.Size = new System.Drawing.Size(102, 23);
            this.bt_dexuat.TabIndex = 2;
            this.bt_dexuat.Text = "Đề xuất mua";
            this.bt_dexuat.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 412);
            this.panel2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 287);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(241, 32);
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
            // US_KeHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "US_KeHang";
            this.Size = new System.Drawing.Size(831, 464);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_TraHang;
        private System.Windows.Forms.Button bt_xoaKe;
        private System.Windows.Forms.Button bt_xem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_dexuat;
    }
}
