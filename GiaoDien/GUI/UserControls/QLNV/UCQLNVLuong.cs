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
using GiaoDien.Forms.QLNV;



namespace GiaoDien.GUI.UserControls.QLNV
{
    public partial class UCQLNVLuong : UserControl
    {
        public UCQLNVLuong()
        {
            InitializeComponent();
        }

        public void AddUserControl(UserControl uc)
        {
            this.Controls.Clear();
            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void UCQLNVLuong_Load(object sender, EventArgs e)
        {

        }

        private void rjbtXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Staff.Luong();
            dataGridView2.DataSource = BLL_Staff.getNVLuong();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
          //  var uc = new UC
          //  uc.AddUserControl(uc);
          
        }



        private void rjButton3_Click(object sender, EventArgs e)
        {
            CSLuong s = new CSLuong();
            int x = 2;
            int y = 2;
            if (txtMaNV.Text == "" || txtluong.Text == "" || txtphucap.Text == "" || txtThuong.Text == "") x = 0;
            else
            {
                foreach (DataGridViewRow i in dataGridView1.Rows)

                {
                    if ((string)i.Cells[0].Value == txtMaNV.Text)
                    {
                        x = 1; break;
                    }
                }
            }
            if (x == 0)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            if (x == 1)
            {
                s.ID_Staff = txtMaNV.Text;
                s.Luong = Convert.ToInt32(txtluong.Text);
                s.PhuCap = Convert.ToInt32(txtphucap.Text);
                s.Thuong = Convert.ToInt32(txtThuong.Text);


                BLL_Staff.Instance.CapNhatLuong(s);
                MessageBox.Show("Đã Cập Nhật Thành Công");
            }
            if (x == 2)
            {
                foreach (DataGridViewRow i in dataGridView2.Rows)

                {
                    if ((string)i.Cells[0].Value == txtMaNV.Text)
                    {
                        
                        y = 1; break;
                    }
                }

                if (y==1)
                {

                    s.ID_Staff = txtMaNV.Text;
                    s.Luong = Convert.ToInt32(txtluong.Text);
                    s.PhuCap = Convert.ToInt32(txtphucap.Text);
                    s.Thuong = Convert.ToInt32(txtThuong.Text);


                    BLL_Staff.Instance.ThemLuong(s);
                    MessageBox.Show("Đã Thêm Thành Công");
                }    
                if(y==2)
                {
                    MessageBox.Show("Mã Nhân Viên Không Tồn Tại. Vui lòng nhập lại!");
                }    
            }
           
                

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaNV.Text= row.Cells[0].Value.ToString();
           
            txtluong.Text= row.Cells[1].Value.ToString();
            txtThuong.Text=row.Cells[3].Value.ToString();
            txtphucap.Text= row.Cells[2].Value.ToString();
        }
    }
}
