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
            ordersContainer = new FlowLayoutPanel();
            totalPriceHeaders = new FlowLayoutPanel();
            userHeader = new Label();
            addressHeader = new Label();
            fromHeader = new Label();
            toHeader = new Label();
            daysHeader = new Label();
            pricePerNightHeader = new Label();
            arriveHeader = new Label();
            ordersLabel = new Label();
            navigationButton = new Button();
            ordersContainer.SuspendLayout();
            totalPriceHeaders.SuspendLayout();
            SuspendLayout();
            // 
            // ordersContainer
            // 
            ordersContainer.AutoScroll = true;
            ordersContainer.Controls.Add(totalPriceHeaders);
            ordersContainer.Location = new Point(20, 37);
            ordersContainer.Name = "ordersContainer";
            ordersContainer.Size = new Size(760, 400);
            ordersContainer.TabIndex = 6;
            // 
            // totalPriceHeaders
            // 
            totalPriceHeaders.BackColor = Color.Cyan;
            totalPriceHeaders.Controls.Add(userHeader);
            totalPriceHeaders.Controls.Add(addressHeader);
            totalPriceHeaders.Controls.Add(fromHeader);
            totalPriceHeaders.Controls.Add(toHeader);
            totalPriceHeaders.Controls.Add(daysHeader);
            totalPriceHeaders.Controls.Add(pricePerNightHeader);
            totalPriceHeaders.Controls.Add(arriveHeader);
            totalPriceHeaders.Location = new Point(8, 8);
            totalPriceHeaders.Margin = new Padding(8);
            totalPriceHeaders.Name = "totalPriceHeaders";
            totalPriceHeaders.Padding = new Padding(10);
            totalPriceHeaders.Size = new Size(725, 32);
            totalPriceHeaders.TabIndex = 0;
            // 
            // userHeader
            // 
            userHeader.AutoSize = true;
            userHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            userHeader.Location = new Point(40, 10);
            userHeader.Margin = new Padding(30, 0, 3, 0);
            userHeader.Name = "userHeader";
            userHeader.Size = new Size(40, 16);
            userHeader.TabIndex = 0;
            userHeader.Text = "User";
            // 
            // addressHeader
            // 
            addressHeader.AutoSize = true;
            addressHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            addressHeader.Location = new Point(113, 10);
            addressHeader.Margin = new Padding(30, 0, 3, 0);
            addressHeader.Name = "addressHeader";
            addressHeader.Size = new Size(49, 16);
            addressHeader.TabIndex = 1;
            addressHeader.Text = "Room";
            // 
            // fromHeader
            // 
            fromHeader.AutoSize = true;
            fromHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            fromHeader.Location = new Point(195, 10);
            fromHeader.Margin = new Padding(30, 0, 3, 0);
            fromHeader.Name = "fromHeader";
            fromHeader.Size = new Size(44, 16);
            fromHeader.TabIndex = 2;
            fromHeader.Text = "From";
            // 
            // toHeader
            // 
            toHeader.AutoSize = true;
            toHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            toHeader.Location = new Point(277, 10);
            toHeader.Margin = new Padding(35, 0, 3, 0);
            toHeader.Name = "toHeader";
            toHeader.Size = new Size(24, 16);
            toHeader.TabIndex = 3;
            toHeader.Text = "To";
            // 
            // daysHeader
            // 
            daysHeader.AutoSize = true;
            daysHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            daysHeader.Location = new Point(339, 10);
            daysHeader.Margin = new Padding(35, 0, 3, 0);
            daysHeader.Name = "daysHeader";
            daysHeader.Size = new Size(44, 16);
            daysHeader.TabIndex = 4;
            daysHeader.Text = "Days";
            // 
            // pricePerNightHeader
            // 
            pricePerNightHeader.AutoSize = true;
            pricePerNightHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            pricePerNightHeader.Location = new Point(421, 10);
            pricePerNightHeader.Margin = new Padding(35, 0, 3, 0);
            pricePerNightHeader.Name = "pricePerNightHeader";
            pricePerNightHeader.Size = new Size(111, 16);
            pricePerNightHeader.TabIndex = 5;
            pricePerNightHeader.Text = "Price per night";
            // 
            // arriveHeader
            // 
            arriveHeader.AutoSize = true;
            arriveHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            arriveHeader.Location = new Point(585, 10);
            arriveHeader.Margin = new Padding(50, 0, 3, 0);
            arriveHeader.Name = "arriveHeader";
            arriveHeader.Size = new Size(82, 16);
            arriveHeader.TabIndex = 6;
            arriveHeader.Text = "Total price";
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
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appback;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ordersContainer);
            Controls.Add(ordersLabel);
            Controls.Add(navigationButton);
            Name = "Reservations";
            Text = "Reservations";
            ordersContainer.ResumeLayout(false);
            totalPriceHeaders.ResumeLayout(false);
            totalPriceHeaders.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel ordersContainer;
        private FlowLayoutPanel totalPriceHeaders;
        private Label userHeader;
        private Label addressHeader;
        private Label fromHeader;
        private Label toHeader;
        private Label daysHeader;
        private Label pricePerNightHeader;
        private Label arriveHeader;
        private Label ordersLabel;
        private Button navigationButton;
    }
}