namespace HotelOazis.Forms
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
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
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
            formPanel.Location = new Point(71, 25);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(659, 400);
            formPanel.TabIndex = 2;
            // 
            // roomNumberErrors
            // 
            roomNumberErrors.AutoSize = true;
            roomNumberErrors.BackColor = Color.Transparent;
            roomNumberErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roomNumberErrors.ForeColor = Color.Red;
            roomNumberErrors.Location = new Point(115, 79);
            roomNumberErrors.Name = "roomNumberErrors";
            roomNumberErrors.Size = new Size(47, 13);
            roomNumberErrors.TabIndex = 25;
            roomNumberErrors.Text = "label1";
            roomNumberErrors.Visible = false;
            // 
            // roomNumberField
            // 
            roomNumberField.BackColor = Color.LightGray;
            roomNumberField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            roomNumberField.ForeColor = Color.DimGray;
            roomNumberField.Location = new Point(115, 53);
            roomNumberField.Name = "roomNumberField";
            roomNumberField.Size = new Size(244, 23);
            roomNumberField.TabIndex = 24;
            // 
            // roomNumber
            // 
            roomNumber.AutoSize = true;
            roomNumber.BackColor = Color.Transparent;
            roomNumber.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            roomNumber.Location = new Point(193, 23);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(89, 18);
            roomNumber.TabIndex = 23;
            roomNumber.Text = "*Number";
            // 
            // imageErrors
            // 
            imageErrors.AutoSize = true;
            imageErrors.BackColor = Color.Transparent;
            imageErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            imageErrors.ForeColor = Color.Red;
            imageErrors.Location = new Point(451, 255);
            imageErrors.Name = "imageErrors";
            imageErrors.Size = new Size(47, 13);
            imageErrors.TabIndex = 22;
            imageErrors.Text = "label1";
            imageErrors.Visible = false;
            // 
            // priceErrors
            // 
            priceErrors.AutoSize = true;
            priceErrors.BackColor = Color.Transparent;
            priceErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            priceErrors.ForeColor = Color.Red;
            priceErrors.Location = new Point(115, 213);
            priceErrors.Name = "priceErrors";
            priceErrors.Size = new Size(47, 13);
            priceErrors.TabIndex = 21;
            priceErrors.Text = "label1";
            priceErrors.Visible = false;
            // 
            // typeErrors
            // 
            typeErrors.AutoSize = true;
            typeErrors.BackColor = Color.Transparent;
            typeErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            typeErrors.ForeColor = Color.Red;
            typeErrors.Location = new Point(115, 146);
            typeErrors.Name = "typeErrors";
            typeErrors.Size = new Size(47, 13);
            typeErrors.TabIndex = 20;
            typeErrors.Text = "label1";
            typeErrors.Visible = false;
            // 
            // roomTypes
            // 
            roomTypes.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roomTypes.FormattingEnabled = true;
            roomTypes.Location = new Point(115, 119);
            roomTypes.Name = "roomTypes";
            roomTypes.Size = new Size(244, 24);
            roomTypes.TabIndex = 19;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.Location = new Point(8, 318);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(200, 45);
            navigationButton.TabIndex = 18;
            navigationButton.Text = "Return to rooms";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // roomPicture
            // 
            roomPicture.BackgroundImageLayout = ImageLayout.Stretch;
            roomPicture.Location = new Point(451, 16);
            roomPicture.Name = "roomPicture";
            roomPicture.Size = new Size(200, 200);
            roomPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            roomPicture.TabIndex = 17;
            roomPicture.TabStop = false;
            // 
            // uploadRoom
            // 
            uploadRoom.BackColor = Color.LightGreen;
            uploadRoom.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            uploadRoom.Location = new Point(451, 318);
            uploadRoom.Name = "uploadRoom";
            uploadRoom.Size = new Size(200, 45);
            uploadRoom.TabIndex = 15;
            uploadRoom.Text = "Create";
            uploadRoom.UseVisualStyleBackColor = false;
            uploadRoom.Click += createButton_Click;
            // 
            // uploadImage
            // 
            uploadImage.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            uploadImage.Location = new Point(451, 222);
            uploadImage.Name = "uploadImage";
            uploadImage.Size = new Size(200, 30);
            uploadImage.TabIndex = 13;
            uploadImage.Text = "Upload image";
            uploadImage.UseVisualStyleBackColor = true;
            uploadImage.Click += uploadImage_click;
            // 
            // descriptionField
            // 
            descriptionField.BackColor = Color.LightGray;
            descriptionField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            descriptionField.ForeColor = Color.DimGray;
            descriptionField.Location = new Point(20, 255);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(414, 23);
            descriptionField.TabIndex = 12;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            descriptionLabel.Location = new Point(181, 227);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(106, 18);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description";
            // 
            // priceField
            // 
            priceField.BackColor = Color.LightGray;
            priceField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            priceField.ForeColor = Color.DimGray;
            priceField.Location = new Point(115, 187);
            priceField.Name = "priceField";
            priceField.Size = new Size(244, 23);
            priceField.TabIndex = 8;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            priceLabel.Location = new Point(193, 157);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(94, 18);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "*Price(lv)";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.BackColor = Color.Transparent;
            typeLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            typeLabel.Location = new Point(193, 89);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(63, 18);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "*Type";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.applogo1;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Image = Properties.Resources.applogo1;
            logo.Location = new Point(-21, -16);
            logo.Name = "logo";
            logo.Size = new Size(150, 150);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.BackColor = Color.Transparent;
            roomLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic);
            roomLabel.Location = new Point(288, 0);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(130, 25);
            roomLabel.TabIndex = 0;
            roomLabel.Text = "Room info";
            // 
            // CreateRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(formPanel);
            Name = "CreateRoom";
            Text = "CreateRoom";
            Load += CreateRoom_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
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
    }
}