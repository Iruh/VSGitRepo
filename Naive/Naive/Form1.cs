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
            LoginSignInStaffId_txt.ForeColor = Color.White;
        }

        private void LoginStaffPass_txt_OnValueChanged(object sender, EventArgs e)
        {
            LoginSignInStaffPass_txt.ForeColor = Color.White;
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

        private void LoginSignInStaffId_txt_Enter(object sender, EventArgs e)
        {
            LoginSignInStaffId_txt.ForeColor = Color.White;
            if (LoginSignInStaffId_txt.Text== "eg 5678")
            {
                LoginSignInStaffId_txt.Text = "";
            }
        }

        private void LoginSignInStaffId_txt_Leave(object sender, EventArgs e)
        {
            LoginSignInStaffId_txt.ForeColor = Color.Gray;
            if (LoginSignInStaffId_txt.Text == "")
            {
                LoginSignInStaffId_txt.Text = "eg 5678";
            }
        }

        private void LoginSignUpFirstName_txt_Enter(object sender, EventArgs e)
        {
            LoginSignUpFirstName_txt.ForeColor = Color.White;
            if (LoginSignUpFirstName_txt.Text == "eg Joseph")
            {
                LoginSignUpFirstName_txt.Text = "";
            }
        }

        private void LoginSignUpFirstName_txt_Leave(object sender, EventArgs e)
        {
            LoginSignUpFirstName_txt.ForeColor = Color.Gray;
            if (LoginSignUpFirstName_txt.Text == "")
            {
                LoginSignUpFirstName_txt.Text = "eg Joseph";
            }
        }

        private void LoginSignUpLastName_txt_Enter(object sender, EventArgs e)
        {
            LoginSignUpLastName_txt.ForeColor = Color.White;
            if (LoginSignUpLastName_txt.Text == "eg Kane")
            {
                LoginSignUpLastName_txt.Text = "";
            }
        }

        private void LoginSignUpLastName_txt_Leave(object sender, EventArgs e)
        {
            LoginSignUpLastName_txt.ForeColor = Color.Gray;
            if (LoginSignUpLastName_txt.Text == "")
            {
                LoginSignUpLastName_txt.Text = "eg Kane";
            }
        }
    }
}
