using GiaoDien.BLL;
using GiaoDien.DTO;
using System;
using System.Windows.Forms;

namespace GiaoDien.Forms.QLNV
{
    public partial class UCQLNVAdd : UserControl
    {

        public delegate void MyDel(int ID_Pos, string search);
        public MyDel del { get; set; }
        public string ID_Staff { get; set; }
        public UCQLNVAdd(string id_staff)
        {
            InitializeComponent();
            ID_Staff = id_staff;
            comboBox1.Items.AddRange(BLL_Staff.Instance.GetCBB().ToArray());
            Gui();
        }

        public void Gui()
        {
            if(ID_Staff!="")
            {
                Staff s = BLL_Staff.Instance.GetStaffByIDStaff(ID_Staff);
                s.ID_Staff = "";
                txtten.Text = s.Name_Staff;

                foreach(CBB_Items item in comboBox1.Items)
                {
                    if((int) item.Value == s.ID_Pos)
                    {
                        comboBox1.SelectedItem = item;
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
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Staff s =new Staff();
            if (txtDiaChi.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || txtUN.Text == "" || txtGT.Text == ""||comboBox1.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                
                            // s.ID_Staff  = txtMaNV.Text;
                            s.Name_Staff = txtten.Text;
                            s.Date_Of_Birth = dateTimePicker1.Value;
                            s.Gender = txtGT.Text;
                            s.Phone_number = txtSDT.Text;
                            s.Address = txtDiaChi.Text;
                            s.User_Name = txtUN.Text;
                            s.Pass_Word = txtUN.Text;
                            s.ID_Pos = (int)((CBB_Items)comboBox1.SelectedItem).Value;
                            s.Email = txtEmail.Text;

                            BLL_Staff.Instance.AddStaff(s);
                            del(0, "");
                            MessageBox.Show("Đã Thêm Thành Công");
                        
            }


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            var uc = new QLNV("");
            AddUserControl(uc);
        }

        private void UCQLNVAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
