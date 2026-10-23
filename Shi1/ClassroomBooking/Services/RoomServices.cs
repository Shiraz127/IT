using ClassroomBooking.Models;
using System.Collections.Generic;

namespace ClassroomBooking.Services
{
    public class RoomService
    {
        private readonly List<Room> rooms = new List<Room>
        {
            new Room { Id = 1, Number = "301", ComputerCount = 15, IsAvailable = true, MaxGroupSize = 25 },
            new Room { Id = 2, Number = "302", ComputerCount = 20, IsAvailable = true, MaxGroupSize = 30 },
            new Room { Id = 3, Number = "305", ComputerCount = 12, IsAvailable = false, MaxGroupSize = 20 }
        };

        public List<Room> GetRooms()
        {
            return rooms;
        }
    }
}