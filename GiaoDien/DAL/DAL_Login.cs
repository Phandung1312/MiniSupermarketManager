using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GiaoDien.DTO;

namespace GiaoDien.DAL
{
    public  class DAL_Login
    {
        private static DAL_Login _Instance;
        //private string NameAccount;
        //private string PasswordAccount;
        //private DataTable Info;
        public static DAL_Login Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_Login();
                return _Instance;
            }
            private set
            {

            }
        }
        public DAL_Login()
        {
        }
        public Account GetInfo(string UserName,string PassWord)
        {
            Account Ac=new Account();
            string query = "select * from NhanVien where UserName='" + UserName + "' and PassWord='" + PassWord + "'";
            foreach(DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                Ac = GetAccountByDataRow(i);
            }
            return Ac;
        }
        public Account GetAccountByDataRow(DataRow Ac)
        {
            return new Account
            {
                UserName = Ac["UserName"].ToString(),
                Password = Ac["Password"].ToString(),
                ID_Staff = Ac["MaNV"].ToString(),
                ID_Pos = Ac["MaChucVu"].ToString(),
            };
        }
    }
}
