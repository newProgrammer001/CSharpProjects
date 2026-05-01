using System;
using System.Drawing;
using System.Windows.Forms;
using TaskManagerCS.Data;

namespace TaskManagerCS.Forms
{
    public class LoginForm : Form
    {
        private TextBox txtUsername = null!;
        private TextBox txtPassword = null!;
        private Button btnLogin = null!;
        private Button btnGoToSignup = null!;
        private Label lblTitle = null!;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnGoToSignup = new Button();
            this.lblTitle = new Label();
            this.SuspendLayout();

            
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(100, 30);
            this.lblTitle.Text = "Login";

            
            this.txtUsername.Location = new Point(50, 100);
            this.txtUsername.Size = new Size(200, 30);
            this.txtUsername.PlaceholderText = "Username or Email";

            
            this.txtPassword.Location = new Point(50, 150);
            this.txtPassword.Size = new Size(200, 30);
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.UseSystemPasswordChar = true;

            
            this.btnLogin.Location = new Point(50, 200);
            this.btnLogin.Size = new Size(200, 40);
            this.btnLogin.Text = "Login";
            this.btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Click += BtnLogin_Click;

            
            this.btnGoToSignup.Location = new Point(50, 250);
            this.btnGoToSignup.Size = new Size(200, 30);
            this.btnGoToSignup.Text = "Don't have an account? Signup";
            this.btnGoToSignup.FlatStyle = FlatStyle.Flat;
            this.btnGoToSignup.FlatAppearance.BorderSize = 0;
            this.btnGoToSignup.Click += BtnGoToSignup_Click;

            
            this.ClientSize = new Size(300, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnGoToSignup);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Task Manager - Login";
            this.ResumeLayout(false);
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            string input = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Database.LoginUser(input, password);
            if (userId == -1)
            {
                MessageBox.Show("Invalid username/email or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var taskForm = new Form1(userId);
            taskForm.Show();
            this.Hide();
        }

        private void BtnGoToSignup_Click(object? sender, EventArgs e)
        {
            var signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}
