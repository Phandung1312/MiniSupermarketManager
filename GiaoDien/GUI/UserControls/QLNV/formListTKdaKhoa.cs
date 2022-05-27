using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.BLL;
using GiaoDien.DTO;

namespace GiaoDien.GUI.UserControls.QLNV
{
    public partial class formListTKdaKhoa : Form
    {
        public formListTKdaKhoa()
        {
            InitializeComponent();
        }

        string ID;
        string UN;
        private void formListTKdaKhoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Staff.ShowstaffBlock();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
           
            ID = row.Cells[0].Value.ToString();
            UN=row.Cells[6].Value.ToString();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
            BLL_Staff.Instance.MoKhoa(ID);
            MessageBox.Show("Đã Bỏ Khóa Thành Công Tài Khoản có UserName là "+UN);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Staff.TimKiemBlock(txtTK.Text);
        }
    }
}
