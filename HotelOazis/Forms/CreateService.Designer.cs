namespace HotelOazis.Forms
{
    partial class CreateService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateService));
            formPanel = new Panel();
            navigationButton = new Button();
            descriptionErrors = new Label();
            nameErrors = new Label();
            label1 = new Label();
            descriptionField = new TextBox();
            createBtn = new Button();
            descriptionLabel = new Label();
            nameField = new TextBox();
            nameLabel = new Label();
            logo = new PictureBox();
            roundPictureBox1 = new Fitness.Utilities.RoundPictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Rooms = new ToolStripMenuItem();
            Services = new ToolStripMenuItem();
            Reviews = new ToolStripMenuItem();
            Users = new ToolStripMenuItem();
            Reservations = new ToolStripMenuItem();
            MyReservations = new ToolStripMenuItem();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__4_;
            resources.ApplyResources(formPanel, "formPanel");
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(descriptionErrors);
            formPanel.Controls.Add(nameErrors);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(descriptionField);
            formPanel.Controls.Add(createBtn);
            formPanel.Controls.Add(descriptionLabel);
            formPanel.Controls.Add(nameField);
            formPanel.Controls.Add(nameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Name = "formPanel";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            resources.ApplyResources(navigationButton, "navigationButton");
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Name = "navigationButton";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // descriptionErrors
            // 
            resources.ApplyResources(descriptionErrors, "descriptionErrors");
            descriptionErrors.BackColor = Color.Transparent;
            descriptionErrors.ForeColor = Color.Red;
            descriptionErrors.Name = "descriptionErrors";
            // 
            // nameErrors
            // 
            resources.ApplyResources(nameErrors, "nameErrors");
            nameErrors.BackColor = Color.Transparent;
            nameErrors.ForeColor = Color.Red;
            nameErrors.Name = "nameErrors";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Name = "label1";
            // 
            // descriptionField
            // 
            descriptionField.BackColor = Color.LightGray;
            resources.ApplyResources(descriptionField, "descriptionField");
            descriptionField.ForeColor = Color.DimGray;
            descriptionField.Name = "descriptionField";
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.LightGreen;
            resources.ApplyResources(createBtn, "createBtn");
            createBtn.Name = "createBtn";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(descriptionLabel, "descriptionLabel");
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Name = "descriptionLabel";
            // 
            // nameField
            // 
            nameField.BackColor = Color.LightGray;
            resources.ApplyResources(nameField, "nameField");
            nameField.ForeColor = Color.DimGray;
            nameField.Name = "nameField";
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Name = "nameLabel";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.applogo1;
            resources.ApplyResources(logo, "logo");
            logo.Image = Properties.Resources.applogo1;
            logo.Name = "logo";
            logo.TabStop = false;
            // 
            // roundPictureBox1
            // 
            resources.ApplyResources(roundPictureBox1, "roundPictureBox1");
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ScrollBar;
            resources.ApplyResources(menu, "menu");
            menu.Items.AddRange(new ToolStripItem[] { Home, Rooms, Services, Reviews, Users, Reservations, MyReservations });
            menu.Name = "menu";
            // 
            // Home
            // 
            Home.Name = "Home";
            resources.ApplyResources(Home, "Home");
            Home.Click += menu_ItemClicked;
            // 
            // Rooms
            // 
            Rooms.ForeColor = SystemColors.ActiveCaptionText;
            Rooms.Name = "Rooms";
            Rooms.Padding = new Padding(4, 0, 4, 5);
            resources.ApplyResources(Rooms, "Rooms");
            Rooms.Click += menu_ItemClicked;
            // 
            // Services
            // 
            Services.ForeColor = SystemColors.ActiveCaptionText;
            Services.Name = "Services";
            Services.Padding = new Padding(4, 0, 4, 5);
            resources.ApplyResources(Services, "Services");
            Services.Click += menu_ItemClicked;
            // 
            // Reviews
            // 
            resources.ApplyResources(Reviews, "Reviews");
            Reviews.ForeColor = SystemColors.ActiveCaptionText;
            Reviews.Name = "Reviews";
            Reviews.Padding = new Padding(4, 0, 4, 5);
            Reviews.Click += menu_ItemClicked;
            // 
            // Users
            // 
            resources.ApplyResources(Users, "Users");
            Users.ForeColor = SystemColors.MenuText;
            Users.Name = "Users";
            Users.Padding = new Padding(4, 0, 4, 5);
            Users.Click += menu_ItemClicked;
            // 
            // Reservations
            // 
            resources.ApplyResources(Reservations, "Reservations");
            Reservations.Name = "Reservations";
            Reservations.Click += menu_ItemClicked;
            // 
            // MyReservations
            // 
            resources.ApplyResources(MyReservations, "MyReservations");
            MyReservations.ForeColor = SystemColors.ActiveCaptionText;
            MyReservations.Name = "MyReservations";
            MyReservations.Padding = new Padding(4, 0, 4, 5);
            MyReservations.Click += menu_ItemClicked;
            // 
            // CreateService
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(formPanel);
            Name = "CreateService";
            Load += CreateService_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel formPanel;
        private Label label1;
        private TextBox descriptionField;
        private Button createBtn;
        private Label descriptionLabel;
        private TextBox nameField;
        private Label nameLabel;
        private PictureBox logo;
        private Label descriptionErrors;
        private Label nameErrors;
        private Button navigationButton;
        private Fitness.Utilities.RoundPictureBox roundPictureBox1;
        private MenuStrip menu;
        private ToolStripMenuItem Home;
        private ToolStripMenuItem Rooms;
        private ToolStripMenuItem Services;
        private ToolStripMenuItem Reviews;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem Reservations;
        private ToolStripMenuItem MyReservations;
    }
}