using HotelOazis.DTOs.Room;
using HotelOazis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOazis.Services.Interfaces
{
    public interface IRoomService : IValidateModel
    {
        Task<List<RoomViewModel>> GetRoomsAsync();

        Task<bool> ReserveRoomAsync(Guid roomId, User activeUser);

        Task<bool> DeleteRoomAsync(Guid roomId);

        Task<bool> AddRoomAsync(RoomInputModel newRoom);

        Task<bool> EditRoomAsync(Guid roomId, EditRoomInputModel updatedRoom);
    }
}
