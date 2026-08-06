using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignments_4._2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Find the teacher with the matching username
            Teacher matched = null;
            foreach (Teacher t in DataSource.Teachers)
            {
                if (t.UserName == txtUsernamebx.Text)
                {
                    matched = t;
                    break;
                }
            }

            // Check if a matching teacher was found and verify the password
            if (matched != null && matched.VerifyPassword(txtPasswordbx.Text))
            {
                Session.StartSession(matched);
                this.DialogResult = DialogResult.OK;   
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
    }
}
