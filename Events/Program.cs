using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
            room.RoomSoldOut +=  OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();

        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Room is sold out. No more seats available.");
        }
    }

    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }

        private int seatsInUse = 0;
        public int Seats { get; set; }

        public void ReserveSeat()
        {
            seatsInUse++;
            if(seatsInUse >= Seats)
            {
                //Evento Fechado
                Console.WriteLine("Event closed.");
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Seat reserved.");
            }
        }

        public event EventHandler RoomSoldOut;

        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOut;
            handler?.Invoke(this, e);
        }
    }
}