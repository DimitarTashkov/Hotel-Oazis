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
            comboBox1 = new ComboBox();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.Controls.Add(comboBox1);
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
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.Location = new Point(8, 318);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(200, 45);
            navigationButton.TabIndex = 18;
            navigationButton.Text = "Return to catalog";
            navigationButton.UseVisualStyleBackColor = false;
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
            // 
            // descriptionField
            // 
            descriptionField.BackColor = Color.LightGray;
            descriptionField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            descriptionField.ForeColor = Color.DimGray;
            descriptionField.Location = new Point(21, 222);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(414, 23);
            descriptionField.TabIndex = 12;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            descriptionLabel.Location = new Point(181, 176);
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
            priceField.Location = new Point(115, 132);
            priceField.Name = "priceField";
            priceField.Size = new Size(244, 23);
            priceField.TabIndex = 8;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            priceLabel.Location = new Point(193, 106);
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
            typeLabel.Location = new Point(193, 40);
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
            roomLabel.Location = new Point(270, 0);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(130, 25);
            roomLabel.TabIndex = 0;
            roomLabel.Text = "Room info";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Single", "Double", "Triple", "Quad", "Family" });
            comboBox1.Location = new Point(115, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 23);
            comboBox1.TabIndex = 19;
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
        private ComboBox comboBox1;
    }
}