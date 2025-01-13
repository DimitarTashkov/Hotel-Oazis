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
            ordersLabel = new Label();
            navigationButton = new Button();
            SuspendLayout();
            // 
            // reviewsContainer
            // 
            reviewsContainer.AutoScroll = true;
            reviewsContainer.Location = new Point(29, 43);
            reviewsContainer.Name = "reviewsContainer";
            reviewsContainer.Size = new Size(760, 400);
            reviewsContainer.TabIndex = 9;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.BackColor = Color.Transparent;
            ordersLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic);
            ordersLabel.ForeColor = Color.White;
            ordersLabel.Location = new Point(331, 15);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(136, 25);
            ordersLabel.TabIndex = 8;
            ordersLabel.Text = "Comments";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(11, 8);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(148, 29);
            navigationButton.TabIndex = 10;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            // 
            // Reviews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(reviewsContainer);
            Controls.Add(ordersLabel);
            Controls.Add(navigationButton);
            Name = "Reviews";
            Text = "Reviews";
            Load += Reviews_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel reviewsContainer;
        private Label ordersLabel;
        private Button navigationButton;
    }
}