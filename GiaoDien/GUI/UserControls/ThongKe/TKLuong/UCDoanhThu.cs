using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GiaoDien.BLL;
using GiaoDien.DTO;
using System.Text.RegularExpressions;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace GiaoDien.Forms.ThongKe.TKLuong
{
    public partial class UCDoanhThu : UserControl
    {
        string x = "", y = "";

        public UCDoanhThu()
        {
            InitializeComponent();
        }
        public void AddUserControl(UserControl uc)
        {
           // this.panelTK.Controls.Clear();
          //  this.panelSubTK.Visible = false;
          //  this.panelTK.Controls.Add(uc);
          //  uc.Dock = DockStyle.Fill;
        }
      
       
        private void UCDoanhThu_Load(object sender, EventArgs e)
        {
            cbbsearch.Visible = false;
            dateTimePicker1.Visible = false;
        }

       

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

        private void txtnam_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^(20)+[0-9]{2}$");
           // if (cbbloc.Text == "Quý" || cbbloc.Text == "Tháng")
          //  {
                if (string.IsNullOrEmpty(txtnam.Text)) lblNam.Text = "Năm không được để trống.";
                else
                {
                    if (r.IsMatch(txtnam.Text) == false)
                        lblNam.Text = "Năm không hợp lệ..";
                    else
                        lblNam.Text = "";
                }
          //  }
        }

        private void Luong()
        {
            quy();
            
            if (cbbloc.Text == "")
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
            int sc = dataGridView1.Rows.Count;
            double tongluong = 0;
            for (int i = 0; i < sc - 1; i++)
                tongluong += double.Parse(dataGridView1.Rows[i].Cells["TongLuong"].Value.ToString());
            lbltinh.Text = tongluong.ToString();


        }
        private void quy()
        {
            

            if (cbbquy.Text == "1" || cbbquy.Text == "01")
            {
                x = "1"; y = "3";
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
        }
        private void SP()
        {
            quy();
            if (cbbloc.Text == "")
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
                    if (cbbThang.Text != "" && txtnam.Text != "") dataGridView1.DataSource = BLL_stats.ShowThongKeSPThang(cbbThang.Text, txtnam.Text);
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
                    if (cbbquy.Text != "" && txtnam.Text != "") dataGridView1.DataSource = BLL_stats.ShowThongKeSPQuy(x, y, txtnam.Text);
                }
            }
            int sc = dataGridView1.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += double.Parse(dataGridView1.Rows[i].Cells["ThanhTien"].Value.ToString());
            lbltinh.Text = thanhtien.ToString();

        }
        private void HD()
        {
            quy();
            if (cbbloc.Text == "")
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
                    if (cbbThang.Text != "" && txtnam.Text != "") dataGridView1.DataSource = BLL_stats.ShowThongKeHDThang(cbbThang.Text, txtnam.Text);
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
                    if (cbbquy.Text != "" && txtnam.Text != "") dataGridView1.DataSource = BLL_stats.ShowThongKeHDQuy(x, y, txtnam.Text);
                }
            }
            int sc = dataGridView1.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += double.Parse(dataGridView1.Rows[i].Cells["TongTien"].Value.ToString());
            lbltinh.Text = thanhtien.ToString();

        }
        private void DoanhThu()
        {
            if(lblLoc.Text=="") dataGridView1.DataSource = BLL_stats.ShowThongKeDoanhThu(txtnam.Text);
            int sc = dataGridView1.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += double.Parse(dataGridView1.Rows[i].Cells["DoanhThu"].Value.ToString());
            lbltinh.Text = txtnam.Text +" : "+ thanhtien.ToString();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            if(rbtnLuong.Checked)
            {
                Luong();
            }    
            if(rbtnSP.Checked)
            {
                SP();
            }    
            if(rbtnHD.Checked)
            {
                HD();
                cbbsearch.Visible = true;
                txtsearch.Visible = false;
            }   
            if(rbtndoanhthu.Checked)
            {
                DoanhThu();
            }    
        }

        private void btnSX_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource==null)
            {

            }
            else
            {


                if (cbbSX.Text == "Tổng lương")
                {
                    if (rbtnTang.Checked)
                    {
                        dataGridView1.Sort(dataGridView1.Columns["TongLuong"], ListSortDirection.Ascending);
                    }
                    else
                    {
                        if (rbtnGiam.Checked)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["TongLuong"], ListSortDirection.Descending);
                        }
                        else
                            MessageBox.Show("Vui lòng chọn hình thức sắp xếp Tằng/Giảm.");
                    }
                }

                if (cbbSX.Text == "Số ca làm")

                {
                    if (rbtnTang.Checked)
                    {
                        dataGridView1.Sort(dataGridView1.Columns["SocaLam"], ListSortDirection.Ascending);
                    }
                    else
                    {
                        if (rbtnGiam.Checked)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["SocaLam"], ListSortDirection.Descending);
                        }
                        else
                            MessageBox.Show("Vui lòng chọn hình thức sắp xếp Tằng/Giảm.");
                    }
                }
                if (cbbSX.Text == "Thành tiền")
                {
                    if (rbtnTang.Checked)
                    {
                        dataGridView1.Sort(dataGridView1.Columns["ThanhTien"], ListSortDirection.Ascending);
                    }
                    else
                    {
                        if (rbtnGiam.Checked)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["ThanhTien"], ListSortDirection.Descending);
                        }
                        else
                            MessageBox.Show("Vui lòng chọn hình thức sắp xếp Tằng/Giảm.");
                    }

                }
                if (cbbSX.Text == "Số lượng")
                {
                    if (rbtnTang.Checked)
                    {
                        dataGridView1.Sort(dataGridView1.Columns["SoLuong"], ListSortDirection.Ascending);
                    }
                    else
                    {
                        if (rbtnGiam.Checked)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["SoLuong"], ListSortDirection.Descending);
                        }
                        else
                            MessageBox.Show("Vui lòng chọn hình thức sắp xếp Tằng/Giảm.");
                    }

                }
                if (cbbSX.Text == "Tháng")
                {
                    if (rbtnTang.Checked)
                    {
                        dataGridView1.Sort(dataGridView1.Columns["Thang"], ListSortDirection.Ascending);
                    }
                    else
                    {
                        if (rbtnGiam.Checked)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Thang"], ListSortDirection.Descending);
                        }
                        else
                            MessageBox.Show("Vui lòng chọn hình thức sắp xếp Tằng/Giảm.");
                    }

                }
                if (cbbSX.Text == "Doanh thu")
                {
                    if (rbtnTang.Checked)
                    {
                        dataGridView1.Sort(dataGridView1.Columns["DoanhThu"], ListSortDirection.Ascending);
                    }
                    else
                    {
                        if (rbtnGiam.Checked)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["DoanhThu"], ListSortDirection.Descending);
                        }
                        else
                            MessageBox.Show("Vui lòng chọn hình thức sắp xếp Tằng/Giảm.");
                    }

                }
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            quy();
            if (rbtnLuong.Checked)
            {
               
                if (cbbloc.Text == "Tháng")
                {


                    dataGridView1.DataSource = BLL_stats.SearchThongKeLuongThang(cbbThang.Text, txtnam.Text, txtsearch.Text);
                }
                else
                {
                    if (cbbloc.Text == "Quý")

                    {
                        dataGridView1.DataSource = BLL_stats.SearchThongKeLuongQuy(x,y, txtnam.Text, txtsearch.Text);
                    }

                }    
            }
            if (rbtnSP.Checked)
            {
                if (cbbloc.Text == "Tháng")
                {


                    dataGridView1.DataSource = BLL_stats.SearchThongKeSPThang(cbbThang.Text, txtnam.Text, txtsearch.Text);
                }
                else
                {
                    if (cbbloc.Text == "Quý")

                    {
                        dataGridView1.DataSource = BLL_stats.SearchThongKeSPQuy(x, y, txtnam.Text, txtsearch.Text);
                    }

                }

            }
            if (rbtnHD.Checked)
            {




                if (cbbloc.Text == "Tháng")
                {

                    if (cbbsearch.Text == "Thời gian")
                    {
                        dataGridView1.DataSource = BLL_stats.SearchthoigianHDThang(cbbThang.Text, txtnam.Text, dateTimePicker1.Value.ToString("dd"), dateTimePicker1.Value.ToString("MM"), dateTimePicker1.Value.ToString("yyyy"));
                    }
                    else
                    {

                        dataGridView1.DataSource = BLL_stats.SearchThongKeHDThang(cbbThang.Text, txtnam.Text, txtsearch.Text);
                    }
                }
                else
                {
                    if (cbbloc.Text == "Quý")

                    {
                        if (cbbsearch.Text == "Thời gian")
                        {
                            dataGridView1.DataSource = BLL_stats.SearchthoigianHDQuy(x, y, txtnam.Text, dateTimePicker1.Value.ToString("dd"), dateTimePicker1.Value.ToString("MM"), dateTimePicker1.Value.ToString("yyyy"));
                        }
                        else
                        {

                            dataGridView1.DataSource = BLL_stats.SearchThongKeHDQuy(x, y, txtnam.Text, txtsearch.Text);
                        }

                    }
                }

                
            }
            if (rbtndoanhthu.Checked)
            {

                dataGridView1.DataSource = BLL_stats.SearchDoanhThu(txtnam.Text, txtsearch.Text);
            }
        }

        private void rbtnHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHD.Checked)
            {
                lbltinh.Text = "";
                txtnam.Text = "";
                lblNam.Text = "";
                cbbloc.Text = "";
                cbbquy.Text = "";
                cbbThang.Text="";
                
                cbbSX.Items.Clear();
                cbbSX.Items.Add("Thành tiền");
                cbbSX.Items.Add("Giờ xuất");
                lblTong.Text = "TỔNG TIỀN THU ";
            }
            
        }
        private void rbtndoanhthu_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtndoanhthu.Checked)
            {
                lbltinh.Text = "";
                txtnam.Text = "";
                lblNam.Text = "";
                jbtnBD.Visible = true;
                cbbloc.Enabled = false;
                cbbquy.Enabled = false;
                cbbThang.Enabled=false;
                lblTong.Text = "TỔNG DOANH THU NĂM ";
                cbbSX.Items.Clear();
                cbbSX.Items.Add("Doanh thu");
                cbbSX.Items.Add("Tháng");
            }    
            else
            {
                jbtnBD.Visible = false;
                cbbloc.Enabled = true;
                cbbquy.Enabled = true;
                cbbThang.Enabled = true;
            }

        }
        private void rbtnSP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSP.Checked)
            {
                lbltinh.Text = "";
                txtnam.Text = "";
                lblNam.Text = "";
                cbbloc.Text = "";
                cbbquy.Text = "";
                cbbThang.Text = "";
              
                cbbSX.Items.Clear();
                cbbSX.Items.Add("Thành tiền");
                cbbSX.Items.Add("Số lượng");
                lblTong.Text = "TỔNG TIỀN THU ";
            }
        }

       
        private void rbtnLuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLuong.Checked)
            {
                lbltinh.Text = "";
                txtnam.Text = "";
                lblNam.Text = "";
                cbbloc.Text = "";
                cbbquy.Text = "";
                cbbThang.Text = "";
               
                cbbSX.Items.Clear();
                cbbSX.Items.Add("Tổng lương");
                cbbSX.Items.Add("Số ca làm");
                lblTong.Text = "TỔNG TIỀN LƯƠNG CHI ";


            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void jbtnBD_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";

            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";
         //   chart1.Series["Series2"] = "Cylinder";
         for(int i = 0; i <= dataGridView1.RowCount-2; i++)
            {
                chart1.Series["Series2"].Points.AddXY(Convert.ToInt32( dataGridView1.Rows[i].Cells["Thang"].Value.ToString()), Convert.ToInt32(dataGridView1.Rows[i].Cells["DoanhThu"].Value.ToString()));
            }


        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

            }
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j=0;j<dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel 2007 or higher (.xlsx) | *.xlsx";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(sf.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất không file thành công!\n" + ex.Message);
                }

            }
        }

        private void cbbloc_Leave(object sender, EventArgs e)
        {
            if(cbbloc.Text =="Tháng") {cbbquy.Enabled = false;cbbThang.Enabled = true;}
            else {cbbquy.Enabled = true; cbbThang.Enabled = false;}
        }

        private void cbbsearch_Leave(object sender, EventArgs e)
        {
            if (cbbsearch.Text == "Thời gian")
            {
                dateTimePicker1.Visible = true;
                txtsearch.Visible = false;
            }
            else
            {
                dateTimePicker1.Visible = false;
                txtsearch.Visible = true;
            }    
        }

        private void cbbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbsearch.SelectedIndex == 0)
            {
                dateTimePicker1.Visible = true;
                txtsearch.Visible = false;
            }    
            if(cbbsearch.SelectedIndex == 1)
            {
                dateTimePicker1.Visible = false;
                txtsearch.Visible = true;
            }
        }

        private void cbbloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbloc.SelectedIndex == 0)
            {
                cbbquy.Enabled = false; cbbThang.Enabled = true;
            }
            if (cbbloc.SelectedIndex == 1)
            {
                cbbquy.Enabled = true; cbbThang.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
