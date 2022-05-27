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
using System.Text.RegularExpressions;

namespace GiaoDien.Forms.ThongKe.TKLuong
{
    public partial class UCLuong : UserControl
    {
        public UCLuong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UCLuong_Load(object sender, EventArgs e)
        {

            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string x="", y=""; 
            
            if(cbbquy.Text == "1"|| cbbquy.Text == "01")
            {
                x = "1";y = "3";
            }
            if (cbbquy.Text == "2" || cbbquy.Text == "02")
            {
                x = "4"; y = "6";
            }
            if (cbbquy.Text == "3" || cbbquy.Text == "03")
            {
                x = "7"; y = "9";
            }
            if (cbbquy.Text == "4" || cbbquy.Text == "04")
            {
                x = "10"; y = "12";
            }

            if (cbbloc.Text=="")
            {
                lblLoc.Text = "Chọn hình thức cần lọc.";
                MessageBox.Show("Bạn chưa chọn hình thức lọc.");
            }
            if (cbbloc.Text == "Tháng") 
           
            {
                lblLoc.Text = "";
                if (lblThang.Text == "" && lblNam.Text == "")
                {
                    if (cbbThang.Text == "" && txtnam.Text == "") MessageBox.Show("Vui lòng chọn tháng và năm.");
                    if (cbbThang.Text == "" && txtnam.Text != "") MessageBox.Show("Vui lòng chọn tháng.");
                    if (cbbThang.Text != "" && txtnam.Text == "") MessageBox.Show("Vui lòng chọn năm.");
                    if (cbbThang.Text != "" && txtnam.Text != "") dataGridView1.DataSource = BLL_stats.ShowThongKeLuongThang(cbbThang.Text, txtnam.Text);
                }
            }
           if (cbbloc.Text == "Quý")
           
            {
                lblLoc.Text = "";
                if (lblQuy.Text == "" && lblNam.Text == "")
                {

                    if (cbbquy.Text == "" && txtnam.Text == "") MessageBox.Show("Vui lòng chọn quý và năm.");
                    if (cbbquy.Text == "" && txtnam.Text != "") MessageBox.Show("Vui lòng chọn tháng.");
                    if (cbbquy.Text != "" && txtnam.Text == "") MessageBox.Show("Vui lòng chọn năm.");
                    if (cbbquy.Text != "" && txtnam.Text != "") dataGridView1.DataSource = BLL_stats.ShowThongKeLuongQuy(x, y, txtnam.Text);
                }
            }

           
        }

     //   private void sắpXếpTheoTổngLươngToolStripMenuItem_Click(object sender, EventArgs e)
      //  {

       // }

       // private void chọnNămToolStripMenuItem_Click(object sender, EventArgs e)
      //  {
       //     dataGridView1.DataSource = BLL_Staff.ShowThongKeLuong(toolStripComboBox1.Text, toolStripComboBox2.Text);
      //  }

        private void cbbThang_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^(01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)$");
            if (cbbloc.Text == "Tháng")
            {
                if (string.IsNullOrEmpty(cbbThang.Text)) lblThang.Text = "Tháng không được để trống.";
                else
                {
                    if (r.IsMatch(cbbThang.Text) == false)
                        lblThang.Text = "Tháng không hợp lệ..";
                    else
                        lblThang.Text = "";
                }    
            }


            

        }

        private void cbbquy_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^(01|02|03|04|1|2|3|4)$");
            if (cbbloc.Text == "Quý")
            {
                if (string.IsNullOrEmpty(cbbquy.Text)) lblQuy.Text = "Quý không được để trống.";
                else
                {
                    if (r.IsMatch(cbbquy.Text) == false)
                        lblQuy.Text = "Quý không hợp lệ..";
                    else
                        lblQuy.Text = "";
                }
            }

        }

        private void txtnam_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^(20)+[0-9]{2}$");
            if (cbbloc.Text == "Quý" || cbbloc.Text == "Tháng")
            {
                if (string.IsNullOrEmpty(txtnam.Text)) lblNam.Text = "Năm không được để trống.";
                else
                {
                    if (r.IsMatch(txtnam.Text) == false)
                        lblNam.Text = "Năm không hợp lệ..";
                    else
                        lblNam.Text = "";
                }
            }
        }

       // private void panel1_Paint(object sender, PaintEventArgs e)
      //  {
       //     dataGridView1.DataSource = BLL_Staff.TimKiem(txtsearch.Text);
       // }

        private void tăngDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[8], ListSortDirection.Ascending);
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Staff.TimKiem(txtsearch.Text);
        }

        private void cbbloc_Leave(object sender, EventArgs e)
        {
            if (cbbloc.Text == "Tháng") lblQuy.Text = "";
            if (cbbloc.Text == "Quý") lblThang.Text = "";
        }

        private void giảmDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[8], ListSortDirection.Descending);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Ascending);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Descending);
        }
    }
}
