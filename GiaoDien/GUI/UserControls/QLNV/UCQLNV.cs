using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiaoDien.BLL;
using GiaoDien.DTO;
using System.Windows.Forms;
using GiaoDien.GUI.UserControls.QLNV;
using System.Text.RegularExpressions;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;


namespace GiaoDien.Forms.QLNV
{
    public partial class QLNV : UserControl
    {

        public delegate void MyDel(int ID_Pos, string search);
        public MyDel del { get; set; }
        public string ID_Staff { get; set; }

        public QLNV(string id_staff)
        {
            InitializeComponent();
            ID_Staff = id_staff;
            cbbCV.Items.AddRange(BLL_Staff.Instance.GetCBB().ToArray());
            Gui();

        }
        public void Gui()
        {
            if (ID_Staff != "")
            {
                Staff s = BLL_Staff.Instance.GetStaffByIDStaff(ID_Staff);
                lblMaNV.Text = s.ID_Staff;
                txtten.Text = s.Name_Staff;

                foreach (CBB_Items item in cbbCV.Items)
                {
                    if ((int)item.Value == s.ID_Pos)
                    {
                        cbbCV.SelectedItem = item;
                        break;
                    }

                }
            }
        }

        public void AddUserControl(UserControl uc)
        {
            this.Controls.Clear();
            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        public bool ValidateSDT(TextBox tb)
        {
            Regex r = new Regex(@"^(09|03|07|08|05)+([0-9]{8})$");
            if (r.IsMatch(tb.Text))
                return true;
            else
                return false;
        }

        public bool ValidateEmail(TextBox tb)
        {
            //  Regex r = new Regex
            string pattern = "([a-z0-9A-Z]([-\\.\\w]*[a-z0-9A-Z])*@([a-z0-9A-Z][-\\w]*[a-z0-9A-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(tb.Text, pattern))
                return true;
            else
                return false;
        }
        public bool TextBox_Validation(TextBox tb, Label lb, string header)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                lb.Text = header + " không được để trống.";
                lb.Visible = true;
                return false;
            }

            else
            {
                lb.Text = "";

                return true;
            }

        }
        public bool textBox_ValidateSDT()
        {
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                lblSDT.Text = " SDT không được để trống.";
                lblSDT.Visible = true;
                return false;
            }

