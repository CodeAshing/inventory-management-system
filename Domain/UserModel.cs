using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using common.Cache;

namespace Domain
{
    public class UserModel
    {
        userdao userdao = new userdao();
        public bool LoginUser(string user, string pass)
        {
            return userdao.Login(user,pass);
                
        }
        public bool editpassword(int user, string pass)
        {
            if (user == userlogincache.Iduser)
            {
                 
            }
            return true;
        }
    }
}
