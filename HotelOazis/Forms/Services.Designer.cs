namespace HotelOazis.Forms
{
    partial class Services
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
            servicesContainer = new FlowLayoutPanel();
            servicesLabel = new Label();
            navigationButton = new Button();
            addService = new Button();
            SuspendLayout();
            // 
            // servicesContainer
            // 
            servicesContainer.AutoScroll = true;
            servicesContainer.Location = new Point(29, 43);
            servicesContainer.Name = "servicesContainer";
            servicesContainer.Size = new Size(760, 400);
            servicesContainer.TabIndex = 6;
            // 
            // servicesLabel
            // 
            servicesLabel.AutoSize = true;
            servicesLabel.BackColor = Color.Transparent;
            servicesLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic);
            servicesLabel.ForeColor = Color.Black;
            servicesLabel.Location = new Point(351, 9);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new Size(110, 25);
            servicesLabel.TabIndex = 5;
            servicesLabel.Text = "Services";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(11, 8);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(148, 29);
            navigationButton.TabIndex = 7;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // addService
            // 
            addService.BackColor = Color.LightGreen;
            addService.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addService.Location = new Point(640, 5);
            addService.Name = "addService";
            addService.Size = new Size(148, 29);
            addService.TabIndex = 8;
            addService.Text = "Add";
            addService.UseVisualStyleBackColor = false;
            addService.Visible = false;
            addService.Click += addService_Click;
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(addService);
            Controls.Add(servicesContainer);
            Controls.Add(servicesLabel);
            Controls.Add(navigationButton);
            Name = "Services";
            Text = "Services";
            Load += Services_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel servicesContainer;
        private Label servicesLabel;
        private Button navigationButton;
        private Button addService;
    }
}