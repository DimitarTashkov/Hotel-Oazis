using Fitness.Utilities;
using HotelOazis.DTOs.Service;
using HotelOazis.Extensions;
using HotelOazis.Models;
using HotelOazis.Services.Interfaces;
using HotelOazis.Utilities;
using static HotelOazis.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace HotelOazis.Forms
{
    public partial class CreateService : Form
    {
        private readonly IFacilityService facilityService;
        private readonly IUserService userService;
        private readonly IReviewService reviewService;
        private readonly IRoomService roomService;
        private User activeUser;

        public CreateService(IUserService userService, IFacilityService facilityService)
        {
            InitializeComponent();
            this.userService = userService;
            this.facilityService = facilityService;
            this.reviewService = ServiceLocator.GetService<IReviewService>();
            this.roomService = ServiceLocator.GetService<IRoomService>();

            LoadUserDataAsync();
            ApplyStyles();
        }

        private void LoadUserDataAsync()
        {
            activeUser = userService.GetLoggedInUserAsync();
            roundPictureBox1.ImageLocation = activeUser?.AvatarUrl;
        }

        private void ApplyStyles()
        {
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Стилове за бутони
            createBtn.BackColor = Color.FromArgb(39, 174, 96);
            createBtn.ForeColor = Color.White;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.FlatAppearance.BorderSize = 0;
            createBtn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            createBtn.MouseEnter += (s, e) => createBtn.BackColor = Color.FromArgb(33, 154, 82);
            createBtn.MouseLeave += (s, e) => createBtn.BackColor = Color.FromArgb(39, 174, 96);

            navigationButton.BackColor = Color.FromArgb(149, 165, 166);
            navigationButton.ForeColor = Color.White;
            navigationButton.FlatStyle = FlatStyle.Flat;
            navigationButton.FlatAppearance.BorderSize = 0;
            navigationButton.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            navigationButton.MouseEnter += (s, e) => navigationButton.BackColor = Color.FromArgb(127, 140, 141);
            navigationButton.MouseLeave += (s, e) => navigationButton.BackColor = Color.FromArgb(149, 165, 166);

            // Стилове за текстови полета
            nameField.Font = new Font("Segoe UI", 11);
            descriptionField.Font = new Font("Segoe UI", 11);
            nameField.BackColor = Color.White;
            descriptionField.BackColor = Color.White;
            nameField.BorderStyle = BorderStyle.FixedSingle;
            descriptionField.BorderStyle = BorderStyle.FixedSingle;

            // Стилове за етикети
            nameLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            descriptionLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(44, 62, 80);
            descriptionLabel.ForeColor = Color.FromArgb(44, 62, 80);
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            createBtn.BackColor = Color.DarkGreen;

            List<TextBox> inputs = new List<TextBox>
            {
                nameField,
                descriptionField
            };

            bool areInputsValid = ValidationHelper.ValidateUserInputs(inputs);
            if (!areInputsValid)
            {
                MessageBox.Show(EmptyInputData, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serviceName = nameField.Text;
            string serviceDescription = descriptionField.Text;

            ServiceInputModel serviceInputModel = new ServiceInputModel
            {
                Name = serviceName,
                Description = serviceDescription,
            };

            var (isValid, errors) = await facilityService.ValidateModelAsync(serviceInputModel);

            if (!isValid)
            {
                foreach (var error in errors)
                {
                    if (error.MemberNames.Contains(nameof(serviceInputModel.Name)))
                    {
                        nameErrors.Text = error.ErrorMessage;
                        nameErrors.Visible = true;
                    }
                    if (error.MemberNames.Contains(nameof(serviceInputModel.Description)))
                    {
                        descriptionErrors.Text = error.ErrorMessage;
                        descriptionErrors.Visible = true;
                    }
                }
                return;
            }

            bool isCreated = await facilityService.AddServiceAsync(serviceInputModel);
            if (isCreated)
            {
                MessageBox.Show(CreatedSuccessfully, Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Services servicesForm = new Services(facilityService, userService);
                Program.SwitchMainForm(servicesForm);
            }
            else
            {
                MessageBox.Show(CreateFailed, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Services servicesForm = new Services(facilityService, userService);
            Program.SwitchMainForm(servicesForm);
        }

        private void CreateService_Load(object sender, EventArgs e)
        {
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            if (isAdmin)
            {
                Users.Visible = true;
                Reservations.Visible = true;
            }

            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;
        }

        private void menu_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            string formName = item.Name;
            Form form = new Form();

            switch (formName)
            {
                case "Rooms":
                    form = new Rooms(roomService, userService);
                    break;
                case "Services":
                    form = new Services(facilityService, userService);
                    break;
                case "Reviews":
                    form = new Reviews(reviewService, userService);
                    break;
                case "Profile":
                    form = new Profile(userService, activeUser.Id);
                    break;
                case "Users":
                    form = new Users(userService);
                    break;
                case "MyReservations":
                    form = new Reservations(userService, roomService);
                    break;
                case "Reservations":
                    form = new Reservations(userService, roomService);
                    break;
                case "Home":
                    form = new Index(userService);
                    break;
                default:
                    form = new Index(userService);
                    break;
            }
            Program.SwitchMainForm(form);
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(userService, activeUser.Id);
            Program.SwitchMainForm(profileForm);
        }
    }
}