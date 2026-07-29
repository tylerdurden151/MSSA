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
            Teacher matched = null;
            foreach (Teacher t in DataSource.Teachers)
            {
                if (t.UserName == txtUsernamebx.Text)
                {
                    matched = t;
                    break;
                }
            }

            if (matched != null && matched.VerifyPassword(txtPasswordbx.Text))
            {
                Session.StartSession(matched);
                this.DialogResult = DialogResult.OK;   // this line alone closes the popup
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
    }
}
