﻿namespace HotelOazis.Forms
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            footer = new Button();
            serviceButton = new Button();
            roomsButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Rooms = new ToolStripMenuItem();
            Services = new ToolStripMenuItem();
            Reviews = new ToolStripMenuItem();
            Users = new ToolStripMenuItem();
            Reservations = new ToolStripMenuItem();
            MyReservations = new ToolStripMenuItem();
            roundPictureBox1 = new Fitness.Utilities.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // footer
            // 
            resources.ApplyResources(footer, "footer");
            footer.BackColor = Color.Transparent;
            footer.Name = "footer";
            footer.UseVisualStyleBackColor = false;
            // 
            // serviceButton
            // 
            resources.ApplyResources(serviceButton, "serviceButton");
            serviceButton.BackColor = SystemColors.ButtonFace;
            serviceButton.Name = "serviceButton";
            serviceButton.UseVisualStyleBackColor = false;
            serviceButton.Click += servicesButton_Click;
            serviceButton.MouseLeave += buttons_Leave;
            serviceButton.MouseHover += buttons_Hover;
            // 
            // roomsButton
            // 
            resources.ApplyResources(roomsButton, "roomsButton");
            roomsButton.BackColor = SystemColors.ButtonFace;
            roomsButton.Name = "roomsButton";
            roomsButton.UseVisualStyleBackColor = false;
            roomsButton.Click += roomsButton_Click;
            roomsButton.MouseLeave += buttons_Leave;
            roomsButton.MouseHover += buttons_Hover;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.rooms;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.services;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // menu
            // 
            resources.ApplyResources(menu, "menu");
            menu.BackColor = SystemColors.ScrollBar;
            menu.Items.AddRange(new ToolStripItem[] { Home, Rooms, Services, Reviews, Users, Reservations, MyReservations });
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
            // roundPictureBox1
            // 
            resources.ApplyResources(roundPictureBox1, "roundPictureBox1");
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // Index
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_img__4_;
            Controls.Add(roundPictureBox1);
            Controls.Add(footer);
            Controls.Add(serviceButton);
            Controls.Add(roomsButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menu);
            DoubleBuffered = true;
            Name = "Index";
            Load += Index_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button footer;
        private Button serviceButton;
        private Button roomsButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private MenuStrip menu;
        private ToolStripMenuItem Rooms;
        private ToolStripMenuItem Services;
        private ToolStripMenuItem Reviews;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem MyReservations;
        private Fitness.Utilities.RoundPictureBox roundPictureBox1;
        private ToolStripMenuItem Reservations;
        private ToolStripMenuItem Home;
    }
}