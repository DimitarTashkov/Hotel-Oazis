namespace HotelOazis.Forms
{
    partial class Reviews
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
            reviewsContainer = new FlowLayoutPanel();
            roundPictureBox1 = new Fitness.Utilities.RoundPictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Room = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            Users = new ToolStripMenuItem();
            Reservations = new ToolStripMenuItem();
            MyReservations = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // reviewsContainer
            // 
            reviewsContainer.AutoScroll = true;
            reviewsContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            reviewsContainer.BackgroundImageLayout = ImageLayout.Stretch;
            reviewsContainer.Location = new Point(20, 40);
            reviewsContainer.Name = "reviewsContainer";
            reviewsContainer.Size = new Size(760, 400);
            reviewsContainer.TabIndex = 9;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.Location = new Point(750, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(50, 35);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 25;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ScrollBar;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Font = new Font("Verdana", 12F, FontStyle.Bold);
            menu.Items.AddRange(new ToolStripItem[] { Home, Room, toolStripMenuItem1, toolStripMenuItem2, Users, Reservations, MyReservations });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 1, 0, 5);
            menu.Size = new Size(800, 33);
            menu.TabIndex = 24;
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = SystemColors.ActiveCaptionText;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Padding = new Padding(4, 0, 4, 5);
            toolStripMenuItem1.Size = new Size(93, 27);
            toolStripMenuItem1.Text = "Services";
            toolStripMenuItem1.Click += menu_ItemClicked;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackgroundImageLayout = ImageLayout.Center;
            toolStripMenuItem2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem2.ForeColor = SystemColors.ActiveCaptionText;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Padding = new Padding(4, 0, 4, 5);
            toolStripMenuItem2.Size = new Size(94, 27);
            toolStripMenuItem2.Text = "Reviews";
            toolStripMenuItem2.Click += menu_ItemClicked;
            // 
            // Users
            // 
            Users.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Users.ForeColor = SystemColors.MenuText;
            Users.Name = "Users";
            Users.Padding = new Padding(4, 0, 4, 5);
            Users.Size = new Size(70, 27);
            Users.Text = "Users";
            Users.Visible = false;
            Users.Click += menu_ItemClicked;
            // 
            // Reservations
            // 
            Reservations.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reservations.Name = "Reservations";
            Reservations.Size = new Size(135, 27);
            Reservations.Text = "Reservations";
            Reservations.Visible = false;
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
            // Reviews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(reviewsContainer);
            Name = "Reviews";
            Text = "Reviews";
            Load += Reviews_Load;
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel reviewsContainer;
        private Fitness.Utilities.RoundPictureBox roundPictureBox1;
        private MenuStrip menu;
        private ToolStripMenuItem Home;
        private ToolStripMenuItem Room;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem Reservations;
        private ToolStripMenuItem MyReservations;
    }
}