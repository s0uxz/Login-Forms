using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Forms.Data
{
    public class User
    {
        private int iD;
        private string userName;
        private string passWord;
        private bool remember;

        //Properties
        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool Remember { get => remember; set => remember = value; }
    }
}
