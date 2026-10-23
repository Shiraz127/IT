
namespace ClassroomBooking.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; } = "";
        public int ComputerCount { get; set; }
        public bool IsAvailable { get; set; }
        public int MaxGroupSize { get; set; }
    }
}