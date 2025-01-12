namespace HotelOazis.Forms
{
    partial class Reservations
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
            reservationsContainer = new FlowLayoutPanel();
            ordersLabel = new Label();
            navigationButton = new Button();
            SuspendLayout();
            // 
            // reservationsContainer
            // 
            reservationsContainer.AutoScroll = true;
            reservationsContainer.Location = new Point(20, 37);
            reservationsContainer.Name = "reservationsContainer";
            reservationsContainer.Size = new Size(760, 400);
            reservationsContainer.TabIndex = 6;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.BackColor = Color.Transparent;
            ordersLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic);
            ordersLabel.ForeColor = Color.White;
            ordersLabel.Location = new Point(331, 10);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(164, 25);
            ordersLabel.TabIndex = 5;
            ordersLabel.Text = "Reservations";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(2, 2);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(148, 29);
            navigationButton.TabIndex = 7;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(reservationsContainer);
            Controls.Add(ordersLabel);
            Controls.Add(navigationButton);
            Name = "Reservations";
            Text = "Reservations";
            Load += Reservations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel reservationsContainer;
        private Label ordersLabel;
        private Button navigationButton;
    }
}