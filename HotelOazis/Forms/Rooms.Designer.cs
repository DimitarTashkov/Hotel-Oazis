namespace HotelOazis.Forms
{
    partial class Rooms
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
            navigationButton = new Button();
            addSupplement = new Button();
            mainContainer = new FlowLayoutPanel();
            servicesLabel = new Label();
            SuspendLayout();
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(3, 0);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(148, 29);
            navigationButton.TabIndex = 7;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // addSupplement
            // 
            addSupplement.BackColor = Color.LightGreen;
            addSupplement.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addSupplement.Location = new Point(649, 0);
            addSupplement.Name = "addSupplement";
            addSupplement.Size = new Size(148, 29);
            addSupplement.TabIndex = 4;
            addSupplement.Text = "Add";
            addSupplement.UseVisualStyleBackColor = false;
            addSupplement.Click += addSupplement_Click;
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.Location = new Point(38, 46);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(723, 391);
            mainContainer.TabIndex = 5;
            // 
            // servicesLabel
            // 
            servicesLabel.AutoSize = true;
            servicesLabel.BackColor = Color.Transparent;
            servicesLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic);
            servicesLabel.ForeColor = Color.Black;
            servicesLabel.Location = new Point(351, 9);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new Size(90, 25);
            servicesLabel.TabIndex = 8;
            servicesLabel.Text = "Rooms";
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(servicesLabel);
            Controls.Add(navigationButton);
            Controls.Add(addSupplement);
            Controls.Add(mainContainer);
            Name = "Rooms";
            Text = "Rooms";
            Load += Rooms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button navigationButton;
        private Button addSupplement;
        private FlowLayoutPanel mainContainer;
        private Label servicesLabel;
    }
}