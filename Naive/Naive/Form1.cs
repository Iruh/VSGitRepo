using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naive
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //some silly stuff here
            //and some more silly stuff here
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginStaffId_txt_OnValueChanged(object sender, EventArgs e)
        {
            LoginStaffId_txt.ForeColor = Color.White;
        }

        private void LoginStaffPass_txt_OnValueChanged(object sender, EventArgs e)
        {
            LoginStaffPass_txt.ForeColor = Color.White;
        }

        private void LoginSignUpRedirect_lbl_Click(object sender, EventArgs e)
        {
            //415 22
            if(LoginLoginPanel.Left==12)
            {
                LoginLoginPanel.Visible = false;
                LoginLoginPanel.Left = 414;
                LoginSignUpPanel.Visible = false;
                LoginSignUpPanel.Left = 12;
                LoginSignUpPanel.Visible = true;
                LoginSignUpPanel.Refresh();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (LoginSignUpPanel.Left==12)
            {
                LoginSignUpPanel.Visible = false;
                LoginSignUpPanel.Left = 414;
                LoginLoginPanel.Visible = false;
                LoginLoginPanel.Left = 12;
                LoginLoginPanel.Visible = true;
                LoginLoginPanel.Refresh();
            }

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
