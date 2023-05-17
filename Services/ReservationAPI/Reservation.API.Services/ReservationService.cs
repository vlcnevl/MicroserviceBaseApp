using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationById(int id)
        {
            return new() {
                Id = id,
                Amount = new Random().Next(0, 10000),
                BookingNumber = new Random().Next(0, 100),
                BookingDate = DateTime.Now,
                CheckinDate = DateTime.Now.AddDays(10),
                CheckoutDate = DateTime.Now.AddDays(17)
                
            };
        }
    }
}
