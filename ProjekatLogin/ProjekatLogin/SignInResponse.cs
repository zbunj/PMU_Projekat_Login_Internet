using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatLogin
{
    public class SignInResponse
    {
        public bool success { get; set; }
        public string token { get; set; }
        public UserData user { get; set; }
    }
    public class UserData
    {
        public string user_id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string picture { get; set; }
        public string username { get; set; }
    }
}
