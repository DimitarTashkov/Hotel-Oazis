using HotelOazis.Services.Interfaces;
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
    public partial class Reservations : Form
    {
        private readonly IUserService userService;
        private readonly IRoomService roomService;
        public Reservations(IUserService userService, IRoomService roomService)
        {
            this.userService = userService;
            this.roomService = roomService;
            InitializeComponent();
        }
    }
}
