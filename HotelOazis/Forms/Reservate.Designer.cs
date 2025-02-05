namespace HotelOazis.Forms
{
    partial class Reservate
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
            checkOutDatePicker = new DateTimePicker();
            checkInDatePicker = new DateTimePicker();
            cancel = new Label();
            reservateBtn = new Button();
            toLabel = new Label();
            fromLabel = new Label();
            logo = new PictureBox();
            roundPictureBox1 = new Fitness.Utilities.RoundPictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Room = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
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
            formPanel.Controls.Add(checkOutDatePicker);
            formPanel.Controls.Add(checkInDatePicker);
            formPanel.Controls.Add(cancel);
            formPanel.Controls.Add(reservateBtn);
            formPanel.Controls.Add(toLabel);
            formPanel.Controls.Add(fromLabel);
            formPanel.Controls.Add(logo);
            formPanel.Location = new Point(225, 50);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(350, 350);
            formPanel.TabIndex = 2;
            // 
            // checkOutDatePicker
            // 
            checkOutDatePicker.Location = new Point(78, 203);
            checkOutDatePicker.Name = "checkOutDatePicker";
            checkOutDatePicker.Size = new Size(200, 23);
            checkOutDatePicker.TabIndex = 8;
            // 
            // checkInDatePicker
            // 
            checkInDatePicker.Location = new Point(78, 140);
            checkInDatePicker.Name = "checkInDatePicker";
            checkInDatePicker.Size = new Size(200, 23);
            checkInDatePicker.TabIndex = 7;
            // 
            // cancel
            // 
            cancel.AutoSize = true;
            cancel.BackColor = Color.Transparent;
            cancel.Cursor = Cursors.Hand;
            cancel.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            cancel.ForeColor = Color.Blue;
            cancel.Location = new Point(146, 315);
            cancel.Name = "cancel";
            cancel.Size = new Size(52, 14);
            cancel.TabIndex = 6;
            cancel.Text = "Cancel";
            cancel.Click += cancel_Click;
            // 
            // reservateBtn
            // 
            reservateBtn.BackColor = Color.LightGreen;
            reservateBtn.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            reservateBtn.Location = new Point(90, 260);
            reservateBtn.Name = "reservateBtn";
            reservateBtn.Size = new Size(160, 41);
            reservateBtn.TabIndex = 5;
            reservateBtn.Text = "Reservate";
            reservateBtn.UseVisualStyleBackColor = false;
            reservateBtn.Click += reservateBtn_Click;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.BackColor = Color.Transparent;
            toLabel.Font = new Font("Berlin Sans FB", 15.75F);
            toLabel.Location = new Point(102, 177);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(148, 23);
            toLabel.TabIndex = 3;
            toLabel.Text = "Check out date:";
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.BackColor = Color.Transparent;
            fromLabel.Font = new Font("Berlin Sans FB", 15.75F);
            fromLabel.Location = new Point(102, 105);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(133, 23);
            fromLabel.TabIndex = 1;
            fromLabel.Text = "Check in date:";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.applogo1;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(-21, -16);
            logo.Name = "logo";
            logo.Size = new Size(150, 150);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.Location = new Point(750, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(50, 35);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 37;
            roundPictureBox1.TabStop = false;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ScrollBar;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Font = new Font("Verdana", 12F, FontStyle.Bold);
            menu.Items.AddRange(new ToolStripItem[] { Home, Room, toolStripMenuItem1, Reviews, Users, Reservations, MyReservations });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 1, 0, 5);
            menu.Size = new Size(800, 33);
            menu.TabIndex = 36;
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
            // Reservate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(formPanel);
            Name = "Reservate";
            Text = "Reservate";
            Load += Reservate_Load;
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
        private Label cancel;
        private Button reservateBtn;
        private Label toLabel;
        private Label fromLabel;
        private PictureBox logo;
        private DateTimePicker checkOutDatePicker;
        private DateTimePicker checkInDatePicker;
        private Fitness.Utilities.RoundPictureBox roundPictureBox1;
        private MenuStrip menu;
        private ToolStripMenuItem Home;
        private ToolStripMenuItem Room;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem Reviews;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem Reservations;
        private ToolStripMenuItem MyReservations;
    }
}