namespace HotelOazis.Forms
{
    partial class Login
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
            formPanel = new Panel();
            passwordError = new Label();
            usernameError = new Label();
            register = new Label();
            loginBtn = new Button();
            passwordField = new TextBox();
            passwordLabel = new Label();
            usernameField = new TextBox();
            usernameLabel = new Label();
            logo = new PictureBox();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.Controls.Add(passwordError);
            formPanel.Controls.Add(usernameError);
            formPanel.Controls.Add(register);
            formPanel.Controls.Add(loginBtn);
            formPanel.Controls.Add(passwordField);
            formPanel.Controls.Add(passwordLabel);
            formPanel.Controls.Add(usernameField);
            formPanel.Controls.Add(usernameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Location = new Point(225, 50);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(350, 350);
            formPanel.TabIndex = 1;
            // 
            // passwordError
            // 
            passwordError.AutoSize = true;
            passwordError.BackColor = Color.Transparent;
            passwordError.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            passwordError.ForeColor = Color.Red;
            passwordError.Location = new Point(7, 227);
            passwordError.Name = "passwordError";
            passwordError.Size = new Size(47, 13);
            passwordError.TabIndex = 8;
            passwordError.Text = "label1";
            passwordError.Visible = false;
            // 
            // usernameError
            // 
            usernameError.AutoSize = true;
            usernameError.BackColor = Color.Transparent;
            usernameError.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            usernameError.ForeColor = Color.Red;
            usernameError.Location = new Point(7, 144);
            usernameError.Name = "usernameError";
            usernameError.Size = new Size(47, 13);
            usernameError.TabIndex = 7;
            usernameError.Text = "label1";
            usernameError.Visible = false;
            // 
            // register
            // 
            register.AutoSize = true;
            register.BackColor = Color.Transparent;
            register.Cursor = Cursors.Hand;
            register.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            register.ForeColor = Color.Blue;
            register.Location = new Point(136, 315);
            register.Name = "register";
            register.Size = new Size(62, 14);
            register.TabIndex = 6;
            register.Text = "Register";
            register.Click += register_Click;
            register.MouseLeave += register_leave;
            register.MouseHover += login_hover;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.SkyBlue;
            loginBtn.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            loginBtn.Location = new Point(90, 260);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(160, 41);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += login_Click;
            loginBtn.MouseLeave += login_leave;
            loginBtn.MouseHover += login_hover;
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.LightGray;
            passwordField.Font = new Font("Verdana", 12F);
            passwordField.ForeColor = Color.DimGray;
            passwordField.Location = new Point(4, 197);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(346, 27);
            passwordField.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Berlin Sans FB", 15.75F);
            passwordLabel.Location = new Point(116, 171);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(92, 23);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.LightGray;
            usernameField.Font = new Font("Verdana", 12F);
            usernameField.ForeColor = Color.DimGray;
            usernameField.Location = new Point(4, 115);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(346, 27);
            usernameField.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Berlin Sans FB", 15.75F);
            usernameLabel.Location = new Point(116, 89);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(98, 23);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Location = new Point(-21, -16);
            logo.Name = "logo";
            logo.Size = new Size(101, 94);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(formPanel);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label register;
        private Button loginBtn;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox usernameField;
        private Label usernameLabel;
        private PictureBox logo;
        private Label usernameError;
        private Label passwordError;
    }
}