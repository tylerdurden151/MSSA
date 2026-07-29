namespace Assignments_4._2
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsernamebx = new TextBox();
            txtPasswordbx = new TextBox();
            loginbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsernamebx
            // 
            txtUsernamebx.Font = new Font("Segoe UI", 12F);
            txtUsernamebx.Location = new Point(261, 110);
            txtUsernamebx.Name = "txtUsernamebx";
            txtUsernamebx.Size = new Size(296, 50);
            txtUsernamebx.TabIndex = 0;
            // 
            // txtPasswordbx
            // 
            txtPasswordbx.Font = new Font("Segoe UI", 12F);
            txtPasswordbx.Location = new Point(261, 199);
            txtPasswordbx.Name = "txtPasswordbx";
            txtPasswordbx.Size = new Size(296, 50);
            txtPasswordbx.TabIndex = 1;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginbtn.Location = new Point(328, 304);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(150, 46);
            loginbtn.TabIndex = 2;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(67, 123);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 3;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(67, 212);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            Controls.Add(txtPasswordbx);
            Controls.Add(txtUsernamebx);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsernamebx;
        private TextBox txtPasswordbx;
        private Button loginbtn;
        private Label label1;
        private Label label2;
    }
}