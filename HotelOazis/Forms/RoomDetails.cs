﻿using HotelOazis.DTOs.Room;
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
    public partial class RoomDetails : Form
    {
        public RoomDetails(IRoomService roomService, IUserService userService, RoomDetailsViewModel model)
        {
            InitializeComponent();
        }
    }
}