            else
            {
                if (ValidateSDT(txtSDT) == false)
                {
                    lblSDT.Text = "Số điện thoại không hợp lệ.";
                    return false;
                }
                else
                {
                    lblSDT.Text = "";

                    return true;
                }
            }
        }
        public bool textBox_ValidateEmail()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.Text = " Email không được để trống.";
                lblEmail.Visible = true;
                return false;
            }

            else
            {
                if (ValidateEmail(txtEmail) == false)
                {
                    lblEmail.Text = "Email không hợp lệ.";
                    return false;
                }
                else
                {
                    lblEmail.Text = "";

                    return true;
                }
            }
        }
        public void lable(Label lb)
        {
            lb.Text = "";
        }
        public void alllable()
        {
            lable(lblChucVu);
            lable(lblDiaChi);
            lable(lblEmail);
            lable(lblGioiTinh);
            //  lable(lblLuong);
            lable(lblNsinh);
            lable(lblSDT);
            lable(lblTen);
            lable(lblUN);
        }
        public void txt(TextBox tb)
        {
            tb.Text = "";
        }
        public void cbb(ComboBox cb)
        {
            cb.Text = "";
        }
        public void alltxt()
        {
            txt(txtdiachi);
            txt(txtEmail);
            txt(txtSDT);
            txt(txtten);
            txt(txtUN);
            cbb(cbbCV);
            cbb(cbbGT);

        }
        public bool date_Validation(DateTimePicker tb, Label lb, string header)
        {
            if (string.IsNullOrEmpty(tb.Value.ToString()))
            {
                lb.Text = header + " không được để trống.";
                lb.Visible = true;
                return false;
            }
            else
            {
                lb.Text = "";
                return true;
            }
        }
        public bool ComboBox_Validation(ComboBox tb, Label lb, string header)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                lb.Text = header + " không được để trống.";
                lb.Visible = true;
                return false;
            }
            else
            {
                lb.Text = "";
                return true;
            }
        }
        public bool VerificationFunction()
        {
            if (TextBox_Validation(txtten, lblTen, "Tên") == false || date_Validation(dateTimePicker1, lblNsinh, "Ngày sinh") == false
                || textBox_ValidateSDT() == false || TextBox_Validation(txtdiachi, lblDiaChi, "Địa chỉ") == false
                || textBox_ValidateEmail() == false || TextBox_Validation(txtUN, lblUN, "UserName") == false
                || ComboBox_Validation(cbbGT, lblGioiTinh, "Giới Tính") == false || ComboBox_Validation(cbbCV, lblChucVu, "Chức vụ") == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void show(int ID_Pos, string search)
        {
            List<Staff> data = new List<Staff>();
            if (search == "")
            {
                dataGridView1.DataSource = BLL_Staff.Instance.GetStaffByIDPosition(ID_Pos);
                return;
            }
            else
            {
                data = BLL_Staff.Instance.Search(search, ID_Pos);
            }
            dataGridView1.DataSource = data;

        }
        private void rjButton4_Click(object sender, EventArgs e)
        {
            //var uc = new UCQLNVAdd("");
            //uc.del = new UCQLNVAdd.MyDel(show);
            // AddUserControl(uc);
            if (VerificationFunction() == false)
            {
                MessageBox.Show("Dữ liệu chưa đủ mời nhập thêm.");

            }

            else
            {

                Staff s = new Staff();

                s.ID_Staff = lblMaNV.Text;
                s.Name_Staff = txtten.Text;
                s.Gender = cbbGT.Text;
                s.Phone_number = txtSDT.Text;
                s.Address = txtdiachi.Text;
                s.User_Name = txtUN.Text;
                s.ID_Pos = (int)((CBB_Items)cbbCV.SelectedItem).Value;
                s.Email = txtEmail.Text;
                s.Date_Of_Birth = dateTimePicker1.Value;
                if (MessageBox.Show("Ban đã chắc chắn với thay đổi của mình ", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BLL_Staff.Instance.CapNhat(s);
                    MessageBox.Show("Đã Cập Nhật Thành Công");
                    dataGridView1.DataSource = BLL_Staff.Showstaff();
                }

            }

        }



        private void rjButton1_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            CSLuong cs = new CSLuong();

            //if (txtdiachi.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || txtUN.Text == "" || cbbCV.Text == "" || txtGT.Text == "")
            if (VerificationFunction() == false)
            {

                MessageBox.Show("Dữ liệu chưa đủ mời nhập thêm.");
                //TextBox_Validation(txtten, lblTen, "Tên");
                // date_Validation(dateTimePicker1, lblNsinh, "Ngày sinh");
                //textBox_ValidateSDT();
                // TextBox_Validation(txtdiachi, lblDiaChi, "Địa chỉ");
                // TextBox_Validation(txtEmail, lblEmail, "Email");
                // TextBox_Validation(txtUN, lblUN, "UserName");
                //ComboBox_Validation(cbbGT, lblGioiTinh, "Giới Tính");
                // ComboBox_Validation(cbbCV, lblChucVu, "Chức vụ");

            }

            else
            {
                s.Name_Staff = txtten.Text;
                s.Date_Of_Birth = dateTimePicker1.Value;
                s.Gender = cbbGT.Text;
                s.Phone_number = txtSDT.Text;
                s.Address = txtdiachi.Text;
                s.User_Name = txtUN.Text;
                s.Pass_Word = txtUN.Text;
                s.ID_Pos = (int)((CBB_Items)cbbCV.SelectedItem).Value;
                s.Email = txtEmail.Text;
                s.State = "HD";
                BLL_Staff.Instance.AddStaff(s);
                MessageBox.Show("Đã Thêm Thành Công Nhân Viên Vui Lòng Nhập Chính Sách Lương");
                alltxt();
                formNhapCSL fn = new formNhapCSL();
                fn.ShowDialog();
                dataGridView1.DataSource = BLL_Staff.Showstaff();
            }



            /* if (x == 2) {

                 s.Name_Staff = txtten.Text;
                 s.Date_Of_Birth = dateTimePicker1.Value;
                 s.Gender = cbbGT.Text;
                 s.Phone_number = txtSDT.Text;
                 s.Address = txtdiachi.Text;
                 s.User_Name = txtUN.Text;
                 s.Pass_Word = txtUN.Text;
                 s.ID_Pos = (int)((CBB_Items)cbbCV.SelectedItem).Value;
                 s.Email = txtEmail.Text;
                 s.State = "HD";
                 BLL_Staff.Instance.AddStaff(s);
                 MessageBox.Show("Đã Thêm Thành Công Nhân Viên Vui Lòng Nhập Chính Sách Lương");
                 alltxt();
                 formNhapCSL fn = new formNhapCSL();
                 fn.ShowDialog();
             }*/


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = BLL_Staff.Showstaff();
            btnExcel.Visible = true;


        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban đã chắc chắn muốn khóa tài khoản này ", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLL_Staff.Instance.BlockStaff(lblMaNV.Text);

                MessageBox.Show("Đã Khóa tài khoản thành công");
                dataGridView1.DataSource = BLL_Staff.Showstaff();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnCSLuong.Visible = true;
            btnKhoa.Visible = true;
            btnUpdateStaff.Visible = true;
            btnReset.Visible = true;
            btnUpdateLuong.Visible = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];

            lblMaNV.Text = row.Cells[0].Value.ToString();
            txtten.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();
            txtdiachi.Text = row.Cells[7].Value.ToString();
            txtUN.Text = row.Cells[8].Value.ToString();
            cbbGT.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[6].Value.ToString();
            txtSDT.Text = row.Cells[5].Value.ToString();
            cbbCV.Text = row.Cells[2].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Staff.TimKiem(txtTK.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            //var uc = new UCQLNVLuong();
            //  AddUserControl(uc);

            object da = BLL_Staff.Instance.GetLuongtheoca(lblMaNV.Text);
            int x = (int)da;
            txtluong.Text = x.ToString();
            object db = BLL_Staff.Instance.GetThuong(lblMaNV.Text);
            int y = (int)db;
            txtThuong.Text = y.ToString();
            object dc = BLL_Staff.Instance.GetThuong(lblMaNV.Text);
            int c = (int)dc;
            txtphucap.Text = c.ToString();

        }

        private void QLNV_Load(object sender, EventArgs e)
        {

            btnExcel.Visible = false;
            btnCSLuong.Visible = false;
            btnKhoa.Visible = false;
            btnUpdateStaff.Visible = false;
            btnReset.Visible = false;
            btnUpdateLuong.Visible = false;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.ID_Staff = lblMaNV.Text;
            s.User_Name = txtUN.Text;

            if (lblMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!");
            }
            else {
                if (MessageBox.Show("Ban đã chắc chắn muốn Reset tài khoản này ", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BLL_Staff.Instance.Reset(s);
                    MessageBox.Show("Reset Tài khoản thành công ");
                } }

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            if (txtluong.Text == "" || txtphucap.Text == "" || txtThuong.Text == "")
                MessageBox.Show("Chưa nhập thay đổi.");

            else
            {


                CSLuong cs = new CSLuong();
                cs.ID_Staff = lblMaNV.Text;
                cs.Luong = Convert.ToInt32(txtluong.Text);
                cs.Thuong = Convert.ToInt32(txtThuong.Text);
                cs.PhuCap = Convert.ToInt32(txtphucap.Text);
                if (MessageBox.Show("Ban đã chắc chắn với thay đổi của mình ", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BLL_Staff.Instance.CapNhatLuong(cs);
                    MessageBox.Show("Đã cập nhật chính sách lương thành công.");
                }
            } 
        } 

        private void rjButton6_Click(object sender, EventArgs e)
        {
            formListTKdaKhoa fm=new formListTKdaKhoa();
            fm.ShowDialog();
        }


        public bool Existed( TextBox tb, int x)
        {
            int a = 0;//chua ton tai
            foreach (DataGridViewRow i in dataGridView1.Rows)

            {
                if ((string)i.Cells[x].Value == tb.Text)
                {
                   a = 1; break;
                }
            }
            if (a == 0)
                return false;
            else
                return true;

        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "([a-z0-9A-Z]([-\\.\\w]*[a-z0-9A-Z])*@([a-z0-9A-Z][-\\w]*[a-z0-9A-Z]\\.)+[a-zA-Z]{2,9})$";
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.Text = "Email không được để trống.";
            }
            else
            {

                if (Regex.IsMatch(txtEmail.Text, pattern) == false)
                {
                    lblEmail.Text = "Email không hợp lệ. ";

                }


                else
                {
                    if (Existed(txtEmail, 6))
                        lblEmail.Text = "Email đã tồn tại.";
                    else
                        lblEmail.Text = "";
                }
            }
        }

        private void txtUN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUN.Text))
            {
                lblUN.Text = "UserName không được để trống.";
            }
            else
            {


                if (Existed(txtUN, 8))
                    lblUN.Text = "UserName đã tồn tại.";
                else
                    lblUN.Text = "";
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^(09|03|07|08|05)+([0-9]{8})$");
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                lblSDT.Text = "SDT không được để trống.";
            }
            else
            {

                if (r.IsMatch(txtSDT.Text) == false)
                    lblSDT.Text = "SDT không hợp lệ.";
                else
                {
                    if (Existed(txtSDT, 5))
                        lblSDT.Text = "SDT đã tồn tại.";
                    else
                        lblSDT.Text = "";
                }
                   
            }

        }

        private void txtdiachi_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[a-z A-Z]{1,50}$");
            if (string.IsNullOrEmpty(txtdiachi.Text))
            {
                lblDiaChi.Text = "Địa Chỉ không được để trống.";
            }
            else
            {
                if (r.IsMatch(txtdiachi.Text) == false)
                    lblDiaChi.Text = "Địa chỉ không hợp lệ.";
                else
                    lblDiaChi.Text = "";
            }

        }

        private void txtten_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[a-z A-Z]{1,50}$");
            if (string.IsNullOrEmpty(txtten.Text))
            {
                lblTen.Text = "Họ Tên không được để trống.";
            }
            else
            {
                if (r.IsMatch(txtten.Text) == false)
                    lblTen.Text = "Họ Tên không hợp lệ.";
                else
                    lblTen.Text = "";
            }
        }

        private void cbbCV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbCV.Text))
            {
                lblChucVu.Text = "Chức vụ không được để trống.";
            }
            else
                lblChucVu.Text = "";
        }

        private void txtluong_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{4,50}$");
            if (string.IsNullOrEmpty(txtluong.Text))
            {
                lblLuong.Text = "Lương không được để trống.";
            }
            else
            {
                if (r.IsMatch(txtluong.Text) == false)
                    lblLuong.Text = "Lương không hợp lệ..";
                else
                    lblLuong.Text = "";
            }
               
        }

        private void txtThuong_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{4,50}$");
            if (string.IsNullOrEmpty(txtThuong.Text))
            {
                lblthuong.Text = "Thưởng không được để trống.";
            }
            else
            {
                if (r.IsMatch(txtThuong.Text) == false)
                    lblthuong.Text = "Thưởng không hợp lệ..";
                else
                    lblthuong.Text = "";
            }
        }

        private void txtphucap_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{4,50}$");
            if (string.IsNullOrEmpty(txtphucap.Text))
            {
                lblphucap.Text = "Phụ cấp không được để trống.";
            }
            else
            {
                if (r.IsMatch(txtphucap.Text) == false)
                    lblphucap.Text = "Phụ cấp không hợp lệ..";
                else
                    lblphucap.Text = "";
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
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
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
    }
}

 