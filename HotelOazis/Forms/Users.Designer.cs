﻿namespace HotelOazis.Forms
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            usersContainer = new FlowLayoutPanel();
            usersHeaders = new FlowLayoutPanel();
            usernameHeader = new Label();
            passwordHeader = new Label();
            emailHeader = new Label();
            ageHeader = new Label();
            avatarHeader = new Label();
            label1 = new Label();
            dateHeader = new Label();
            arriveHeader = new Label();
            roundPictureBox1 = new Fitness.Utilities.RoundPictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Rooms = new ToolStripMenuItem();
            Services = new ToolStripMenuItem();
            Reviews = new ToolStripMenuItem();
            User = new ToolStripMenuItem();
            Reservations = new ToolStripMenuItem();
            MyReservations = new ToolStripMenuItem();
            usersContainer.SuspendLayout();
            usersHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // usersContainer
            // 
            resources.ApplyResources(usersContainer, "usersContainer");
            usersContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            usersContainer.Controls.Add(usersHeaders);
            usersContainer.Name = "usersContainer";
            // 
            // usersHeaders
            // 
            resources.ApplyResources(usersHeaders, "usersHeaders");
            usersHeaders.BackColor = Color.Cyan;
            usersHeaders.Controls.Add(usernameHeader);
            usersHeaders.Controls.Add(passwordHeader);
            usersHeaders.Controls.Add(emailHeader);
            usersHeaders.Controls.Add(ageHeader);
            usersHeaders.Controls.Add(avatarHeader);
            usersHeaders.Controls.Add(label1);
            usersHeaders.Controls.Add(dateHeader);
            usersHeaders.Controls.Add(arriveHeader);
            usersHeaders.Name = "usersHeaders";
            // 
            // usernameHeader
            // 
            resources.ApplyResources(usernameHeader, "usernameHeader");
            usernameHeader.Name = "usernameHeader";
            // 
            // passwordHeader
            // 
            resources.ApplyResources(passwordHeader, "passwordHeader");
            passwordHeader.Name = "passwordHeader";
            // 
            // emailHeader
            // 
            resources.ApplyResources(emailHeader, "emailHeader");
            emailHeader.Name = "emailHeader";
            // 
            // ageHeader
            // 
            resources.ApplyResources(ageHeader, "ageHeader");
            ageHeader.Name = "ageHeader";
            // 
            // avatarHeader
            // 
            resources.ApplyResources(avatarHeader, "avatarHeader");
            avatarHeader.Name = "avatarHeader";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // dateHeader
            // 
            resources.ApplyResources(dateHeader, "dateHeader");
            dateHeader.Name = "dateHeader";
            // 
            // arriveHeader
            // 
            resources.ApplyResources(arriveHeader, "arriveHeader");
            arriveHeader.Name = "arriveHeader";
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
            resources.ApplyResources(menu, "menu");
            menu.BackColor = SystemColors.ScrollBar;
            menu.Items.AddRange(new ToolStripItem[] { Home, Rooms, Services, Reviews, User, Reservations, MyReservations });
            menu.Name = "menu";
            // 
            // Home
            // 
            resources.ApplyResources(Home, "Home");
            Home.Name = "Home";
            Home.Click += menu_ItemClicked;
            // 
            // Rooms
            // 
            resources.ApplyResources(Rooms, "Rooms");
            Rooms.ForeColor = SystemColors.ActiveCaptionText;
            Rooms.Name = "Rooms";
            Rooms.Padding = new Padding(4, 0, 4, 5);
            Rooms.Click += menu_ItemClicked;
            // 
            // Services
            // 
            resources.ApplyResources(Services, "Services");
            Services.ForeColor = SystemColors.ActiveCaptionText;
            Services.Name = "Services";
            Services.Padding = new Padding(4, 0, 4, 5);
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
            // User
            // 
            resources.ApplyResources(User, "User");
            User.ForeColor = SystemColors.MenuText;
            User.Name = "User";
            User.Padding = new Padding(4, 0, 4, 5);
            User.Click += menu_ItemClicked;
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
            // Users
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(usersContainer);
            Name = "Users";
            Load += Users_Load;
            usersContainer.ResumeLayout(false);
            usersHeaders.ResumeLayout(false);
            usersHeaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel usersContainer;
        private FlowLayoutPanel usersHeaders;
        private Label usernameHeader;
        private Label passwordHeader;
        private Label emailHeader;
        private Label ageHeader;
        private Label avatarHeader;
        private Label label1;
        private Label dateHeader;
        private Label arriveHeader;
        private Fitness.Utilities.RoundPictureBox roundPictureBox1;
        private MenuStrip menu;
        private ToolStripMenuItem Home;
        private ToolStripMenuItem Rooms;
        private ToolStripMenuItem Services;
        private ToolStripMenuItem Reviews;
        private ToolStripMenuItem User;
        private ToolStripMenuItem Reservations;
        private ToolStripMenuItem MyReservations;
    }
}