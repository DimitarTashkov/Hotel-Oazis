namespace HotelOazis.Forms
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
            Room = new ToolStripMenuItem();
            Services = new ToolStripMenuItem();
            Reviews = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
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
            usersContainer.AutoScroll = true;
            usersContainer.Controls.Add(usersHeaders);
            usersContainer.Location = new Point(20, 40);
            usersContainer.Name = "usersContainer";
            usersContainer.Size = new Size(760, 400);
            usersContainer.TabIndex = 9;
            // 
            // usersHeaders
            // 
            usersHeaders.BackColor = Color.Cyan;
            usersHeaders.Controls.Add(usernameHeader);
            usersHeaders.Controls.Add(passwordHeader);
            usersHeaders.Controls.Add(emailHeader);
            usersHeaders.Controls.Add(ageHeader);
            usersHeaders.Controls.Add(avatarHeader);
            usersHeaders.Controls.Add(label1);
            usersHeaders.Controls.Add(dateHeader);
            usersHeaders.Controls.Add(arriveHeader);
            usersHeaders.Location = new Point(15, 8);
            usersHeaders.Margin = new Padding(15, 8, 8, 8);
            usersHeaders.Name = "usersHeaders";
            usersHeaders.Padding = new Padding(10);
            usersHeaders.Size = new Size(725, 32);
            usersHeaders.TabIndex = 0;
            // 
            // usernameHeader
            // 
            usernameHeader.AutoSize = true;
            usernameHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            usernameHeader.Location = new Point(40, 10);
            usernameHeader.Margin = new Padding(30, 0, 40, 0);
            usernameHeader.Name = "usernameHeader";
            usernameHeader.Size = new Size(81, 16);
            usernameHeader.TabIndex = 0;
            usernameHeader.Text = "Username";
            // 
            // passwordHeader
            // 
            passwordHeader.AutoSize = true;
            passwordHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            passwordHeader.Location = new Point(161, 10);
            passwordHeader.Margin = new Padding(0, 0, 40, 0);
            passwordHeader.Name = "passwordHeader";
            passwordHeader.Size = new Size(77, 16);
            passwordHeader.TabIndex = 1;
            passwordHeader.Text = "Password";
            // 
            // emailHeader
            // 
            emailHeader.AutoSize = true;
            emailHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            emailHeader.Location = new Point(278, 10);
            emailHeader.Margin = new Padding(0, 0, 50, 0);
            emailHeader.Name = "emailHeader";
            emailHeader.Size = new Size(47, 16);
            emailHeader.TabIndex = 2;
            emailHeader.Text = "Email";
            // 
            // ageHeader
            // 
            ageHeader.AutoSize = true;
            ageHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            ageHeader.Location = new Point(375, 10);
            ageHeader.Margin = new Padding(0, 0, 50, 0);
            ageHeader.Name = "ageHeader";
            ageHeader.Size = new Size(34, 16);
            ageHeader.TabIndex = 3;
            ageHeader.Text = "Age";
            // 
            // avatarHeader
            // 
            avatarHeader.AutoSize = true;
            avatarHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            avatarHeader.Location = new Point(459, 10);
            avatarHeader.Margin = new Padding(0, 0, 50, 0);
            avatarHeader.Name = "avatarHeader";
            avatarHeader.Size = new Size(55, 16);
            avatarHeader.TabIndex = 4;
            avatarHeader.Text = "Avatar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(564, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 7;
            label1.Text = "Authorized";
            // 
            // dateHeader
            // 
            dateHeader.AutoSize = true;
            dateHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            dateHeader.Location = new Point(684, 10);
            dateHeader.Margin = new Padding(35, 0, 3, 0);
            dateHeader.Name = "dateHeader";
            dateHeader.Size = new Size(0, 16);
            dateHeader.TabIndex = 5;
            // 
            // arriveHeader
            // 
            arriveHeader.AutoSize = true;
            arriveHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            arriveHeader.Location = new Point(45, 26);
            arriveHeader.Margin = new Padding(35, 0, 3, 0);
            arriveHeader.Name = "arriveHeader";
            arriveHeader.Size = new Size(0, 16);
            arriveHeader.TabIndex = 6;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.Location = new Point(750, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(50, 35);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 23;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ScrollBar;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Font = new Font("Verdana", 12F, FontStyle.Bold);
            menu.Items.AddRange(new ToolStripItem[] { Home, Room, Services, Reviews, toolStripMenuItem1, Reservations, MyReservations });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 1, 0, 5);
            menu.Size = new Size(800, 33);
            menu.TabIndex = 22;
            menu.Text = "Menu";
            // 
            // Home
            // 
            Home.Name = "Home";
            Home.Size = new Size(71, 27);
            Home.Text = "Home";
            Home.Click += menu_ItemClicked;
            // 
            // Room
            // 
            Room.ForeColor = SystemColors.ActiveCaptionText;
            Room.Name = "Room";
            Room.Padding = new Padding(4, 0, 4, 5);
            Room.Size = new Size(80, 27);
            Room.Text = "Rooms";
            Room.Click += menu_ItemClicked;
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
            Reviews.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reviews.ForeColor = SystemColors.ActiveCaptionText;
            Reviews.Name = "Reviews";
            Reviews.Padding = new Padding(4, 0, 4, 5);
            Reviews.Size = new Size(94, 27);
            Reviews.Text = "Reviews";
            Reviews.Click += menu_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = SystemColors.MenuText;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Padding = new Padding(4, 0, 4, 5);
            toolStripMenuItem1.Size = new Size(70, 27);
            toolStripMenuItem1.Text = "Users";
            toolStripMenuItem1.Click += menu_ItemClicked;
            // 
            // Reservations
            // 
            Reservations.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(usersContainer);
            Name = "Users";
            Text = "Users";
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
        private ToolStripMenuItem Room;
        private ToolStripMenuItem Services;
        private ToolStripMenuItem Reviews;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem Reservations;
        private ToolStripMenuItem MyReservations;
    }
}