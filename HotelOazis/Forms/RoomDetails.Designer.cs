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
            roomLabel = new Label();
            mainContainer = new FlowLayoutPanel();
            roomContainer = new FlowLayoutPanel();
            supplementVisualsContainer = new Panel();
            reservateBtn = new Button();
            roomImage = new PictureBox();
            roomDataContainer = new Panel();
            editRoomBtn = new Button();
            roomDescription = new Label();
            roomAvaialability = new Label();
            roomPrice = new Label();
            roomType = new Label();
            navigationButton = new Button();
            roomNumber = new Label();
            mainContainer.SuspendLayout();
            roomContainer.SuspendLayout();
            supplementVisualsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomImage).BeginInit();
            roomDataContainer.SuspendLayout();
            SuspendLayout();
            // 
            // roomLabel
            // 
            roomLabel.BackColor = Color.Transparent;
            roomLabel.Font = new Font("Verdana", 14.25F, FontStyle.Italic);
            roomLabel.Location = new Point(33, 0);
            roomLabel.Name = "roomLabel";
            roomLabel.Padding = new Padding(0, 15, 0, 0);
            roomLabel.Size = new Size(717, 40);
            roomLabel.TabIndex = 0;
            roomLabel.Text = "Room Info";
            roomLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = SystemColors.InactiveCaption;
            mainContainer.Controls.Add(roomLabel);
            mainContainer.Controls.Add(roomContainer);
            mainContainer.Location = new Point(6, 46);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(30, 0, 0, 0);
            mainContainer.Size = new Size(800, 391);
            mainContainer.TabIndex = 5;
            // 
            // roomContainer
            // 
            roomContainer.Controls.Add(supplementVisualsContainer);
            roomContainer.Controls.Add(roomDataContainer);
            roomContainer.Location = new Point(33, 43);
            roomContainer.Name = "roomContainer";
            roomContainer.Padding = new Padding(1, 0, 0, 0);
            roomContainer.Size = new Size(717, 300);
            roomContainer.TabIndex = 1;
            // 
            // supplementVisualsContainer
            // 
            supplementVisualsContainer.BackColor = Color.Transparent;
            supplementVisualsContainer.Controls.Add(reservateBtn);
            supplementVisualsContainer.Controls.Add(roomImage);
            supplementVisualsContainer.Location = new Point(21, 40);
            supplementVisualsContainer.Margin = new Padding(20, 40, 3, 3);
            supplementVisualsContainer.Name = "supplementVisualsContainer";
            supplementVisualsContainer.Size = new Size(200, 240);
            supplementVisualsContainer.TabIndex = 0;
            // 
            // reservateBtn
            // 
            reservateBtn.BackColor = Color.LightGreen;
            reservateBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            reservateBtn.Location = new Point(0, 210);
            reservateBtn.Name = "reservateBtn";
            reservateBtn.Size = new Size(200, 30);
            reservateBtn.TabIndex = 1;
            reservateBtn.Text = "Reservate";
            reservateBtn.UseVisualStyleBackColor = false;
            reservateBtn.Click += reservateBtn_Click;
            // 
            // roomImage
            // 
            roomImage.BackgroundImageLayout = ImageLayout.Stretch;
            roomImage.Location = new Point(0, 0);
            roomImage.Name = "roomImage";
            roomImage.Size = new Size(200, 200);
            roomImage.SizeMode = PictureBoxSizeMode.StretchImage;
            roomImage.TabIndex = 0;
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
            roomDataContainer.Location = new Point(244, 30);
            roomDataContainer.Margin = new Padding(20, 30, 3, 3);
            roomDataContainer.Name = "roomDataContainer";
            roomDataContainer.Padding = new Padding(25, 25, 0, 0);
            roomDataContainer.Size = new Size(450, 250);
            roomDataContainer.TabIndex = 1;
            // 
            // editRoomBtn
            // 
            editRoomBtn.BackColor = Color.LightGray;
            editRoomBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            editRoomBtn.Location = new Point(130, 220);
            editRoomBtn.Name = "editRoomBtn";
            editRoomBtn.Size = new Size(200, 30);
            editRoomBtn.TabIndex = 4;
            editRoomBtn.Text = "Edit room";
            editRoomBtn.UseVisualStyleBackColor = false;
            editRoomBtn.Visible = false;
            editRoomBtn.Click += editRoomBtn_Click;
            // 
            // roomDescription
            // 
            roomDescription.AutoSize = true;
            roomDescription.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            roomDescription.Location = new Point(50, 140);
            roomDescription.Name = "roomDescription";
            roomDescription.Size = new Size(94, 16);
            roomDescription.TabIndex = 3;
            roomDescription.Text = "Description:";
            // 
            // roomAvaialability
            // 
            roomAvaialability.AutoSize = true;
            roomAvaialability.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            roomAvaialability.Location = new Point(50, 110);
            roomAvaialability.Name = "roomAvaialability";
            roomAvaialability.Size = new Size(92, 16);
            roomAvaialability.TabIndex = 2;
            roomAvaialability.Text = "Availability:";
            // 
            // roomPrice
            // 
            roomPrice.AutoSize = true;
            roomPrice.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            roomPrice.Location = new Point(50, 80);
            roomPrice.Name = "roomPrice";
            roomPrice.Size = new Size(47, 16);
            roomPrice.TabIndex = 1;
            roomPrice.Text = "Price:";
            // 
            // roomType
            // 
            roomType.AutoSize = true;
            roomType.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            roomType.Location = new Point(50, 50);
            roomType.Name = "roomType";
            roomType.Size = new Size(47, 16);
            roomType.TabIndex = 0;
            roomType.Text = "Type:";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.Location = new Point(6, 13);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(164, 27);
            navigationButton.TabIndex = 6;
            navigationButton.Text = "Return to rooms";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // roomNumber
            // 
            roomNumber.AutoSize = true;
            roomNumber.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roomNumber.Location = new Point(180, 10);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(64, 18);
            roomNumber.TabIndex = 5;
            roomNumber.Text = "Room:";
            // 
            // RoomDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(mainContainer);
            Controls.Add(navigationButton);
            Name = "RoomDetails";
            Text = "RoomDetails";
            Load += RoomDetails_Load;
            mainContainer.ResumeLayout(false);
            roomContainer.ResumeLayout(false);
            supplementVisualsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomImage).EndInit();
            roomDataContainer.ResumeLayout(false);
            roomDataContainer.PerformLayout();
            ResumeLayout(false);
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
        private Button navigationButton;
        private Label roomNumber;
    }
}