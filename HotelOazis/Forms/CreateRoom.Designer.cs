﻿namespace HotelOazis.Forms
{
    partial class CreateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoom));
            formPanel = new Panel();
            roomNumberErrors = new Label();
            roomNumberField = new TextBox();
            roomNumber = new Label();
            imageErrors = new Label();
            priceErrors = new Label();
            typeErrors = new Label();
            roomTypes = new ComboBox();
            navigationButton = new Button();
            roomPicture = new PictureBox();
            uploadRoom = new Button();
            uploadImage = new Button();
            descriptionField = new TextBox();
            descriptionLabel = new Label();
            priceField = new TextBox();
            priceLabel = new Label();
            typeLabel = new Label();
            logo = new PictureBox();
            roomLabel = new Label();
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
            ((System.ComponentModel.ISupportInitialize)roomPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // formPanel
            // 
            resources.ApplyResources(formPanel, "formPanel");
            formPanel.BackColor = SystemColors.Control;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__4_;
            formPanel.Controls.Add(roomNumberErrors);
            formPanel.Controls.Add(roomNumberField);
            formPanel.Controls.Add(roomNumber);
            formPanel.Controls.Add(imageErrors);
            formPanel.Controls.Add(priceErrors);
            formPanel.Controls.Add(typeErrors);
            formPanel.Controls.Add(roomTypes);
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(roomPicture);
            formPanel.Controls.Add(uploadRoom);
            formPanel.Controls.Add(uploadImage);
            formPanel.Controls.Add(descriptionField);
            formPanel.Controls.Add(descriptionLabel);
            formPanel.Controls.Add(priceField);
            formPanel.Controls.Add(priceLabel);
            formPanel.Controls.Add(typeLabel);
            formPanel.Controls.Add(logo);
            formPanel.Controls.Add(roomLabel);
            formPanel.Name = "formPanel";
            // 
            // roomNumberErrors
            // 
            resources.ApplyResources(roomNumberErrors, "roomNumberErrors");
            roomNumberErrors.BackColor = Color.Transparent;
            roomNumberErrors.ForeColor = Color.Red;
            roomNumberErrors.Name = "roomNumberErrors";
            // 
            // roomNumberField
            // 
            resources.ApplyResources(roomNumberField, "roomNumberField");
            roomNumberField.BackColor = Color.LightGray;
            roomNumberField.ForeColor = Color.DimGray;
            roomNumberField.Name = "roomNumberField";
            // 
            // roomNumber
            // 
            resources.ApplyResources(roomNumber, "roomNumber");
            roomNumber.BackColor = Color.Transparent;
            roomNumber.Name = "roomNumber";
            // 
            // imageErrors
            // 
            resources.ApplyResources(imageErrors, "imageErrors");
            imageErrors.BackColor = Color.Transparent;
            imageErrors.ForeColor = Color.Red;
            imageErrors.Name = "imageErrors";
            // 
            // priceErrors
            // 
            resources.ApplyResources(priceErrors, "priceErrors");
            priceErrors.BackColor = Color.Transparent;
            priceErrors.ForeColor = Color.Red;
            priceErrors.Name = "priceErrors";
            // 
            // typeErrors
            // 
            resources.ApplyResources(typeErrors, "typeErrors");
            typeErrors.BackColor = Color.Transparent;
            typeErrors.ForeColor = Color.Red;
            typeErrors.Name = "typeErrors";
            // 
            // roomTypes
            // 
            resources.ApplyResources(roomTypes, "roomTypes");
            roomTypes.FormattingEnabled = true;
            roomTypes.Name = "roomTypes";
            // 
            // navigationButton
            // 
            resources.ApplyResources(navigationButton, "navigationButton");
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Name = "navigationButton";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // roomPicture
            // 
            resources.ApplyResources(roomPicture, "roomPicture");
            roomPicture.Name = "roomPicture";
            roomPicture.TabStop = false;
            // 
            // uploadRoom
            // 
            resources.ApplyResources(uploadRoom, "uploadRoom");
            uploadRoom.BackColor = Color.LightGreen;
            uploadRoom.Name = "uploadRoom";
            uploadRoom.UseVisualStyleBackColor = false;
            uploadRoom.Click += createButton_Click;
            // 
            // uploadImage
            // 
            resources.ApplyResources(uploadImage, "uploadImage");
            uploadImage.Name = "uploadImage";
            uploadImage.UseVisualStyleBackColor = true;
            uploadImage.Click += uploadImage_click;
            // 
            // descriptionField
            // 
            resources.ApplyResources(descriptionField, "descriptionField");
            descriptionField.BackColor = Color.LightGray;
            descriptionField.ForeColor = Color.DimGray;
            descriptionField.Name = "descriptionField";
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(descriptionLabel, "descriptionLabel");
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Name = "descriptionLabel";
            // 
            // priceField
            // 
            resources.ApplyResources(priceField, "priceField");
            priceField.BackColor = Color.LightGray;
            priceField.ForeColor = Color.DimGray;
            priceField.Name = "priceField";
            // 
            // priceLabel
            // 
            resources.ApplyResources(priceLabel, "priceLabel");
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Name = "priceLabel";
            // 
            // typeLabel
            // 
            resources.ApplyResources(typeLabel, "typeLabel");
            typeLabel.BackColor = Color.Transparent;
            typeLabel.Name = "typeLabel";
            // 
            // logo
            // 
            resources.ApplyResources(logo, "logo");
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.applogo1;
            logo.Image = Properties.Resources.applogo1;
            logo.Name = "logo";
            logo.TabStop = false;
            // 
            // roomLabel
            // 
            resources.ApplyResources(roomLabel, "roomLabel");
            roomLabel.BackColor = Color.Transparent;
            roomLabel.Name = "roomLabel";
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
            // CreateRoom
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(formPanel);
            Name = "CreateRoom";
            Load += CreateRoom_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomPicture).EndInit();
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
        private PictureBox roomPicture;
        private Button uploadRoom;
        private Button uploadImage;
        private TextBox descriptionField;
        private Label descriptionLabel;
        private TextBox priceField;
        private Label priceLabel;
        private Label typeLabel;
        private PictureBox logo;
        private Label roomLabel;
        private ComboBox roomTypes;
        private Label imageErrors;
        private Label priceErrors;
        private Label typeErrors;
        private Label roomNumberErrors;
        private TextBox roomNumberField;
        private Label roomNumber;
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