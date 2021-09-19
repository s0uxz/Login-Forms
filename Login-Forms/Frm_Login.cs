using Login_Forms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Forms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        UserDao user;
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //check 2 txtBox if it have data
            if(!string.IsNullOrEmpty(txtUserName.Text))
            {
                if(!string.IsNullOrEmpty(txtPassWord.Text))
                {
                    user = new UserDao();
                    //kiem tra txt co trung user vs pass hay ko ---> using if...else...
                    if(KiemTraDangNhap(txtUserName.Text, txtPassWord.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        lblErr.Text = "Username of Password wrong.";
                    }
                }
            }
            

        }
        private bool KiemTraDangNhap(string userName, string passWord)
        {
            if(user.Equals(userName) && user.Equals(passWord))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
