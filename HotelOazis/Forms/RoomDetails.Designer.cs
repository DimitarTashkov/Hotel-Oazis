namespace HotelOazis.Forms
{
    partial class RoomDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomDetails));
            roomLabel = new Label();
            mainContainer = new FlowLayoutPanel();
            roomContainer = new FlowLayoutPanel();
            supplementVisualsContainer = new Panel();
            reservateBtn = new Button();
            roomImage = new PictureBox();
            roomDataContainer = new Panel();
            roomNumber = new Label();
            editRoomBtn = new Button();
            roomDescription = new Label();
            roomAvaialability = new Label();
            roomPrice = new Label();
            roomType = new Label();
            roundPictureBox1 = new Fitness.Utilities.RoundPictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Rooms = new ToolStripMenuItem();
            Services = new ToolStripMenuItem();
            Reviews = new ToolStripMenuItem();
            Users = new ToolStripMenuItem();
            Reservations = new ToolStripMenuItem();
            MyReservations = new ToolStripMenuItem();
            mainContainer.SuspendLayout();
            roomContainer.SuspendLayout();
            supplementVisualsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomImage).BeginInit();
            roomDataContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // roomLabel
            // 
            roomLabel.BackColor = Color.Transparent;
            resources.ApplyResources(roomLabel, "roomLabel");
            roomLabel.Name = "roomLabel";
            // 
            // mainContainer
            // 
            resources.ApplyResources(mainContainer, "mainContainer");
            mainContainer.BackColor = SystemColors.InactiveCaption;
            mainContainer.Controls.Add(roomLabel);
            mainContainer.Controls.Add(roomContainer);
            mainContainer.Name = "mainContainer";
            // 
            // roomContainer
            // 
            roomContainer.Controls.Add(supplementVisualsContainer);
            roomContainer.Controls.Add(roomDataContainer);
            resources.ApplyResources(roomContainer, "roomContainer");
            roomContainer.Name = "roomContainer";
            // 
            // supplementVisualsContainer
            // 
            supplementVisualsContainer.BackColor = Color.Transparent;
            supplementVisualsContainer.Controls.Add(reservateBtn);
            supplementVisualsContainer.Controls.Add(roomImage);
            resources.ApplyResources(supplementVisualsContainer, "supplementVisualsContainer");
            supplementVisualsContainer.Name = "supplementVisualsContainer";
            // 
            // reservateBtn
            // 
            reservateBtn.BackColor = Color.LightGreen;
            resources.ApplyResources(reservateBtn, "reservateBtn");
            reservateBtn.Name = "reservateBtn";
            reservateBtn.UseVisualStyleBackColor = false;
            reservateBtn.Click += reservateBtn_Click;
            // 
            // roomImage
            // 
            resources.ApplyResources(roomImage, "roomImage");
            roomImage.Name = "roomImage";
            roomImage.TabStop = false;
            // 
            // roomDataContainer
            // 
            roomDataContainer.BackColor = Color.BlanchedAlmond;
            roomDataContainer.Controls.Add(roomNumber);
            roomDataContainer.Controls.Add(editRoomBtn);
            roomDataContainer.Controls.Add(roomDescription);
            roomDataContainer.Controls.Add(roomAvaialability);
            roomDataContainer.Controls.Add(roomPrice);
            roomDataContainer.Controls.Add(roomType);
            resources.ApplyResources(roomDataContainer, "roomDataContainer");
            roomDataContainer.Name = "roomDataContainer";
            // 
            // roomNumber
            // 
            resources.ApplyResources(roomNumber, "roomNumber");
            roomNumber.Name = "roomNumber";
            // 
            // editRoomBtn
            // 
            editRoomBtn.BackColor = Color.LightGray;
            resources.ApplyResources(editRoomBtn, "editRoomBtn");
            editRoomBtn.Name = "editRoomBtn";
            editRoomBtn.UseVisualStyleBackColor = false;
            editRoomBtn.Click += editRoomBtn_Click;
            // 
            // roomDescription
            // 
            resources.ApplyResources(roomDescription, "roomDescription");
            roomDescription.Name = "roomDescription";
            // 
            // roomAvaialability
            // 
            resources.ApplyResources(roomAvaialability, "roomAvaialability");
            roomAvaialability.Name = "roomAvaialability";
            // 
            // roomPrice
            // 
            resources.ApplyResources(roomPrice, "roomPrice");
            roomPrice.Name = "roomPrice";
            // 
            // roomType
            // 
            resources.ApplyResources(roomType, "roomType");
            roomType.Name = "roomType";
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
            // RoomDetails
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(mainContainer);
            Name = "RoomDetails";
            Load += RoomDetails_Load;
            mainContainer.ResumeLayout(false);
            roomContainer.ResumeLayout(false);
            supplementVisualsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomImage).EndInit();
            roomDataContainer.ResumeLayout(false);
            roomDataContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roomLabel;
        private FlowLayoutPanel mainContainer;
        private FlowLayoutPanel roomContainer;
        private Panel supplementVisualsContainer;
        private Button reservateBtn;
        private PictureBox roomImage;
        private Panel roomDataContainer;
        private Button editRoomBtn;
        private Label roomDescription;
        private Label roomAvaialability;
        private Label roomPrice;
        private Label roomType;
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