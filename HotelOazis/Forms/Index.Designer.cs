namespace HotelOazis.Forms
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
            footer.BackColor = Color.Transparent;
            footer.BackgroundImageLayout = ImageLayout.Stretch;
            footer.Font = new Font("Verdana", 11.25F, FontStyle.Italic);
            footer.Location = new Point(0, 409);
            footer.Name = "footer";
            footer.Size = new Size(815, 39);
            footer.TabIndex = 18;
            footer.Text = "Ⓒ Oazis 2024";
            footer.UseVisualStyleBackColor = false;
            // 
            // serviceButton
            // 
            serviceButton.BackColor = SystemColors.ButtonFace;
            serviceButton.BackgroundImageLayout = ImageLayout.Stretch;
            serviceButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            serviceButton.Location = new Point(529, 328);
            serviceButton.Name = "serviceButton";
            serviceButton.Size = new Size(203, 50);
            serviceButton.TabIndex = 16;
            serviceButton.Text = "Check out our latest services";
            serviceButton.UseVisualStyleBackColor = false;
            serviceButton.Click += servicesButton_Click;
            serviceButton.MouseLeave += buttons_Leave;
            serviceButton.MouseHover += buttons_Hover;
            // 
            // roomsButton
            // 
            roomsButton.BackColor = SystemColors.ButtonFace;
            roomsButton.BackgroundImageLayout = ImageLayout.Stretch;
            roomsButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            roomsButton.Location = new Point(83, 327);
            roomsButton.Name = "roomsButton";
            roomsButton.Size = new Size(185, 50);
            roomsButton.TabIndex = 15;
            roomsButton.Text = "Check out our latest rooms ";
            roomsButton.UseVisualStyleBackColor = false;
            roomsButton.Click += roomsButton_Click;
            roomsButton.MouseLeave += buttons_Leave;
            roomsButton.MouseHover += buttons_Hover;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.rooms;
            pictureBox2.Location = new Point(-7, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(402, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.services;
            pictureBox1.Location = new Point(401, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ScrollBar;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Font = new Font("Verdana", 12F, FontStyle.Bold);
            menu.Items.AddRange(new ToolStripItem[] { Home, Rooms, Services, Reviews, Users, Reservations, MyReservations });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 1, 0, 5);
            menu.Size = new Size(800, 33);
            menu.TabIndex = 11;
            menu.Text = "Menu";
            // 
            // Home
            // 
            Home.Name = "Home";
            Home.Size = new Size(71, 27);
            Home.Text = "Home";
            Home.Click += menu_ItemClicked;
            // 
            // Rooms
            // 
            Rooms.ForeColor = SystemColors.ActiveCaptionText;
            Rooms.Name = "Rooms";
            Rooms.Padding = new Padding(4, 0, 4, 5);
            Rooms.Size = new Size(80, 27);
            Rooms.Text = "Rooms";
            Rooms.Click += menu_ItemClicked;
            // 
            // Services
            // 
            Services.ForeColor = SystemColors.ActiveCaptionText;
            Services.Name = "Services";
            Services.Padding = new Padding(4, 0, 4, 5);
            Services.Size = new Size(93, 27);
            Services.Text = "Services";
            Services.Click += menu_ItemClicked;
            // 
            // Reviews
            // 
            Reviews.BackgroundImageLayout = ImageLayout.Center;
            Reviews.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Strikeout);
            Reviews.ForeColor = SystemColors.ActiveCaptionText;
            Reviews.Name = "Reviews";
            Reviews.Padding = new Padding(4, 0, 4, 5);
            Reviews.Size = new Size(94, 27);
            Reviews.Text = "Reviews";
            Reviews.Click += menu_ItemClicked;
            // 
            // Users
            // 
            Users.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Strikeout);
            Users.ForeColor = SystemColors.MenuText;
            Users.Name = "Users";
            Users.Padding = new Padding(4, 0, 4, 5);
            Users.Size = new Size(70, 27);
            Users.Text = "Users";
            Users.Click += menu_ItemClicked;
            // 
            // Reservations
            // 
            Reservations.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            Reservations.Name = "Reservations";
            Reservations.Size = new Size(135, 27);
            Reservations.Text = "Reservations";
            Reservations.Click += menu_ItemClicked;
            // 
            // MyReservations
            // 
            MyReservations.Font = new Font("Verdana", 12F, FontStyle.Bold);
            MyReservations.ForeColor = SystemColors.ActiveCaptionText;
            MyReservations.Name = "MyReservations";
            MyReservations.Padding = new Padding(4, 0, 4, 5);
            MyReservations.Size = new Size(160, 27);
            MyReservations.Text = "My reservations";
            MyReservations.Click += menu_ItemClicked;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.Location = new Point(746, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(50, 35);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 19;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_img__4_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(roundPictureBox1);
            Controls.Add(footer);
            Controls.Add(serviceButton);
            Controls.Add(roomsButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menu);
            DoubleBuffered = true;
            Name = "Index";
            Text = "Index";
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