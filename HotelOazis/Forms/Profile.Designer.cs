namespace HotelOazis.Forms
{
    partial class Profile
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
            logoutButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            navigationButton = new Button();
            profilePicture = new Fitness.Utilities.RoundPictureBox();
            editButton = new Button();
            uploadButton = new Button();
            ageField = new TextBox();
            ageLabel = new Label();
            emailField = new TextBox();
            emailLabel = new Label();
            passwordField = new TextBox();
            passwordLabel = new Label();
            usernameField = new TextBox();
            usernameLabel = new Label();
            logo = new PictureBox();
            profileLabel = new Label();
            formPanel = new Panel();
            pfpErrors = new Label();
            emailErrors = new Label();
            passwordErrors = new Label();
            usernameErrors = new Label();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            formPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Red;
            logoutButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            logoutButton.Location = new Point(383, 359);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(160, 41);
            logoutButton.TabIndex = 21;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGreen;
            saveButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            saveButton.Location = new Point(308, 318);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(160, 41);
            saveButton.TabIndex = 20;
            saveButton.Text = "Save data";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            deleteButton.Location = new Point(474, 318);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(160, 41);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "Delete user";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.Location = new Point(0, 318);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(160, 41);
            navigationButton.TabIndex = 17;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // profilePicture
            // 
            profilePicture.Location = new Point(460, 52);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(144, 118);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 16;
            profilePicture.TabStop = false;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LightGray;
            editButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            editButton.Location = new Point(308, 318);
            editButton.Name = "editButton";
            editButton.Size = new Size(160, 41);
            editButton.TabIndex = 15;
            editButton.Text = "Edit information";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // uploadButton
            // 
            uploadButton.Enabled = false;
            uploadButton.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            uploadButton.Location = new Point(460, 200);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(130, 30);
            uploadButton.TabIndex = 13;
            uploadButton.Text = "Upload pfp";
            uploadButton.UseVisualStyleBackColor = true;
            // 
            // ageField
            // 
            ageField.BackColor = Color.LightGray;
            ageField.Enabled = false;
            ageField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            ageField.ForeColor = Color.DimGray;
            ageField.Location = new Point(115, 269);
            ageField.Name = "ageField";
            ageField.Size = new Size(244, 23);
            ageField.TabIndex = 12;
            ageField.Click += clearInputs_click;
            ageField.TextChanged += input_TextChanged;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            ageLabel.Location = new Point(193, 248);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(42, 18);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age";
            // 
            // emailField
            // 
            emailField.BackColor = Color.LightGray;
            emailField.Enabled = false;
            emailField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            emailField.ForeColor = Color.DimGray;
            emailField.Location = new Point(115, 200);
            emailField.Name = "emailField";
            emailField.Size = new Size(244, 23);
            emailField.TabIndex = 10;
            emailField.Click += clearInputs_click;
            emailField.TextChanged += input_TextChanged;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            emailLabel.Location = new Point(193, 176);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(65, 18);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "*Email";
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.LightGray;
            passwordField.Enabled = false;
            passwordField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            passwordField.ForeColor = Color.DimGray;
            passwordField.Location = new Point(115, 132);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(244, 23);
            passwordField.TabIndex = 8;
            passwordField.Click += clearInputs_click;
            passwordField.TextChanged += input_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            passwordLabel.Location = new Point(193, 106);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(105, 18);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "*Password";
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.LightGray;
            usernameField.Enabled = false;
            usernameField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            usernameField.ForeColor = Color.DimGray;
            usernameField.Location = new Point(115, 64);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(244, 23);
            usernameField.TabIndex = 6;
            usernameField.Click += clearInputs_click;
            usernameField.TextChanged += input_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            usernameLabel.Location = new Point(193, 40);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 18);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "*Username";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Location = new Point(-21, -16);
            logo.Name = "logo";
            logo.Size = new Size(101, 94);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.BackColor = Color.Transparent;
            profileLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic);
            profileLabel.Location = new Point(218, 0);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(235, 25);
            profileLabel.TabIndex = 0;
            profileLabel.Text = "Profile  Credentials";
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.Controls.Add(pfpErrors);
            formPanel.Controls.Add(emailErrors);
            formPanel.Controls.Add(passwordErrors);
            formPanel.Controls.Add(usernameErrors);
            formPanel.Controls.Add(logoutButton);
            formPanel.Controls.Add(saveButton);
            formPanel.Controls.Add(deleteButton);
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(profilePicture);
            formPanel.Controls.Add(editButton);
            formPanel.Controls.Add(uploadButton);
            formPanel.Controls.Add(ageField);
            formPanel.Controls.Add(ageLabel);
            formPanel.Controls.Add(emailField);
            formPanel.Controls.Add(emailLabel);
            formPanel.Controls.Add(passwordField);
            formPanel.Controls.Add(passwordLabel);
            formPanel.Controls.Add(usernameField);
            formPanel.Controls.Add(usernameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Controls.Add(profileLabel);
            formPanel.Location = new Point(71, 25);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(659, 400);
            formPanel.TabIndex = 2;
            // 
            // pfpErrors
            // 
            pfpErrors.AutoSize = true;
            pfpErrors.BackColor = Color.Transparent;
            pfpErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            pfpErrors.ForeColor = Color.Red;
            pfpErrors.Location = new Point(460, 248);
            pfpErrors.Name = "pfpErrors";
            pfpErrors.Size = new Size(47, 13);
            pfpErrors.TabIndex = 25;
            pfpErrors.Text = "label1";
            pfpErrors.Visible = false;
            // 
            // emailErrors
            // 
            emailErrors.AutoSize = true;
            emailErrors.BackColor = Color.Transparent;
            emailErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            emailErrors.ForeColor = Color.Red;
            emailErrors.Location = new Point(115, 226);
            emailErrors.Name = "emailErrors";
            emailErrors.Size = new Size(47, 13);
            emailErrors.TabIndex = 24;
            emailErrors.Text = "label1";
            emailErrors.Visible = false;
            // 
            // passwordErrors
            // 
            passwordErrors.AutoSize = true;
            passwordErrors.BackColor = Color.Transparent;
            passwordErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            passwordErrors.ForeColor = Color.Red;
            passwordErrors.Location = new Point(115, 158);
            passwordErrors.Name = "passwordErrors";
            passwordErrors.Size = new Size(47, 13);
            passwordErrors.TabIndex = 23;
            passwordErrors.Text = "label1";
            passwordErrors.Visible = false;
            // 
            // usernameErrors
            // 
            usernameErrors.AutoSize = true;
            usernameErrors.BackColor = Color.Transparent;
            usernameErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            usernameErrors.ForeColor = Color.Red;
            usernameErrors.Location = new Point(115, 90);
            usernameErrors.Name = "usernameErrors";
            usernameErrors.Size = new Size(47, 13);
            usernameErrors.TabIndex = 22;
            usernameErrors.Text = "label1";
            usernameErrors.Visible = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(formPanel);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button logoutButton;
        private Button saveButton;
        private Button deleteButton;
        private Button navigationButton;
        private Fitness.Utilities.RoundPictureBox profilePicture;
        private Button editButton;
        private Button uploadButton;
        private TextBox ageField;
        private Label ageLabel;
        private TextBox emailField;
        private Label emailLabel;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox usernameField;
        private Label usernameLabel;
        private PictureBox logo;
        private Label profileLabel;
        private Panel formPanel;
        private Label pfpErrors;
        private Label emailErrors;
        private Label passwordErrors;
        private Label usernameErrors;
    }
}