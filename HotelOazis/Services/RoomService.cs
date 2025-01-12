using HotelOazis.DTOs.Room;
using HotelOazis.Models.DbConfiguration;
using HotelOazis.Models;
using HotelOazis.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using HotelOazis.Services;

public class RoomService : BaseService, IRoomService
{
    private readonly HotelContext context;

    public RoomService(HotelContext context)
    {
        this.context = context;
    }

    public async Task<List<RoomViewModel>> GetRoomsAsync()
    {
        return await context.Rooms
            .Select(r => new RoomViewModel
            {
                Id = r.Id,
                RoomNumber = r.Number,
                Type = r.Type,
                IsAvailable = r.IsAvailable,
                PictureLocation = r.Picture,
                Price = r.Price,
                Description = r.Description,
            })
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<bool> ReserveRoomAsync(Guid roomId, User activeUser)
    {
        //!!!!Pass view model 
        var reservationExists = await context.Reservations.AnyAsync(r => r.RoomId == roomId);

        if (!reservationExists)
        {
            var reservation = new Reservation
            {
                RoomId = roomId,
                UserId = activeUser.Id,
                CheckInDate = DateTime.UtcNow
            };

            context.Reservations.Add(reservation);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> DeleteRoomAsync(Guid roomId)
    {
        var room = await context.Rooms.FirstOrDefaultAsync(r => r.Id == roomId);
        if (room != null)
        {
            context.Rooms.Remove(room);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> AddRoomAsync(RoomInputModel newRoom)
    {
        if (newRoom == null) return false;

        var room = new Room
        {
            Id = Guid.NewGuid(),
            Number = newRoom.RoomNumber,
            Type = newRoom.Type,
            Price = newRoom.Price,
            Picture = newRoom.PictureLocation,
            Description = newRoom.Description,
            IsAvailable = true,
        };

        context.Rooms.Add(room);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> EditRoomAsync(EditRoomInputModel updatedRoom)
    {
        var room = await context.Rooms.FirstOrDefaultAsync(r => r.Id == updatedRoom.Id);
        if (room != null)
        {
            room.Type = updatedRoom.Type;
            room.Number = updatedRoom.RoomNumber;
            room.IsAvailable = updatedRoom.IsAvailable;
            room.Picture = updatedRoom.PictureLocation;
            room.Price = updatedRoom.Price;
            room.Description = updatedRoom.Description;

            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }
    public async Task<bool> IsRoomNumberUnique(int roomNumber)
    {

        return !context.Rooms.Any(r => r.Number == roomNumber);
    }
    public async Task<int> GenerateUniqueRoomNumber()
    {
        int newRoomNumber = 1;

        while (!await IsRoomNumberUnique(newRoomNumber))
        {
            newRoomNumber++;
        }

        return newRoomNumber;
    }

}
