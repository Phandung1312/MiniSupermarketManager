using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GiaoDien.DAL;
using GiaoDien.DTO;

namespace GiaoDien.BLL
{
    public  class BLL_Login
    {
        
        private static BLL_Login _Instance;
        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Login();
                }
                return _Instance;
            }
            private set { }
        }
        public BLL_Login()
        {

        }
        public int CheckLogin (string UserName,string PassWord)
        {
            Account Ac=DAL_Login.Instance.GetInfo(UserName, PassWord);
            if (Ac == null)
            {
                return 0;
            }
            else
            {
                if (Ac.ID_Pos == "1000000001") return 1;
                if (Ac.ID_Pos == "1000000002") return 2;
                if (Ac.ID_Pos == "1000000003") return 3;
            }
            return 0;
        }
    }
}
