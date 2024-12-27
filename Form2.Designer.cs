namespace ProductManagements
{
    partial class Form2
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
            Username = new Label();
            Password = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            LoginLbael = new Label();
            BtnLogin = new Button();
            BtnInscription = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(226, 149);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(226, 207);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(337, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(192, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(337, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 27);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPaswword_TextChanged;
            // 
            // LoginLbael
            // 
            LoginLbael.AutoSize = true;
            LoginLbael.Font = new Font("Segoe UI", 18F);
            LoginLbael.ForeColor = Color.Blue;
            LoginLbael.Location = new Point(382, 49);
            LoginLbael.Name = "LoginLbael";
            LoginLbael.Size = new Size(92, 41);
            LoginLbael.TabIndex = 3;
            LoginLbael.Text = "Login";
            LoginLbael.Click += LoginLbael_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(435, 264);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(94, 27);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(321, 263);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(94, 29);
            BtnInscription.TabIndex = 5;
            BtnInscription.Text = "Inscription";
            BtnInscription.UseVisualStyleBackColor = true;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 434);
            Controls.Add(BtnInscription);
            Controls.Add(BtnLogin);
            Controls.Add(LoginLbael);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(Password);
            Controls.Add(Username);
            Font = new Font("Segoe UI", 9F);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label LoginLbael;
        private Button BtnLogin;
        private Button BtnInscription;
    }
}