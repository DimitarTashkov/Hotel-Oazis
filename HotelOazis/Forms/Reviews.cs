using Fitness.Services;
using Fitness.Utilities;
using HotelOazis.Common.Constants;
using HotelOazis.DTOs.Review;
using HotelOazis.Models;
using HotelOazis.Models.Enumerations;
using HotelOazis.Properties;
using HotelOazis.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelOazis.Forms
{
    public partial class Reviews : Form
    {
        private readonly IReviewService reviewService;
        private readonly IUserService userService;
        private readonly User activeUser;

        private int index = 1;

        public Reviews(IReviewService reviewService, IUserService userService)
        {
            this.reviewService = reviewService;
            InitializeComponent();
            this.userService = userService;
            activeUser = userService.GetLoggedInUserAsync();
        }
        private void AddReviewToContainer(ReviewViewModel review)
        {
            Panel reviewContainer = InitializeReviewContainer();

            RoundPictureBox userPfp = InitializeProfilePicture();
            userPfp.ImageLocation = review.ProfilePicture;

            Label reviewUsername = InitializeReviewUsername();
            reviewUsername.Text = review.Username;

            TextBox reviewTextArea = InitializeTextArea();
            reviewTextArea.Text = review.Messages;
            reviewTextArea.Enabled = false;

            Label date = new Label
            {
                Name = $"date{index}",
                Font = FontsPicker.DetailsFont,
                Text = $"On: {review.PublishedOn:yyyy/MM/dd}  At: {review.PublishedOn:HH:mm}",
                Location = new Point(reviewContainer.Location.X + 190, reviewContainer.Location.Y + 10),
                BackColor = Color.Transparent,
                AutoSize = true
            };

            Label reviewState = new Label()
            {
                Name = $"reviewState{index}",
                Font = FontsPicker.DetailsFont,
                Text = $"{review.MessageStatus}",
                Location = new Point(reviewContainer.Location.X + 450, reviewContainer.Location.Y + 10),
                BackColor = Color.Transparent
            };

            ComboBox reviewStatus = new ComboBox
            {
                Name = $"reviewStatus{index}",
                Font = FontsPicker.DetailsFont,
                Cursor = Cursors.Default,
                Location = new Point(reviewContainer.Location.X + 560, reviewContainer.Location.Y + 10),
                SelectedItem = review.MessageStatus.ToString(),
                Enabled = true
            };

            reviewStatus.Items.AddRange(Enum.GetNames(typeof(FeedbackStatus)));
            reviewStatus.SelectedIndexChanged += async (s, e) =>
            {
                review.MessageStatus = (FeedbackStatus)reviewStatus.SelectedIndex;
                await reviewService.EditReviewAsync(new ReviewEditInputModel
                {
                    Id = review.Id,
                    Message = review.Messages,
                    PublishedOn = review.PublishedOn,
                    Rating = review.Rating,
                    MessageStatus = review.MessageStatus,
                    UserId = activeUser.Id
                });

                reviewState.Text = $"{review.MessageStatus}";
            };

            userPfp.Location = new Point(reviewContainer.Location.X + 10, reviewContainer.Location.Y + 20);
            reviewUsername.Location = new Point(reviewContainer.Location.X + 85, reviewContainer.Location.Y + 10);
            reviewTextArea.Location = new Point(reviewContainer.Location.X + 80, reviewContainer.Location.Y + 35);

            Button editReview = new Button
            {
                Name = $"editBtn{index}",
                Text = "Edit",
                BackColor = Color.LightGray,
                Font = FontsPicker.DetailsFont,
                Location = new Point(reviewContainer.Location.X + 560, reviewContainer.Location.Y + 40),
                Size = new Size(65, 40)
            };
            editReview.Click += (s, e) =>
            {
                reviewTextArea.Enabled = true;
                ActiveControl = reviewTextArea;
            };

            reviewTextArea.MouseUp += async (s, e) =>
            {
                reviewTextArea.Enabled = false;
                review.Messages = reviewTextArea.Text;
                await reviewService.EditReviewAsync(new ReviewEditInputModel
                {
                    Id = review.Id,
                    Message = review.Messages,
                    PublishedOn = DateTime.Now,
                    Rating = review.Rating,
                    MessageStatus = review.MessageStatus,
                    UserId = activeUser.Id
                });

                date.Text = $"On: {DateTime.Now:yyyy/MM/dd}  At: {DateTime.Now:HH:mm}";
            };

            Button deleteReview = new Button
            {
                Name = $"deleteBtn{index}",
                Text = "Delete",
                BackColor = Color.Red,
                Font = FontsPicker.DetailsFont,
                Location = new Point(reviewContainer.Location.X + 630, reviewContainer.Location.Y + 40),
                Size = new Size(65, 40)
            };

            deleteReview.Click += async (s, e) =>
            {
                await reviewService.DeleteReviewAsync(review.Id);
                MessageBox.Show("Review deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reviewsContainer.Controls.Remove(reviewContainer);
            };

            reviewContainer.Controls.Add(userPfp);
            reviewContainer.Controls.Add(reviewUsername);
            reviewContainer.Controls.Add(date);
            reviewContainer.Controls.Add(reviewState);
            reviewContainer.Controls.Add(reviewStatus);
            reviewContainer.Controls.Add(reviewTextArea);
            reviewContainer.Controls.Add(editReview);
            reviewContainer.Controls.Add(deleteReview);

            reviewsContainer.Controls.Add(reviewContainer);
        }
        private void AddWriteReviewSection()
        {
            Panel writeReviewContainer = InitializeReviewContainer();
            RoundPictureBox userWriteReviewPfp = InitializeProfilePicture();
            Label writeReviewUsername = InitializeReviewUsername();
            TextBox writeReviewTextArea = InitializeTextArea();

            userWriteReviewPfp.ImageLocation = activeUser.AvatarUrl;
            writeReviewUsername.Text = activeUser.Username;

            userWriteReviewPfp.Location = new Point(writeReviewContainer.Location.X + 10, writeReviewContainer.Location.Y + 20);
            writeReviewUsername.Location = new Point(writeReviewContainer.Location.X + 85, writeReviewContainer.Location.Y + 10);
            writeReviewTextArea.Location = new Point(writeReviewContainer.Location.X + 80, writeReviewContainer.Location.Y + 35);

            writeReviewTextArea.Click += (s, e) =>
            {
                writeReviewTextArea.Text = "";
                writeReviewTextArea.ForeColor = Color.Black;
            };

            writeReviewContainer.Controls.Add(userWriteReviewPfp);
            writeReviewContainer.Controls.Add(writeReviewUsername);
            writeReviewContainer.Controls.Add(writeReviewTextArea);

            Button sendReview = new Button
            {
                Name = "sendReview",
                Text = "Send",
                Font = FontsPicker.DetailsFont,
                BackColor = Color.LightGreen,
                Size = new Size(80, 40),
                Location = new Point(writeReviewContainer.Location.X + 560, writeReviewContainer.Location.Y + 40)
            };

            sendReview.Click += async (s, e) =>
            {
                var newReview = new ReviewInputModel
                {
                    Message = writeReviewTextArea.Text,
                    PublishedOn = DateTime.Now,
                    MessageStatus = FeedbackStatus.Unverified,
                    UserId = activeUser.Id,
                    Rating = 0
                };

                await reviewService.CreateReviewAsync(newReview);
                MessageBox.Show("Review added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reviews reloadForm = new Reviews(reviewService, userService);
                Program.SwitchMainForm(reloadForm);
            };

            writeReviewContainer.Controls.Add(sendReview);
            reviewsContainer.Controls.Add(writeReviewContainer);
        }

        private async void Reviews_Load(object sender, EventArgs e)
        {
            reviewsContainer.Padding = new Padding(5, 30, 5, 5);
            reviewsContainer.AutoScroll = true;

            // Add "Write a Review" section
            AddWriteReviewSection();

            // Load and display existing reviews
            var reviews = await reviewService.GetAllReviewsAsync();
            foreach (var review in reviews)
            {
                AddReviewToContainer(review);
            }
        }
        private Panel InitializeReviewContainer()
        {
            return new Panel
            {
                Size = new Size(710, 150),
                Name = $"reviewContainer{index++}",
                BackgroundImage = Resources.gradient_img__4_,
                AutoSize = false
            };
        }

        private RoundPictureBox InitializeProfilePicture()
        {
            return new RoundPictureBox
            {
                Name = $"userPfp{index}",
                Size = new Size(60, 60),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        }

        private Label InitializeReviewUsername()
        {
            return new Label
            {
                Name = $"reviewUsername{index}",
                Font = FontsPicker.DetailsFont,
                BackColor = Color.Transparent
            };
        }

        private TextBox InitializeTextArea()
        {
            return new TextBox
            {
                Name = $"reviewTextArea{index}",
                Text = "Write your review here...",
                Font = FontsPicker.DetailsFont,
                MinimumSize = new Size(475, 44),
                ForeColor = Color.DimGray
            };
        }
    }
}
