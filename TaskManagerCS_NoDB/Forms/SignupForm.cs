using System;
using System.Drawing;
using System.Windows.Forms;
using TaskManagerCS.Data;

namespace TaskManagerCS.Forms
{
    public class SignupForm : Form
    {
        private TextBox txtUsername = null!;
        private TextBox txtEmail = null!;
        private TextBox txtPassword = null!;
        private Button btnSignup = null!;
        private Button btnGoToLogin = null!;
        private Label lblTitle = null!;

        public SignupForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtUsername = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.btnSignup = new Button();
            this.btnGoToLogin = new Button();
            this.lblTitle = new Label();
            this.SuspendLayout();

            
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(90, 30);
            this.lblTitle.Text = "Signup";

            
            this.txtUsername.Location = new Point(50, 90);
            this.txtUsername.Size = new Size(200, 30);
            this.txtUsername.PlaceholderText = "Username";

            
            this.txtEmail.Location = new Point(50, 130);
            this.txtEmail.Size = new Size(200, 30);
            this.txtEmail.PlaceholderText = "Email";

            
            this.txtPassword.Location = new Point(50, 170);
            this.txtPassword.Size = new Size(200, 30);
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.UseSystemPasswordChar = true;

            
            this.btnSignup.Location = new Point(50, 220);
            this.btnSignup.Size = new Size(200, 40);
            this.btnSignup.Text = "Signup";
            this.btnSignup.BackColor = Color.FromArgb(40, 167, 69);
            this.btnSignup.ForeColor = Color.White;
            this.btnSignup.FlatStyle = FlatStyle.Flat;
            this.btnSignup.Click += BtnSignup_Click;

            
            this.btnGoToLogin.Location = new Point(50, 270);
            this.btnGoToLogin.Size = new Size(200, 30);
            this.btnGoToLogin.Text = "Already have an account? Login";
            this.btnGoToLogin.FlatStyle = FlatStyle.Flat;
            this.btnGoToLogin.FlatAppearance.BorderSize = 0;
            this.btnGoToLogin.Click += BtnGoToLogin_Click;

            
            this.ClientSize = new Size(300, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnGoToLogin);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Task Manager - Signup";
            this.ResumeLayout(false);
        }

        private void BtnSignup_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email    = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email)    ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Database.SignupUser(username, email, password);
            if (userId == -1)
            {
                MessageBox.Show("Username or email is already taken.", "Signup Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Account created! Welcome, " + username + "!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var taskForm = new Form1(userId);
            taskForm.Show();
            this.Hide();
        }

        private void BtnGoToLogin_Click(object? sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
