using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reservation:IEntity
    {
        public int Id { get; set; }
        public int ReservationNo { get; set; }
        public string Name { get; set; }
        public int RoomNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
