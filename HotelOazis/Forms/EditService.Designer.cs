namespace HotelOazis.Forms
{
    partial class EditService
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
            navigationButton = new Button();
            descriptionErrors = new Label();
            nameErrors = new Label();
            label1 = new Label();
            descriptionField = new TextBox();
            editBtn = new Button();
            descriptionLabel = new Label();
            nameField = new TextBox();
            nameLabel = new Label();
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
            formPanel.BackgroundImage = Properties.Resources.gradient_img__4_;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(descriptionErrors);
            formPanel.Controls.Add(nameErrors);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(descriptionField);
            formPanel.Controls.Add(editBtn);
            formPanel.Controls.Add(descriptionLabel);
            formPanel.Controls.Add(nameField);
            formPanel.Controls.Add(nameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Location = new Point(150, 50);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(500, 350);
            formPanel.TabIndex = 3;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(169, 313);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(170, 34);
            navigationButton.TabIndex = 23;
            navigationButton.Text = "Return to services";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // descriptionErrors
            // 
            descriptionErrors.AutoSize = true;
            descriptionErrors.BackColor = Color.Transparent;
            descriptionErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            descriptionErrors.ForeColor = Color.Red;
            descriptionErrors.Location = new Point(90, 240);
            descriptionErrors.Name = "descriptionErrors";
            descriptionErrors.Size = new Size(47, 13);
            descriptionErrors.TabIndex = 22;
            descriptionErrors.Text = "label1";
            descriptionErrors.Visible = false;
            // 
            // nameErrors
            // 
            nameErrors.AutoSize = true;
            nameErrors.BackColor = Color.Transparent;
            nameErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameErrors.ForeColor = Color.Red;
            nameErrors.Location = new Point(90, 164);
            nameErrors.Name = "nameErrors";
            nameErrors.Size = new Size(47, 13);
            nameErrors.TabIndex = 21;
            nameErrors.Text = "label1";
            nameErrors.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 8;
            label1.Text = "Service info";
            // 
            // descriptionField
            // 
            descriptionField.BackColor = Color.LightGray;
            descriptionField.Font = new Font("Verdana", 12F);
            descriptionField.ForeColor = Color.DimGray;
            descriptionField.Location = new Point(90, 210);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(346, 27);
            descriptionField.TabIndex = 7;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.DodgerBlue;
            editBtn.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            editBtn.Location = new Point(169, 255);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(160, 41);
            editBtn.TabIndex = 5;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(223, 182);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(106, 18);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description";
            // 
            // nameField
            // 
            nameField.BackColor = Color.LightGray;
            nameField.Font = new Font("Verdana", 12F);
            nameField.ForeColor = Color.DimGray;
            nameField.Location = new Point(90, 134);
            nameField.Name = "nameField";
            nameField.Size = new Size(346, 27);
            nameField.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(225, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 18);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.applogo1;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Image = Properties.Resources.applogo1;
            logo.Location = new Point(-24, -22);
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
            roundPictureBox1.TabIndex = 35;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
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
            menu.TabIndex = 34;
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
            // EditService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(formPanel);
            Name = "EditService";
            Text = "EditService";
            Load += EditService_Load;
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
        private Button navigationButton;
        private Label descriptionErrors;
        private Label nameErrors;
        private Label label1;
        private TextBox descriptionField;
        private Button editBtn;
        private Label descriptionLabel;
        private TextBox nameField;
        private Label nameLabel;
        private PictureBox logo;
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